namespace Esstra.Hit.Client.CodeGen
{
    using System.Text.Json.Serialization;

    public class GetEntityResponseDataItems
    {
        [JsonPropertyName("ENTITY")]
        public string EntityName { get; set; }

        [JsonPropertyName("ENTITYNAME")]
        public string ClassSummary { get; set; }

        [JsonPropertyName("TYP")]
        public string EntityType { get; set; }

        [JsonPropertyName("FELDNAME")]
        public string FieldName { get; set; }

        [JsonPropertyName("FORMAT")]
        public string FieldType { get; set; }

        [JsonPropertyName("FELDBEZ")]
        public string FieldSummary { get; set; }

        [JsonPropertyName("DEFINITION")]
        public string FieldRemarks { get; set; }

        [JsonPropertyName("REQUIRED")]
        public string FieldRequired { get; set; }

        [JsonPropertyName("CODESET")]
        public string FieldCodeset { get; set; }
    }
}