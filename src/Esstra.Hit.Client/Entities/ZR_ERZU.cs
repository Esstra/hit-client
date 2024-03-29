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
    /// Zirkusregister Betriebszuordnungen
    /// </summary>
    [Entity("ZR_ERZU")]
    public class ZR_ERZU
    {
        /// <summary>
        /// Gets or sets the value of "Zirkus Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Registriernummer des Zirkusbetriebes
        /// </remarks>
        [Column("ZR_BNR15")]
        [Required]
        public decimal? ZR_BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Laufende Nummer der Zuordnung".
        /// </summary>
        [Column("ZR_Z_LNR")]
        [Required]
        public Int64? ZR_Z_LNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zuordnungsart".
        /// </summary>
        /// <remarks>
        /// Zuordnungsart von Zirkuseinheiten
        /// </remarks>
        [Column("ZR_Z_ART")]
        [Required]
        public int? ZR_Z_ART { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zugeordneter Betrieb".
        /// </summary>
        /// <remarks>
        /// Registriernummer der zugeordneten Person oder Einheit
        /// </remarks>
        [Column("ZR_Z_BNR15")]
        [Required]
        public decimal? ZR_Z_BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginndatum der Zuordnung".
        /// </summary>
        [Column("ZR_Z_BEDA")]
        public DateOnly? ZR_Z_BEDA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Endedatum der Zuordnung".
        /// </summary>
        [Column("ZR_Z_ENDA")]
        public DateOnly? ZR_Z_ENDA { get; set; }

        /// <summary>
        /// Gets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

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
        /// Gets or sets the value of "Name in Kurzform".
        /// </summary>
        /// <remarks>
        /// Name in Kurzform für Adressfenster
        /// </remarks>
        [Column("NAME")]
        public string? NAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name 2.Zeile".
        /// </summary>
        /// <remarks>
        /// 2.Namenszeile für Adressfenster
        /// </remarks>
        [Column("NAME2")]
        public string? NAME2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ortsteil".
        /// </summary>
        /// <remarks>
        /// Ortsteil wenn erforderlich
        /// </remarks>
        [Column("ORTSTEIL")]
        public string? ORTSTEIL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Strasse Nr".
        /// </summary>
        /// <remarks>
        /// Straße und Hausnummer
        /// </remarks>
        [Column("STR_NR")]
        public string? STR_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "PLZ".
        /// </summary>
        /// <remarks>
        /// Postleitzahl, ggf. internat. ohne Staat
        /// </remarks>
        [Column("PLZ")]
        public string? PLZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ort".
        /// </summary>
        /// <remarks>
        /// Ort
        /// </remarks>
        [Column("ORT")]
        public string? ORT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bemerkungsfeld zur Betriebszurordnung".
        /// </summary>
        /// <remarks>
        /// Bemerkungsfeld zur Betriebszurordnung
        /// </remarks>
        [Column("ZR_Z_BEM")]
        [Required]
        public string? ZR_Z_BEM { get; set; }

    }
}
