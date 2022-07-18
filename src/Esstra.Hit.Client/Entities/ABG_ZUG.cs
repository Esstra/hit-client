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
    /// Abgangs- und Zugangsmeldung kombiniert (Unternehmen/Betriebsstätte und zurück, oder Vollmacht)
    /// </summary>
    [Entity("ABG_ZUG")]
    public class ABG_ZUG
    {
        /// <summary>
        /// Gets or sets the value of "Abgangs/Zugangsdatum für kombinierte Meldung".
        /// </summary>
        [Column("ABZU_DAT")]
        [Required]
        public DateOnly? ABZU_DAT { get; set; }

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
        /// Gets or sets the value of "Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Registriernummer für Betrieb, Langform mit B.Land und Staat
        /// </remarks>
        [Column("BNR15")]
        [Required]
        public decimal? BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nachbesitzer Betrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Nachbesitzers
        /// </remarks>
        [Column("BNR15_NB")]
        public decimal? BNR15_NB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorbesitzer Betrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Vorbesitzers
        /// </remarks>
        [Column("BNR15_VB")]
        public decimal? BNR15_VB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betrieb (Zugang)".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Betriebs mit Zugang
        /// </remarks>
        [Column("BNR15_Z")]
        [Required]
        public decimal? BNR15_Z { get; set; }

        /// <summary>
        /// Gets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldedatum".
        /// </summary>
        /// <remarks>
        /// Datum des Meldeeingang
        /// </remarks>
        [Column("MELD_DAT")]
        [Required]
        public DateOnly? MELD_DAT { get; set; }

        /// <summary>
        /// Gets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldeweg".
        /// </summary>
        /// <remarks>
        /// Meldeweg (Post,IVR,IN...)
        /// </remarks>
        [Column("MELD_WG")]
        [Required]
        public int? MELD_WG { get; set; }

        /// <summary>
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Cluster-Spalte".
        /// </summary>
        /// <remarks>
        /// Systemintern
        /// </remarks>
        [Column("SYS_CLUST")]
        [Required]
        public int? SYS_CLUST { get; set; }

        /// <summary>
        /// Gets or sets the value of "Satzstatus".
        /// </summary>
        /// <remarks>
        /// Systemstatus des Satzes
        /// </remarks>
        [Column("SYS_STAT")]
        [Required]
        public int? SYS_STAT { get; set; }

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
