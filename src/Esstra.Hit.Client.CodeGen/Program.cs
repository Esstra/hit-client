﻿using Esstra.Hit.Client.CodeGen;

using System.Data;
using System.Text.Json;
using System.Text.RegularExpressions;

if (args.Length < 2)
{
    Console.WriteLine("Invalid arguments.");
}
else
{
    var bnr = args[0] ?? throw new ArgumentNullException("bnr");
    var pin = args[1] ?? throw new ArgumentNullException("pin");
    var entitiesFolderPath = args[2] ?? throw new ArgumentNullException("entitiesFolderPath");
    var baseAddress = (args.Length == 4 && !string.IsNullOrWhiteSpace(args[3]) ? args[3] : "https://www.hi-tier.de/HitCom3").TrimEnd('/');

    var getEntityFieldResponseContent = await new HttpClient()
        .GetStringAsync($"{baseAddress}/api/hit/D_MELD_E_E?columns=TYP%3BCODESET%3BREQUIRED%3BFELDNAME%3BTYP%3BENTITYNAME%3BFELDBEZ%3BENTITY%3BFORMAT%3BBEMERKUNG%3BDEFINITION&subcodes=R40000&bnr={bnr}&pin={pin}")
        .ConfigureAwait(false);

    var getEntityFieldResponse = JsonSerializer.Deserialize<GetEntityResponse>(getEntityFieldResponseContent);

    if (!Directory.Exists(entitiesFolderPath))
    {
        Directory.CreateDirectory(entitiesFolderPath);
    }

    foreach (var classFieldDefinition in getEntityFieldResponse
        .Data
        .Items
        .Where(p => p.EntityType != "Funktion" || p.EntityName.StartsWith('#'))
        .GroupBy(p => p.EntityName))
    {
        var className = classFieldDefinition.Key.StartsWith('#')
            ? $"FUNC_{classFieldDefinition.Key.TrimStart('#')}"
            : classFieldDefinition.Key;

        var lines = new List<string>()
        {
            "// ",
            "// This file has been auto-generated by Esstra.Hit.Client.CodeGen.",
            "// ",
            "namespace Esstra.Hit.Client.Entities",
            "{",
            "    using Esstra.Hit.Client.Annotations;",
            "",
            "    using System;",
            "    using System.ComponentModel.DataAnnotations;",
            "    using System.Text.Json.Serialization;",
            "",
        };

        var classSummary = classFieldDefinition.First().ClassSummary;

        if (!string.IsNullOrEmpty(classSummary))
        {
            lines.Add("    /// <summary>");
            lines.Add($"    /// {classSummary}");
            lines.Add("    /// </summary>");
        }

        lines.Add($"    [Entity(\"{className}\")]");
        lines.Add($"    public class {className}");
        lines.Add("    {");

        foreach (var field in classFieldDefinition)
        {
            var fieldName = field.FieldName;

            if (Regex.IsMatch(fieldName, "^[A-Za-z0-9_]+$"))
            {
                var fieldType = (field.FieldType, field.FieldCodeset) switch
                {
                    ("int", "BOOL") => "bool?",
                    ("int", _) => "int?",
                    ("dec", _) => "decimal?",
                    ("lng", _) => "Int64?",
                    ("date", _) => "DateOnly?",
                    ("ts", _) => "DateTime?",
                    _ => "string?"
                };

                if (!string.IsNullOrEmpty(field.FieldSummary))
                {
                    lines.Add("        /// <summary>");
                    lines.Add($"        /// Gets {(field.FieldRequired == "SYS" ? string.Empty : "or sets ")}the value of \"{field.FieldSummary}\".");
                    lines.Add("        /// </summary>");
                }

                if (!string.IsNullOrEmpty(field.FieldRemarks))
                {
                    lines.Add("        /// <remarks>");
                    lines.Add($"        /// {field.FieldRemarks}");
                    lines.Add("        /// </remarks>");
                }

                lines.Add($"        [Column(\"{fieldName}\")]");

                if (field.FieldRequired == "MAN" || field.FieldRequired.StartsWith("PK"))
                {
                    lines.Add("        [Required]");
                }

                if (className == field.FieldName)
                {
                    lines.Add($"        [JsonPropertyName(\"{fieldName}\")]");
                    lines.Add($"        public {fieldType} _{fieldName} {{ get; set; }}");
                }
                else
                {
                    lines.Add($"        public {fieldType} {fieldName} {{ get; set; }}");
                }

                lines.Add("");
            }
            else
            {
                lines.Add($"        // Invalid Property Name: {fieldName}");
            }
        }

        lines.Add("    }");
        lines.Add("}");

        var entityFilePath = Path.Combine(entitiesFolderPath, $"{className}.cs");

        await File.WriteAllLinesAsync(entityFilePath, lines).ConfigureAwait(false);
    }
}