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
    /// Druck legende Stellen für Heimtierpass
    /// </summary>
    [Entity("HT_DRUCK")]
    public class HT_DRUCK
    {
        /// <summary>
        /// Gets or sets the value of "Betriebsnummer Druck legende Stelle für Heimtierpässe".
        /// </summary>
        [Column("BNR15_HTD")]
        [Required]
        public decimal? BNR15_HTD { get; set; }

        /// <summary>
        /// Gets or sets the value of "Einverständnis Online-Anzeige Betriebsstammdaten".
        /// </summary>
        [Column("HT_ONLANZ")]
        [Required]
        public bool? HT_ONLANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Einverständnis Online-Bestellung durch Tierärzte".
        /// </summary>
        [Column("HT_ONLBEST")]
        [Required]
        public bool? HT_ONLBEST { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zulassungsnummer".
        /// </summary>
        [Column("HT_ZULNR")]
        [Required]
        public int? HT_ZULNR { get; set; }

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
        /// Gets or sets the value of "Globally Unique Identifier".
        /// </summary>
        /// <remarks>
        /// Format xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx (lower case)
        /// </remarks>
        [Column("GUID")]
        public string? GUID { get; set; }

    }
}