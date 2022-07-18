// 
// This file has been auto-generated by Esstra.Hit.Client.CodeGen.
// 
namespace Esstra.Hit.Client.Entities
{
    using Esstra.Hit.Client.Annotations;

    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Plausi
    /// </summary>
    [Entity("PLAUSI")]
    public class PLAUSI
    {
        /// <summary>
        /// Gets or sets the value of "Stand".
        /// </summary>
        [Column("STAND")]
        [Required]
        public DateOnly? STAND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schwere".
        /// </summary>
        [Column("SCHWERE")]
        [Required]
        public int? SCHWERE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Pruefung".
        /// </summary>
        [Column("PRUEFUNG")]
        public string? PRUEFUNG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Art".
        /// </summary>
        /// <remarks>
        /// Art der Plausibilitätsprüfung (früher TYP)
        /// </remarks>
        [Column("PLSART")]
        [Required]
        public int? PLSART { get; set; }

        /// <summary>
        /// Gets or sets the value of "PlausiNr".
        /// </summary>
        /// <remarks>
        /// (seit 06.2004 5 statt 4stellig)
        /// </remarks>
        [Column("PLAUSINR")]
        [Required]
        public int? PLAUSINR { get; set; }

        /// <summary>
        /// Gets or sets the value of "MeldEntity".
        /// </summary>
        /// <remarks>
        /// Namen für Meldungsentitäten
        /// </remarks>
        [Column("MELDENTITY")]
        [Required]
        public string? MELDENTITY { get; set; }

        /// <summary>
        /// Gets or sets the value of "Medium".
        /// </summary>
        [Column("MEDIUM")]
        public string? MEDIUM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kurztext".
        /// </summary>
        [Column("KURZTEXT")]
        [Required]
        public string? KURZTEXT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fehlertext".
        /// </summary>
        [Column("FEHLERTEXT")]
        public string? FEHLERTEXT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beschreib".
        /// </summary>
        [Column("BESCHREIB")]
        public string? BESCHREIB { get; set; }

    }
}
