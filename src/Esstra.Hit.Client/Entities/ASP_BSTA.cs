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
    /// ASP-Status, Ergebnis der technischen Plausibilisierung des Betriebes
    /// </summary>
    [Entity("ASP_BSTA")]
    public class ASP_BSTA
    {
        /// <summary>
        /// Gets the value of "Status gültig bis".
        /// </summary>
        [Column("ASP_VALID")]
        public DateOnly? ASP_VALID { get; set; }

        /// <summary>
        /// Gets or sets the value of "Startdatum für Status-Prüfung".
        /// </summary>
        /// <remarks>
        /// zum Überspringen von unkritischen oder gelösten Problemen
        /// </remarks>
        [Column("ASPB_DAT")]
        public DateOnly? ASPB_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "ASP-Betriebsstatus (HIT-Ergebnis)".
        /// </summary>
        [Column("ASPB_ERG")]
        [Required]
        public int? ASPB_ERG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweise zur ASP-Betriebsstatus Prüfung".
        /// </summary>
        [Column("ASPB_HIN")]
        [Required]
        public string? ASPB_HIN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum Fälligkeit der nächsten ASP-Untersuchung".
        /// </summary>
        [Column("ASPB_NEXT")]
        public DateOnly? ASPB_NEXT { get; set; }

        /// <summary>
        /// Gets or sets the value of "ASP-Betriebsstatus".
        /// </summary>
        [Column("ASPB_STA")]
        [Required]
        public int? ASPB_STA { get; set; }

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
        /// Gets or sets the value of "Betriebsnummer Tierarzt oder Vet.Amt, ASP-Untersuchung".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer Tierarzt oder Vet.Amt, ASP-Untersuchung
        /// </remarks>
        [Column("BNR15_ASPU")]
        [Required]
        public decimal? BNR15_ASPU { get; set; }

        /// <summary>
        /// Gets the value of "Bestandsgröße bei der amtlichen ASP-Untersuchung".
        /// </summary>
        [Column("ASPU_ANZ_B")]
        public Int64? ASPU_ANZ_B { get; set; }

        /// <summary>
        /// Gets the value of "Anzahl Produktionseinheiten".
        /// </summary>
        [Column("ASPU_ANZ_P")]
        public int? ASPU_ANZ_P { get; set; }

        /// <summary>
        /// Gets the value of "Anzahl ASP_CHK Wert 0 oder 10".
        /// </summary>
        [Column("ASP_CHK_A0")]
        public int? ASP_CHK_A0 { get; set; }

        /// <summary>
        /// Gets the value of "Anzahl ASP_CHK Wert 1 oder 11".
        /// </summary>
        [Column("ASP_CHK_A1")]
        public int? ASP_CHK_A1 { get; set; }

        /// <summary>
        /// Gets the value of "Anzahl ASP_CHK Wert 2 oder 12".
        /// </summary>
        [Column("ASP_CHK_A2")]
        public int? ASP_CHK_A2 { get; set; }

        /// <summary>
        /// Gets the value of "Anzahl ASP_CHK Wert 3 oder 13".
        /// </summary>
        [Column("ASP_CHK_A3")]
        public int? ASP_CHK_A3 { get; set; }

        /// <summary>
        /// Gets the value of "Anzahl ASP_CHK Wert 4 oder 14".
        /// </summary>
        [Column("ASP_CHK_A4")]
        public int? ASP_CHK_A4 { get; set; }

        /// <summary>
        /// Gets the value of "Anzahl ASP_CHK Wert 5 oder 15".
        /// </summary>
        [Column("ASP_CHK_A5")]
        public int? ASP_CHK_A5 { get; set; }

        /// <summary>
        /// Gets the value of "Anzahl ASP_CHK Wert 10 bis 15 (überzählige)".
        /// </summary>
        [Column("ASP_CHK_AX")]
        public int? ASP_CHK_AX { get; set; }

        /// <summary>
        /// Gets the value of "Berechnungs-Zeitpunkt".
        /// </summary>
        /// <remarks>
        /// Timestamp wann Ergebnis zuletzt gerechnet wurde
        /// </remarks>
        [Column("RECH_TS")]
        public DateTime? RECH_TS { get; set; }

        /// <summary>
        /// Gets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

        /// <summary>
        /// Gets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

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
        /// Gets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

    }
}
