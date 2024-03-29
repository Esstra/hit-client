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
    /// Feiertagstabelle
    /// </summary>
    [Entity("FEIERTAG")]
    public class FEIERTAG
    {
        /// <summary>
        /// Gets or sets the value of "Betriebsnr Feiertag-Bis".
        /// </summary>
        /// <remarks>
        /// Obergrenze für Betriebsnummernbereich in Feiertagstabelle
        /// </remarks>
        [Column("BNR15_FB")]
        [Required]
        public decimal? BNR15_FB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum".
        /// </summary>
        /// <remarks>
        /// Stichtag oder Vorgangsdatum
        /// </remarks>
        [Column("DATUM")]
        [Required]
        public DateOnly? DATUM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Jahr".
        /// </summary>
        /// <remarks>
        /// Jahresangabe, vierstellig
        /// </remarks>
        [Column("JAHR")]
        [Required]
        public int? JAHR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Feiertagsbezeichnung".
        /// </summary>
        /// <remarks>
        /// Name des Feiertags
        /// </remarks>
        [Column("FEIERTAG")]
        [Required]
        [JsonPropertyName("FEIERTAG")]
        public string? _FEIERTAG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnr Feiertag-Von".
        /// </summary>
        /// <remarks>
        /// Untergrenze für Betriebsnummernbereich in Feiertagstabelle
        /// </remarks>
        [Column("BNR15_FV")]
        [Required]
        public decimal? BNR15_FV { get; set; }

    }
}
