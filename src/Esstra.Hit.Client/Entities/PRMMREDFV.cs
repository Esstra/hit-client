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
    /// Milch Reduktion Förderantrag + Verwaltungskontrolle  (View, nur aktuelle)
    /// </summary>
    [Entity("PRMMREDFV")]
    public class PRMMREDFV
    {
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
        /// Gets or sets the value of "Eingangszeitpunkt des Förderantrags".
        /// </summary>
        /// <remarks>
        /// für AS ist das aktueller Speicherzeitpunkt, Verwaltung kann Posteingang angeben
        /// </remarks>
        [Column("MRED_FA_TS")]
        [Required]
        public DateTime? MRED_FA_TS { get; set; }

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
        /// Gets or sets the value of "Milchreduktionsverfahren, Runde".
        /// </summary>
        [Column("MRED_RND")]
        [Required]
        public int? MRED_RND { get; set; }

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
        /// Gets or sets the value of "Kontrollergebnis Antrag fristgerecht".
        /// </summary>
        [Column("MRED_VW1")]
        public bool? MRED_VW1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrollergebnis Milcherzeugernachweis liegt vor".
        /// </summary>
        [Column("MRED_VW2")]
        public bool? MRED_VW2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrollergebnis Antragsunterlagen komplett vorliegend (Milchabrechnungen)".
        /// </summary>
        [Column("MRED_VW3")]
        public bool? MRED_VW3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrollergebnis Angaben zum Referenzzeitraum stimmen mit Papierunterlagen überein".
        /// </summary>
        [Column("MRED_VW4")]
        public bool? MRED_VW4 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrollergebnis geplante Menge im zukünftigen Zeitraum plausibel".
        /// </summary>
        [Column("MRED_VW5")]
        public bool? MRED_VW5 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrollergebnis Datenblatt liegt vor".
        /// </summary>
        [Column("MRED_VW6")]
        public bool? MRED_VW6 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrollergebnis Sonstiger Ablehnungsgrund".
        /// </summary>
        [Column("MRED_VWABL")]
        public string? MRED_VWABL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrollergebnis Grund der Abweichung".
        /// </summary>
        [Column("MRED_VWABW")]
        public int? MRED_VWABW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrolle Endergebnis - Melden ja/nein".
        /// </summary>
        [Column("MRED_VWEE")]
        public bool? MRED_VWEE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Eingangszeitpunkt des Förderantrags, festgestellt".
        /// </summary>
        [Column("MRED_VW_TS")]
        public DateTime? MRED_VW_TS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geplante verringerte Liefermenge im Zielzeitraum, laut VWK".
        /// </summary>
        [Column("MRED_VZIEL")]
        public decimal? MRED_VZIEL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geplante Reduktion, laut VWK oder ggf. Antrag".
        /// </summary>
        [Column("MRED_XRED")]
        public decimal? MRED_XRED { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gelieferte Menge, Summe über gesamten Referenzzeitraum, laut VWK oder ggf. Antrag".
        /// </summary>
        [Column("MRED_XSUM")]
        public decimal? MRED_XSUM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geplante verringerte Liefermenge im Zielzeitraum, laut VWK oder ggf. Antrag".
        /// </summary>
        [Column("MRED_XZIEL")]
        public decimal? MRED_XZIEL { get; set; }

    }
}