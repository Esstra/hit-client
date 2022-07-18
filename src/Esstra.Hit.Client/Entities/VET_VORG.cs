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
    /// Fehlervorgang für Veterinärbehörde
    /// </summary>
    [Entity("VET_VORG")]
    public class VET_VORG
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
        /// Gets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

        /// <summary>
        /// Gets the value of "Meldedatum".
        /// </summary>
        /// <remarks>
        /// Datum des Meldeeingang
        /// </remarks>
        [Column("MELD_DAT")]
        public DateOnly? MELD_DAT { get; set; }

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
        /// Gets or sets the value of "Ohrmarke".
        /// </summary>
        /// <remarks>
        /// IDENTIFICATION NUMBER
        /// </remarks>
        [Column("LOM")]
        [Required]
        public decimal? LOM { get; set; }

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
        /// Gets or sets the value of "Bearbeitungsstatus Veterinär-Vorgangsprüfung".
        /// </summary>
        /// <remarks>
        /// Vom System bzw. Veterinär vergeben
        /// </remarks>
        [Column("VBEA_STAT")]
        [Required]
        public int? VBEA_STAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorgangsdatum".
        /// </summary>
        /// <remarks>
        /// Datum des Vorgangs, i.d.R. Datum der Meldung die den Vorgang ausgelöst hat
        /// </remarks>
        [Column("VORGDAT")]
        [Required]
        public DateOnly? VORGDAT { get; set; }

        /// <summary>
        /// Gets the value of "Cluster-Spalte".
        /// </summary>
        /// <remarks>
        /// Systemintern
        /// </remarks>
        [Column("SYS_CLUST")]
        public int? SYS_CLUST { get; set; }

        /// <summary>
        /// Gets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

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
        /// Gets the value of "Meldeweg".
        /// </summary>
        /// <remarks>
        /// Meldeweg (Post,IVR,IN...)
        /// </remarks>
        [Column("MELD_WG")]
        public int? MELD_WG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schwere".
        /// </summary>
        [Column("SCHWERE")]
        [Required]
        public int? SCHWERE { get; set; }

        /// <summary>
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bearbeitungskommentar Veterinär-Vorgangsprüfung".
        /// </summary>
        /// <remarks>
        /// Vom Veterinär vergebener Kommentar
        /// </remarks>
        [Column("VBEA_KOMM")]
        [Required]
        public string? VBEA_KOMM { get; set; }

        /// <summary>
        /// Gets or sets the value of "VorgLfn".
        /// </summary>
        /// <remarks>
        /// innerhalb Vorgangsnr bzw. Betrieb, Tier oder Antrag
        /// </remarks>
        [Column("VORGLFN")]
        [Required]
        public int? VORGLFN { get; set; }

    }
}
