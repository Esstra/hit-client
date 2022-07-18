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
    /// Milch Reduktion Förderantrag
    /// </summary>
    [Entity("PRMMREDFA")]
    public class PRMMREDFA
    {
        /// <summary>
        /// Gets or sets the value of "Eingangszeitpunkt des Förderantrags".
        /// </summary>
        /// <remarks>
        /// für AS ist das aktueller Speicherzeitpunkt, Verwaltung kann Posteingang angeben
        /// </remarks>
        [Column("MRED_FA_TS")]
        [Required]
        public DateTime? MRED_FA_TS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Milchreduktionsverfahren, Runde".
        /// </summary>
        [Column("MRED_RND")]
        [Required]
        public int? MRED_RND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer des Antragstellers".
        /// </summary>
        [Column("BNR15_AS")]
        [Required]
        public decimal? BNR15_AS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer Tierhalter".
        /// </summary>
        /// <remarks>
        /// speziell im Bereich Tierarzneimittel (TAM)
        /// </remarks>
        [Column("BNR15_HA")]
        [Required]
        public decimal? BNR15_HA { get; set; }

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
        /// Gets or sets the value of "Bestätigung war Milchlieferer im geforderten Monat".
        /// </summary>
        /// <remarks>
        /// für Runde 1 ist das Juli 2016
        /// </remarks>
        [Column("MRED_B1")]
        public bool? MRED_B1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bestätigung Erklärungen gelesen und akzeptiert".
        /// </summary>
        [Column("MRED_B2")]
        public bool? MRED_B2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bestätigung an alle Erstabnehmer gelieferte Mengen angegeben".
        /// </summary>
        [Column("MRED_B3")]
        public bool? MRED_B3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gelieferte Menge im 1. Monat des Referenzzeitraums".
        /// </summary>
        /// <remarks>
        /// für Runde 1 ist das Okt. 2015
        /// </remarks>
        [Column("MRED_M1")]
        public decimal? MRED_M1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gelieferte Menge im 2. Monat des Referenzzeitraums".
        /// </summary>
        /// <remarks>
        /// für Runde 1 ist das Nov. 2015
        /// </remarks>
        [Column("MRED_M2")]
        public decimal? MRED_M2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gelieferte Menge im 3. Monat des Referenzzeitraums".
        /// </summary>
        /// <remarks>
        /// für Runde 1 ist das Dez. 2015
        /// </remarks>
        [Column("MRED_M3")]
        public decimal? MRED_M3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geplante Reduktion".
        /// </summary>
        /// <remarks>
        /// errechnet sich aus MSUM - MZIEL
        /// </remarks>
        [Column("MRED_MRED")]
        public decimal? MRED_MRED { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gelieferte Menge, Summe über gesamten Referenzzeitraum".
        /// </summary>
        /// <remarks>
        /// für Runde 1 ist das Okt. - Dez. 2015
        /// </remarks>
        [Column("MRED_MSUM")]
        public decimal? MRED_MSUM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geplante verringerte Liefermenge im Zielzeitraum".
        /// </summary>
        /// <remarks>
        /// für Runde 1 ist das Okt. - Dez. 2016
        /// </remarks>
        [Column("MRED_MZIEL")]
        public decimal? MRED_MZIEL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Daten plausibel".
        /// </summary>
        [Column("MRED_OK")]
        [Required]
        public bool? MRED_OK { get; set; }

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

    }
}