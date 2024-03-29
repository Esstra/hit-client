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
    /// BSE-Test Messdaten
    /// </summary>
    [Entity("BSETMDA")]
    public class BSETMDA
    {
        /// <summary>
        /// Gets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

        /// <summary>
        /// Gets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets the value of "Satzstatus".
        /// </summary>
        /// <remarks>
        /// Systemstatus des Satzes
        /// </remarks>
        [Column("SYS_STAT")]
        public int? SYS_STAT { get; set; }

        /// <summary>
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "PID-Betrieb, Proben-Identifikation Ausgabebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Proben-ID-Bereich verwaltet (ursprünglich BSE, dann universell)
        /// </remarks>
        [Column("BSEPID_BNR")]
        [Required]
        public decimal? BSEPID_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "PID-Probe, Proben-Identifikation Sub-Part".
        /// </summary>
        /// <remarks>
        /// spezifische eindeutige ID innerhalb des Systems einer Ausgabestelle (urspr. BSE, dann universell)
        /// </remarks>
        [Column("BSEPID_SUB")]
        [Required]
        public string? BSEPID_SUB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Interne Labornummer".
        /// </summary>
        /// <remarks>
        /// interne Identifikation des Testes
        /// </remarks>
        [Column("BSETINT_ID")]
        [Required]
        public string? BSETINT_ID { get; set; }

        /// <summary>
        /// Gets or sets the value of "Platten-ID im Labor".
        /// </summary>
        /// <remarks>
        /// eindeutige Kennzeichnung innerhalb des Labors
        /// </remarks>
        [Column("BSETPLA_ID")]
        [Required]
        public string? BSETPLA_ID { get; set; }

        /// <summary>
        /// Gets or sets the value of "Mess-Wert (Korrigiert)".
        /// </summary>
        /// <remarks>
        /// Format je nach Test
        /// </remarks>
        [Column("KORR_WERT")]
        public decimal? KORR_WERT { get; set; }

        /// <summary>
        /// Gets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Mess-Position".
        /// </summary>
        /// <remarks>
        /// i.d.R. als Koordinate A1 - x12
        /// </remarks>
        [Column("MESS_POS")]
        [Required]
        public string? MESS_POS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Laufende Nummer der Messung".
        /// </summary>
        /// <remarks>
        /// Laufende Nummer ab 1, bei Doppelansatz auch hochzählen
        /// </remarks>
        [Column("MESS_LFNR")]
        [Required]
        public int? MESS_LFNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Mess-Wert (Rohdaten)".
        /// </summary>
        /// <remarks>
        /// Format je nach Test
        /// </remarks>
        [Column("MESS_WERT")]
        [Required]
        public decimal? MESS_WERT { get; set; }

        /// <summary>
        /// Gets or sets the value of "BSE-Probeneingang - Zeit".
        /// </summary>
        /// <remarks>
        /// Zeit des Zeitpunkts der Einzelprobenerfassung
        /// </remarks>
        [Column("UNTS_EZEIT")]
        [Required]
        public string? UNTS_EZEIT { get; set; }

        /// <summary>
        /// Gets or sets the value of "BSE-Untersuchungsergebnis (einzeln)".
        /// </summary>
        /// <remarks>
        /// Ergebnis der einzelnen Messreihe ohne Wiederholung
        /// </remarks>
        [Column("UNTS_ERGE")]
        [Required]
        public int? UNTS_ERGE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Probeneingang - Datum".
        /// </summary>
        /// <remarks>
        /// Datum des Zeitpunkts der Einzelprobenerfassung
        /// </remarks>
        [Column("UNTS_EDAT")]
        [Required]
        public DateOnly? UNTS_EDAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsbefund - Zeit".
        /// </summary>
        [Column("UNTS_BZEIT")]
        [Required]
        public string? UNTS_BZEIT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungslabor".
        /// </summary>
        /// <remarks>
        /// Betriebsnr des Untersuchungslabor oder -anstalt
        /// </remarks>
        [Column("UNTS_BNR15")]
        [Required]
        public decimal? UNTS_BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "BSE-Untersuchungsbemerkung".
        /// </summary>
        /// <remarks>
        /// Frei verfügbares Feld für Bemerkungen
        /// </remarks>
        [Column("UNTS_BEM")]
        public string? UNTS_BEM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tierbefund (Probenahme) / Untersuchungsbefund - Datum".
        /// </summary>
        /// <remarks>
        /// Datum der Messdaten-Untersuchung für BSETEST, Tierbefund (möglichst Probennahme) für BHVTEST
        /// </remarks>
        [Column("UNTS_BDAT")]
        [Required]
        public DateOnly? UNTS_BDAT { get; set; }

    }
}
