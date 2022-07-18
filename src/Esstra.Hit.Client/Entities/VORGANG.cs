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
    /// VVVO-Vorgang für Melder
    /// </summary>
    [Entity("VORGANG")]
    public class VORGANG
    {
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
        /// Gets or sets the value of "Data-Timestamp von".
        /// </summary>
        /// <remarks>
        /// SYS_VON des Datensatzes
        /// </remarks>
        [Column("DATA_VON")]
        [Required]
        public DateTime? DATA_VON { get; set; }

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
        /// Gets the value of "Cluster-Spalte".
        /// </summary>
        /// <remarks>
        /// Systemintern
        /// </remarks>
        [Column("SYS_CLUST")]
        public int? SYS_CLUST { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schwere".
        /// </summary>
        [Column("SCHWERE")]
        [Required]
        public int? SCHWERE { get; set; }

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
        /// Gets or sets the value of "Entity".
        /// </summary>
        [Column("ENTITY")]
        [Required]
        public string? ENTITY { get; set; }

        /// <summary>
        /// Gets or sets the value of "VorgNr".
        /// </summary>
        /// <remarks>
        /// Vorgangsnummer des VVVO-Vorgangs
        /// </remarks>
        [Column("VORGNR")]
        [Required]
        public Int64? VORGNR { get; set; }

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
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "VorgLfn".
        /// </summary>
        /// <remarks>
        /// innerhalb Vorgangsnr bzw. Betrieb, Tier oder Antrag
        /// </remarks>
        [Column("VORGLFN")]
        [Required]
        public int? VORGLFN { get; set; }

        /// <summary>
        /// Gets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

    }
}