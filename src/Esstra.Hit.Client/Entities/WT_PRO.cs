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
    /// Wild-Tierfund Melde-App - Probe
    /// </summary>
    [Entity("WT_PRO")]
    public class WT_PRO
    {
        /// <summary>
        /// Gets or sets the value of "Proben-ID Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// BNR i.d.R. Landeslabor, das Eindeutigkeit der PID gewährleistet
        /// </remarks>
        [Column("WT_PID_BNR")]
        [Required]
        public decimal? WT_PID_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Proben-ID".
        /// </summary>
        /// <remarks>
        /// Eindeutige-Proben-ID, id.R. aus Probenbarcode
        /// </remarks>
        [Column("WT_PID_SUB")]
        [Required]
        public string? WT_PID_SUB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Wildursprungsmarke".
        /// </summary>
        [Column("WT_WILDURM")]
        [Required]
        public string? WT_WILDURM { get; set; }

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
        /// Gets or sets the value of "Globally Unique Identifier".
        /// </summary>
        /// <remarks>
        /// Format xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx (lower case)
        /// </remarks>
        [Column("GUID")]
        public string? GUID { get; set; }

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
        /// Gets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

        /// <summary>
        /// Gets the value of "Meldeweg".
        /// </summary>
        /// <remarks>
        /// Meldeweg (Post,IVR,IN...)
        /// </remarks>
        [Column("MELD_WG")]
        public int? MELD_WG { get; set; }

        /// <summary>
        /// Gets the value of "Stornobetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung storniert hat
        /// </remarks>
        [Column("STRN_BNR")]
        public decimal? STRN_BNR { get; set; }

        /// <summary>
        /// Gets the value of "Stornomitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung storniert hat
        /// </remarks>
        [Column("STRN_MBN")]
        public int? STRN_MBN { get; set; }

        /// <summary>
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets the value of "Satzstatus".
        /// </summary>
        /// <remarks>
        /// Systemstatus des Satzes
        /// </remarks>
        [Column("SYS_STAT")]
        public int? SYS_STAT { get; set; }

        /// <summary>
        /// Gets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsgrund, im Untersuchungsauftrag".
        /// </summary>
        [Column("UNTS_GRUND")]
        [Required]
        public int? UNTS_GRUND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Probenart".
        /// </summary>
        /// <remarks>
        /// Beschreibt die Art der Probe die genommen wurde
        /// </remarks>
        [Column("WT_PROBART")]
        [Required]
        public int? WT_PROBART { get; set; }

        /// <summary>
        /// Gets or sets the value of "Wildursprungsmarken-System".
        /// </summary>
        [Column("WT_WURMSYS")]
        [Required]
        public int? WT_WURMSYS { get; set; }

    }
}
