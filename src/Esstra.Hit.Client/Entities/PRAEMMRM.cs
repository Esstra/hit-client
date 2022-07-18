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
    /// Prämien Milch-Referenzmenge
    /// </summary>
    [Entity("PRAEMMRM")]
    public class PRAEMMRM
    {
        /// <summary>
        /// Gets or sets the value of "Tatsächliche Liefermenge".
        /// </summary>
        /// <remarks>
        /// Abgelieferte Milchmenge bei Molkerei bzw. Direktvermarktete Menge bei HZA
        /// </remarks>
        [Column("LIEF_MENGE")]
        [Required]
        public Int64? LIEF_MENGE { get; set; }

        /// <summary>
        /// Gets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Milch-Lieferant-Nachfolgernummer".
        /// </summary>
        /// <remarks>
        /// Laufende Nummer 0 bis n, wenn innerhalb des Jahres mehrer Personen unter Lieferantennr existierten
        /// </remarks>
        [Column("LIEFERNFL")]
        [Required]
        public int? LIEFERNFL { get; set; }

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
        /// Gets or sets the value of "Datenlieferumfang für Milchprämie".
        /// </summary>
        /// <remarks>
        /// hier wird vermerkt ob alls Daten (RM 31.3 + 1.4) oder wg. Widerspruch nur RM 1.4 (die ist Pflicht)
        /// </remarks>
        [Column("DATENUMF")]
        public int? DATENUMF { get; set; }

        /// <summary>
        /// Gets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

        /// <summary>
        /// Gets the value of "Meldedatum".
        /// </summary>
        /// <remarks>
        /// Datum des Meldeeingang
        /// </remarks>
        [Column("MELD_DAT")]
        public DateOnly? MELD_DAT { get; set; }

        /// <summary>
        /// Gets the value of "Meldeweg".
        /// </summary>
        /// <remarks>
        /// Meldeweg (Post,IVR,IN...)
        /// </remarks>
        [Column("MELD_WG")]
        public int? MELD_WG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tatsächliche Liefertage im Zeitraum".
        /// </summary>
        /// <remarks>
        /// Liefertage bei der Molkerei vom 1.4 des Vorjahres bis 31.3. Des aktuellen Meldejahres
        /// </remarks>
        [Column("LIEF_TAGE")]
        public int? LIEF_TAGE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Milch-Lieferant".
        /// </summary>
        /// <remarks>
        /// Lieferantennummer der Molkerei oder Zollnummer
        /// </remarks>
        [Column("LIEFERANT")]
        [Required]
        public decimal? LIEFERANT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nummer des zuständigen Hauptzollamtes".
        /// </summary>
        /// <remarks>
        /// Bei ARM für die Molkerei zuständiges HZA, bei DRM das zuständige HZA
        /// </remarks>
        [Column("HZA_NR")]
        [Required]
        public int? HZA_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Jahr".
        /// </summary>
        /// <remarks>
        /// Jahresangabe, vierstellig
        /// </remarks>
        [Column("JAHR")]
        [Required]
        public int? JAHR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Referenzmenge zum 31.3 des Jahres".
        /// </summary>
        /// <remarks>
        /// Ablieferungsreferenzmenge der Molkerei bzw. Direktverkaufsreferenzmenge HZA
        /// </remarks>
        [Column("RM_31_03")]
        [Required]
        public Int64? RM_31_03 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ort".
        /// </summary>
        /// <remarks>
        /// Ort
        /// </remarks>
        [Column("ORT")]
        [Required]
        public string? ORT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name in Kurzform".
        /// </summary>
        /// <remarks>
        /// Name in Kurzform für Adressfenster
        /// </remarks>
        [Column("NAME")]
        [Required]
        public string? NAME { get; set; }

        /// <summary>
        /// Gets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name 2.Zeile".
        /// </summary>
        /// <remarks>
        /// 2.Namenszeile für Adressfenster
        /// </remarks>
        [Column("NAME2")]
        public string? NAME2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Strasse Nr".
        /// </summary>
        /// <remarks>
        /// Straße und Hausnummer
        /// </remarks>
        [Column("STR_NR")]
        [Required]
        public string? STR_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Referenzmenge zum 1.4 des Jahres".
        /// </summary>
        /// <remarks>
        /// Ablieferungsreferenzmenge der Molkerei für Sonder- und Mutterkuhprämie
        /// </remarks>
        [Column("RM_01_04")]
        public Int64? RM_01_04 { get; set; }

        /// <summary>
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Typ der Referenzmenge".
        /// </summary>
        /// <remarks>
        /// Anlieferungs-RM oder Direktvermarktungs-RM ...
        /// </remarks>
        [Column("RM_TYP")]
        [Required]
        public int? RM_TYP { get; set; }

        /// <summary>
        /// Gets or sets the value of "PLZ".
        /// </summary>
        /// <remarks>
        /// Postleitzahl, ggf. internat. ohne Staat
        /// </remarks>
        [Column("PLZ")]
        [Required]
        public string? PLZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ortsteil".
        /// </summary>
        /// <remarks>
        /// Ortsteil wenn erforderlich
        /// </remarks>
        [Column("ORTSTEIL")]
        public string? ORTSTEIL { get; set; }

    }
}
