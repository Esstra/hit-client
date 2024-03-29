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
    /// Statusdaten von Belegenheitsland, GSAA zu ELER- und GSAA-Childs
    /// </summary>
    [Entity("Z2_ST_VBLE")]
    public class Z2_ST_VBLE
    {
        /// <summary>
        /// Gets or sets the value of "Antragsjahr".
        /// </summary>
        /// <remarks>
        /// für GSAA
        /// </remarks>
        [Column("ANT_JAHR")]
        [Required]
        public int? ANT_JAHR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Antragsland Belegenheit der Fläche (BLL)".
        /// </summary>
        /// <remarks>
        /// für GSAA
        /// </remarks>
        [Column("BL_LAND")]
        [Required]
        public int? BL_LAND { get; set; }

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
        /// Gets or sets the value of "BNR15 der zuständigen Verwaltungseinheit".
        /// </summary>
        [Column("BNR15_AMT")]
        public decimal? BNR15_AMT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer aus Land der Belegenheit (BLL)".
        /// </summary>
        /// <remarks>
        /// für GSAA
        /// </remarks>
        [Column("BNR15_BLL")]
        [Required]
        public decimal? BNR15_BLL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer aus Land des Betriebssitzes (BSL)".
        /// </summary>
        /// <remarks>
        /// für GSAA
        /// </remarks>
        [Column("BNR15_BSL")]
        [Required]
        public decimal? BNR15_BSL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Child-Betrieb".
        /// </summary>
        /// <remarks>
        /// Abhängiger Betrieb bei Zuordnung
        /// </remarks>
        [Column("BNR15_C")]
        [Required]
        public decimal? BNR15_C { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zuordnung gültig bis".
        /// </summary>
        /// <remarks>
        /// fachlich gültig bis oder aktuell (31.12.2100)
        /// </remarks>
        [Column("DZUO_BIS")]
        [Required]
        public DateTime? DZUO_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zuordnung gültig von".
        /// </summary>
        /// <remarks>
        /// Timestamp ab wann der Satz fachlich gilt
        /// </remarks>
        [Column("DZUO_VON")]
        [Required]
        public DateTime? DZUO_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Auswahl aus einer GG im BLL".
        /// </summary>
        [Column("GG_BLL")]
        [Required]
        public int? GG_BLL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Auswahl aus einer GG im BSL".
        /// </summary>
        [Column("GG_BSL")]
        [Required]
        public int? GG_BSL { get; set; }

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
        /// Gets or sets the value of "storniert (Teil A)".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information im Teil A technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS_A")]
        public DateTime? SYS_BIS_A { get; set; }

        /// <summary>
        /// Gets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "gespeichert (Teil A)".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information im Teil A technisch gültig ist
        /// </remarks>
        [Column("SYS_VON_A")]
        public DateTime? SYS_VON_A { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zuordnungstyp".
        /// </summary>
        /// <remarks>
        /// Typ der Betriebszuordnung
        /// </remarks>
        [Column("TYP_ZUO")]
        [Required]
        public int? TYP_ZUO { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK wurde verweigert".
        /// </summary>
        [Column("VOK_VERW")]
        public bool? VOK_VERW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Wann wurde die VWK/VOK je Maßnahme abgeschlossen".
        /// </summary>
        [Column("Z2KONT_ABG")]
        public DateOnly? Z2KONT_ABG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Methode der Auswahl zur VOK".
        /// </summary>
        [Column("Z2VOK_AUSW")]
        public int? Z2VOK_AUSW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum der Ankündigung VOK".
        /// </summary>
        [Column("Z2VOK_DATA")]
        public DateOnly? Z2VOK_DATA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum Durchführung der VOK".
        /// </summary>
        [Column("Z2VOK_DATD")]
        public DateOnly? Z2VOK_DATD { get; set; }

        /// <summary>
        /// Gets or sets the value of "Status_Typ, Art der Kontrolle VWK/VOK".
        /// </summary>
        [Column("Z2_ST_TYP")]
        [Required]
        public int? Z2_ST_TYP { get; set; }

    }
}
