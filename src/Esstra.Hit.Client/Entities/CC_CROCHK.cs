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
    /// CC-Kontrolle - Mitteilung an andere Behörden, Cross-Check
    /// </summary>
    [Entity("CC_CROCHK")]
    public class CC_CROCHK
    {
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
        /// Gets or sets the value of "Fachbehörde für Cross-Check".
        /// </summary>
        /// <remarks>
        /// Registriernummer der zuständigen Fachbehörde
        /// </remarks>
        [Column("BNR15_BCRO")]
        [Required]
        public decimal? BNR15_BCRO { get; set; }

        /// <summary>
        /// Gets or sets the value of "Prüfbehörde für Cross-Compliance".
        /// </summary>
        /// <remarks>
        /// Registriernummer der zuständigen Prüfbehörde
        /// </remarks>
        [Column("BNR15_PBCC")]
        [Required]
        public decimal? BNR15_PBCC { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer des Unternehmens für Cross-Compliance".
        /// </summary>
        /// <remarks>
        /// Antragsteller-Registriernummer
        /// </remarks>
        [Column("BNR15_UNCC")]
        [Required]
        public decimal? BNR15_UNCC { get; set; }

        /// <summary>
        /// Gets or sets the value of "Standard mit Angabe von Cross-Check".
        /// </summary>
        [Column("CROCHK_STD")]
        [Required]
        public int? CROCHK_STD { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 1 Umwelt - ELER Phosphat".
        /// </summary>
        [Column("CROS_ELP")]
        [Required]
        public bool? CROS_ELP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß in einem anderen Bereich".
        /// </summary>
        [Column("CROS_JN")]
        [Required]
        public bool? CROS_JN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 3 Tierschutz - Haltung Kälber".
        /// </summary>
        [Column("CROS_TKA")]
        [Required]
        public bool? CROS_TKA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 3 Tierschutz - landwirtschaftliche Nutztiere".
        /// </summary>
        [Column("CROS_TLN")]
        [Required]
        public bool? CROS_TLN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 3 Tierschutz - Haltung Schweine".
        /// </summary>
        [Column("CROS_TSW")]
        [Required]
        public bool? CROS_TSW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 1 Umwelt - FFH".
        /// </summary>
        [Column("CROS_UFF")]
        [Required]
        public bool? CROS_UFF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 1 Umwelt - Grundwasser".
        /// </summary>
        [Column("CROS_UGR")]
        [Required]
        public bool? CROS_UGR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 1 Umwelt - Klärschlamm".
        /// </summary>
        [Column("CROS_UKS")]
        [Required]
        public bool? CROS_UKS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 1 Umwelt - Nitrat".
        /// </summary>
        [Column("CROS_UNI")]
        [Required]
        public bool? CROS_UNI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 1 Umwelt - Vogelschutz".
        /// </summary>
        [Column("CROS_UVO")]
        [Required]
        public bool? CROS_UVO { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 2 Gesundheit - Futtermittel".
        /// </summary>
        [Column("CROS_VFM")]
        [Required]
        public bool? CROS_VFM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 2 Gesundheit - Hormonrichtlinie / Mitteilung".
        /// </summary>
        [Column("CROS_VHO")]
        [Required]
        public bool? CROS_VHO { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 2 Gesundheit - Lebensmittel pflanzlicher/tierischer Herkunft".
        /// </summary>
        [Column("CROS_VLP")]
        [Required]
        public bool? CROS_VLP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 2 Gesundheit - TSE".
        /// </summary>
        [Column("CROS_VLT")]
        [Required]
        public bool? CROS_VLT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 2 Gesundheit - Pflanzenschutzmittel".
        /// </summary>
        [Column("CROS_VPS")]
        [Required]
        public bool? CROS_VPS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 2 Gesundheit - Rinder".
        /// </summary>
        [Column("CROS_VRI")]
        [Required]
        public bool? CROS_VRI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 2 Gesundheit - Schweine".
        /// </summary>
        [Column("CROS_VSW")]
        [Required]
        public bool? CROS_VSW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 2 Gesundheit - Schafe und Ziegen".
        /// </summary>
        [Column("CROS_VSZ")]
        [Required]
        public bool? CROS_VSZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 4 weiteres - Anhang IV".
        /// </summary>
        [Column("CROS_WA4")]
        [Required]
        public bool? CROS_WA4 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Jahr der Risikoanalyse (Kontrolljahr)".
        /// </summary>
        /// <remarks>
        /// Jahresangabe, vierstellig
        /// </remarks>
        [Column("RIS_JAHR")]
        [Required]
        public int? RIS_JAHR { get; set; }

        /// <summary>
        /// Gets or sets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        [Required]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        [Required]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Ankündigung".
        /// </summary>
        /// <remarks>
        /// Art der Ankündigung bei Vor-Ort-Kontrolle
        /// </remarks>
        [Column("VOK_ANKD")]
        public int? VOK_ANKD { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Datum".
        /// </summary>
        /// <remarks>
        /// Datum der Vor-Ort-Kontrolle
        /// </remarks>
        [Column("VOK_DAT")]
        [Required]
        public DateOnly? VOK_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK gestattet".
        /// </summary>
        /// <remarks>
        /// Wurde Vor-Ort-Kontrolle gestattet
        /// </remarks>
        [Column("VOK_GEST")]
        [Required]
        public int? VOK_GEST { get; set; }

    }
}
