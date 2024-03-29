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
    /// Rinder Bewegung (mit Haltungsdauer)
    /// </summary>
    [Entity("RI_BEWEGX")]
    public class RI_BEWEGX
    {
        /// <summary>
        /// Gets or sets the value of "Abgangsdatum".
        /// </summary>
        [Column("ABGA_DAT")]
        [Required]
        public DateOnly? ABGA_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Registriernummer für Betrieb, Langform mit B.Land und Staat
        /// </remarks>
        [Column("BNR15")]
        [Required]
        public decimal? BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorbesitzer Betrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Vorbesitzers
        /// </remarks>
        [Column("BNR15_VB")]
        [Required]
        public decimal? BNR15_VB { get; set; }

        /// <summary>
        /// Gets the value of "Data-Timestamp von".
        /// </summary>
        /// <remarks>
        /// SYS_VON des Datensatzes
        /// </remarks>
        [Column("DATA_VON")]
        public DateTime? DATA_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Haltungstage".
        /// </summary>
        [Column("LLF_HATT")]
        public Int64? LLF_HATT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohrmarke".
        /// </summary>
        /// <remarks>
        /// IDENTIFICATION NUMBER
        /// </remarks>
        [Column("LOM")]
        [Required]
        public decimal? LOM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zugangsdatum".
        /// </summary>
        [Column("ZUGA_DAT")]
        [Required]
        public DateOnly? ZUGA_DAT { get; set; }

    }
}
