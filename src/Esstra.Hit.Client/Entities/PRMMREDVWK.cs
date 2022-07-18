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
    /// Milch Reduktion Verwaltungskontrolle, Förderantrag
    /// </summary>
    [Entity("PRMMREDVWK")]
    public class PRMMREDVWK
    {
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
        /// Gets or sets the value of "Milchreduktionsverfahren, Runde".
        /// </summary>
        [Column("MRED_RND")]
        [Required]
        public int? MRED_RND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrollergebnis Antrag fristgerecht".
        /// </summary>
        [Column("MRED_VW1")]
        [Required]
        public bool? MRED_VW1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrollergebnis Milcherzeugernachweis liegt vor".
        /// </summary>
        [Column("MRED_VW2")]
        [Required]
        public bool? MRED_VW2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrollergebnis Antragsunterlagen komplett vorliegend (Milchabrechnungen)".
        /// </summary>
        [Column("MRED_VW3")]
        [Required]
        public bool? MRED_VW3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrollergebnis Angaben zum Referenzzeitraum stimmen mit Papierunterlagen überein".
        /// </summary>
        [Column("MRED_VW4")]
        [Required]
        public bool? MRED_VW4 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrollergebnis geplante Menge im zukünftigen Zeitraum plausibel".
        /// </summary>
        [Column("MRED_VW5")]
        [Required]
        public bool? MRED_VW5 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrollergebnis Datenblatt liegt vor".
        /// </summary>
        [Column("MRED_VW6")]
        [Required]
        public bool? MRED_VW6 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrollergebnis Sonstiger Ablehnungsgrund".
        /// </summary>
        [Column("MRED_VWABL")]
        [Required]
        public string? MRED_VWABL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrollergebnis Grund der Abweichung".
        /// </summary>
        [Column("MRED_VWABW")]
        [Required]
        public int? MRED_VWABW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrolle Endergebnis - Melden ja/nein".
        /// </summary>
        [Column("MRED_VWEE")]
        [Required]
        public bool? MRED_VWEE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Eingangszeitpunkt des Förderantrags, festgestellt".
        /// </summary>
        [Column("MRED_VW_TS")]
        [Required]
        public DateTime? MRED_VW_TS { get; set; }

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
        /// Gets or sets the value of "Betriebsnummer des Antragstellers".
        /// </summary>
        [Column("BNR15_AS")]
        [Required]
        public decimal? BNR15_AS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gelieferte Menge im 1. Monat des Referenzzeitraums, laut VWK".
        /// </summary>
        [Column("MRED_V1")]
        public decimal? MRED_V1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gelieferte Menge im 2. Monat des Referenzzeitraums, laut VWK".
        /// </summary>
        [Column("MRED_V2")]
        public decimal? MRED_V2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gelieferte Menge im 3. Monat des Referenzzeitraums, laut VWK".
        /// </summary>
        [Column("MRED_V3")]
        public decimal? MRED_V3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geplante Reduktion, laut VWK".
        /// </summary>
        [Column("MRED_VRED")]
        public decimal? MRED_VRED { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gelieferte Menge, Summe über gesamten Referenzzeitraum, laut VWK".
        /// </summary>
        [Column("MRED_VSUM")]
        public decimal? MRED_VSUM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geplante verringerte Liefermenge im Zielzeitraum, laut VWK".
        /// </summary>
        [Column("MRED_VZIEL")]
        public decimal? MRED_VZIEL { get; set; }

    }
}
