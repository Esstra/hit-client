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
    /// Equidendaten für öffentliche Anzeige
    /// </summary>
    [Entity("EQ_PUBLIC")]
    public class EQ_PUBLIC
    {
        /// <summary>
        /// Gets or sets the value of "Ausstellungsdatum des Equidenpasses".
        /// </summary>
        /// <remarks>
        /// Datum der Pass-Ausstellung
        /// </remarks>
        [Column("AUS_DAT_E")]
        [Required]
        public DateOnly? AUS_DAT_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Aussteller des Equidenpasses".
        /// </summary>
        /// <remarks>
        /// Registriernummer der Stelle, die den Equidenpass ausgestellt hat
        /// </remarks>
        [Column("BNR15_PA_E")]
        [Required]
        public decimal? BNR15_PA_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Equidenpass Dokumentenart".
        /// </summary>
        /// <remarks>
        /// Pass-Art (Original, Duplikat, Ersatz)
        /// </remarks>
        [Column("DOKART_E")]
        [Required]
        public int? DOKART_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Laufende Nummer des Equiden-Dokuments".
        /// </summary>
        /// <remarks>
        /// Laufende Nummer bei Erst- und Nachausstellung (Erstausstellungen 1, weitere Ausstellungen 2..n)
        /// </remarks>
        [Column("DOKLFN_E")]
        [Required]
        public int? DOKLFN_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "E-Mail".
        /// </summary>
        /// <remarks>
        /// E-Mailadresse
        /// </remarks>
        [Column("EMAIL")]
        public string? EMAIL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fax".
        /// </summary>
        /// <remarks>
        /// Fax-Anschluß
        /// </remarks>
        [Column("FAX")]
        public string? FAX { get; set; }

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
        /// Gets or sets the value of "Name 2.Zeile".
        /// </summary>
        /// <remarks>
        /// 2.Namenszeile für Adressfenster
        /// </remarks>
        [Column("NAME2")]
        public string? NAME2 { get; set; }

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
        /// Gets or sets the value of "Ortsteil".
        /// </summary>
        /// <remarks>
        /// Ortsteil wenn erforderlich
        /// </remarks>
        [Column("ORTSTEIL")]
        public string? ORTSTEIL { get; set; }

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
        /// Gets or sets the value of "Strasse Nr".
        /// </summary>
        /// <remarks>
        /// Straße und Hausnummer
        /// </remarks>
        [Column("STR_NR")]
        [Required]
        public string? STR_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Telefon".
        /// </summary>
        /// <remarks>
        /// Telefon-Anschluß
        /// </remarks>
        [Column("TELEFON")]
        public string? TELEFON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Transponder-Nr".
        /// </summary>
        /// <remarks>
        /// IDENTIFICATION NUMBER, momentan beschränkt auf Equiden
        /// </remarks>
        [Column("TRNR15")]
        [Required]
        public decimal? TRNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Equidennummer UELN".
        /// </summary>
        /// <remarks>
        /// Unique equestrian lifetime number (Eingabe mit DE erlaubt)
        /// </remarks>
        [Column("UELN")]
        public string? UELN { get; set; }

    }
}
