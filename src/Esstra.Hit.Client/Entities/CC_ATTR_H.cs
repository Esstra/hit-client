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
    /// Attribute aus HIT/ZID für Risikoanalyse
    /// </summary>
    [Entity("CC_ATTR_H")]
    public class CC_ATTR_H
    {
        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren WA4".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Anhang IV, in %
        /// </remarks>
        [Column("CA67_V_WA4")]
        public int? CA67_V_WA4 { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren TLN".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Tierschutz LN, in %
        /// </remarks>
        [Column("CA66_V_TLN")]
        public int? CA66_V_TLN { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren TSW".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Tierschutz Schweine, in %
        /// </remarks>
        [Column("CA65_V_TSW")]
        public int? CA65_V_TSW { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren TKA".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Tierschutz Kälber, in %
        /// </remarks>
        [Column("CA64_V_TKA")]
        public int? CA64_V_TKA { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren VLT".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - TSE, in %
        /// </remarks>
        [Column("CA63_V_VLT")]
        public int? CA63_V_VLT { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren VLP".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Lebensmittel pflanzlicher/tierischer Herkunft, in %
        /// </remarks>
        [Column("CA62_V_VLP")]
        public int? CA62_V_VLP { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren VFM".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Futtermittel, in %
        /// </remarks>
        [Column("CA61_V_VFM")]
        public int? CA61_V_VFM { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK-Probleme".
        /// </summary>
        /// <remarks>
        /// Probleme bei VOK festgestellt
        /// </remarks>
        [Column("VG_VOK_PRB")]
        public Int64? VG_VOK_PRB { get; set; }

        /// <summary>
        /// Gets or sets the value of "ist Nachfolger".
        /// </summary>
        /// <remarks>
        /// Betrieb ist aktuell Nachfolger
        /// </remarks>
        [Column("VG_IS_NACH")]
        public Int64? VG_IS_NACH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Stornoanteil".
        /// </summary>
        /// <remarks>
        /// Stornoanteil
        /// </remarks>
        [Column("VG_STO_ANT")]
        public Int64? VG_STO_ANT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bestandsveränderung".
        /// </summary>
        /// <remarks>
        /// Bestandsveränderung als %-Steigerung gegenüber Vorjahr
        /// </remarks>
        [Column("VG_BES_DTA")]
        public Int64? VG_BES_DTA { get; set; }

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
        /// Gets or sets the value of "Betriebsnummer des Unternehmens für Cross-Compliance".
        /// </summary>
        /// <remarks>
        /// Antragsteller-Registriernummer
        /// </remarks>
        [Column("BNR15_UNCC")]
        [Required]
        public decimal? BNR15_UNCC { get; set; }

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
        /// Gets or sets the value of "max.Verstoß aus Vorjahren VHO".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Hormone, in %
        /// </remarks>
        [Column("CA60_V_VHO")]
        public int? CA60_V_VHO { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren VPS".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Pflanzenschutz, in %
        /// </remarks>
        [Column("CA59_V_VPS")]
        public int? CA59_V_VPS { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren VSZ".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Schafe/Ziegen, in %
        /// </remarks>
        [Column("CA58_V_VSZ")]
        public int? CA58_V_VSZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren VSW".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Schweine, in %
        /// </remarks>
        [Column("CA57_V_VSW")]
        public int? CA57_V_VSW { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren VRI".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Rinder, in %
        /// </remarks>
        [Column("CA56_V_VRI")]
        public int? CA56_V_VRI { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren UKS".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Klärschlamm, in %
        /// </remarks>
        [Column("CA55_V_UKS")]
        public int? CA55_V_UKS { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren UGR".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Grundwasser, in %
        /// </remarks>
        [Column("CA54_V_UGR")]
        public int? CA54_V_UGR { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren UNI".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Nitrat, %
        /// </remarks>
        [Column("CA53_V_UNI")]
        public int? CA53_V_UNI { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren UFFH".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - FFH, in %
        /// </remarks>
        [Column("CA52_V_UFF")]
        public int? CA52_V_UFF { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren UVO".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Vogelschutz, in %
        /// </remarks>
        [Column("CA51_V_UVO")]
        public int? CA51_V_UVO { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Mastschweine (Bestand insgesamt)".
        /// </summary>
        /// <remarks>
        /// Anzahl Mastschweine (HIT)
        /// </remarks>
        [Column("CA42_AN_MS")]
        public Int64? CA42_AN_MS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Zuchtschweine (Bestand insgesamt)".
        /// </summary>
        /// <remarks>
        /// Anzahl Zuchtschweine (z.Zt. einschl. Saugferkel) (HIT)
        /// </remarks>
        [Column("CA40_AN_ZS")]
        public Int64? CA40_AN_ZS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Schweine (Bestand insgesamt)".
        /// </summary>
        /// <remarks>
        /// Anzahl Schweine (HIT)
        /// </remarks>
        [Column("CA38_AN_SW")]
        public Int64? CA38_AN_SW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Milchviehhaltung vorhanden".
        /// </summary>
        /// <remarks>
        /// Milchviehhaltung vorhanden (HIT)
        /// </remarks>
        [Column("CA34_M_VOR")]
        public bool? CA34_M_VOR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Rinder bis 6 Monate".
        /// </summary>
        /// <remarks>
        /// Anzahl Rinder bis 6 Monate (HIT)
        /// </remarks>
        [Column("CA31_AN_R6")]
        public Int64? CA31_AN_R6 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Rinder (Bestand gesamt)".
        /// </summary>
        /// <remarks>
        /// Anzahl Rinder (HIT)
        /// </remarks>
        [Column("CA29_AN_RI")]
        public Int64? CA29_AN_RI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung VPS".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Pflanzenschutz, Punkte
        /// </remarks>
        [Column("CA76_FBVPS")]
        public int? CA76_FBVPS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung VSZ".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Schafe/Ziegen, Punkte
        /// </remarks>
        [Column("CA75_FBVSZ")]
        public int? CA75_FBVSZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung VSW".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Schweine, Punkte
        /// </remarks>
        [Column("CA74_FBVSW")]
        public int? CA74_FBVSW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung VRI".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Rinder, Punkte
        /// </remarks>
        [Column("CA73_FBVRI")]
        public int? CA73_FBVRI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung UKS".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Klärschlamm, Punkte
        /// </remarks>
        [Column("CA72_FBUKS")]
        public int? CA72_FBUKS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung UGR".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Grundwasser, Punkte
        /// </remarks>
        [Column("CA71_FBUGR")]
        public int? CA71_FBUGR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung UNI".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Nitrat, Punkte
        /// </remarks>
        [Column("CA70_FBUNI")]
        public int? CA70_FBUNI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung UFFH".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - FFH, Punkte
        /// </remarks>
        [Column("CA69_FBUFF")]
        public int? CA69_FBUFF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung UVO".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Vogelschutz, Punkte
        /// </remarks>
        [Column("CA68_FBUVO")]
        public int? CA68_FBUVO { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bestand Vorjahr".
        /// </summary>
        /// <remarks>
        /// Bestand zu Beginn des Vorjahres (31.12.RIS_JAHR - 2)
        /// </remarks>
        [Column("VG_BES_VJ")]
        public Int64? VG_BES_VJ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bestand Risikojahr".
        /// </summary>
        /// <remarks>
        /// Bestand zu Beginn des Risikojahres (31.12.RIS_JAHR - 1)
        /// </remarks>
        [Column("VG_BES_RJ")]
        public Int64? VG_BES_RJ { get; set; }

        /// <summary>
        /// Gets or sets the value of "VVVO-Meldungen storniert".
        /// </summary>
        /// <remarks>
        /// Anzahl VVVO-Meldungen storniert
        /// </remarks>
        [Column("VG_VV_ROS")]
        public Int64? VG_VV_ROS { get; set; }

        /// <summary>
        /// Gets or sets the value of "VVVO-Meldungen aktuell".
        /// </summary>
        /// <remarks>
        /// Anzahl VVVO-Meldungen aktuell
        /// </remarks>
        [Column("VG_VV_ROA")]
        public Int64? VG_VV_ROA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung WA4".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Anhang IV, Punkte
        /// </remarks>
        [Column("CA84_FBWA4")]
        public int? CA84_FBWA4 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung TLN".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Tierschutz LN, Punkte
        /// </remarks>
        [Column("CA83_FBTLN")]
        public int? CA83_FBTLN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung TSW".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Tierschutz Schweine, Punkte
        /// </remarks>
        [Column("CA82_FBTSW")]
        public int? CA82_FBTSW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung TKA".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Tierschutz Kälber, Punkte
        /// </remarks>
        [Column("CA81_FBTKA")]
        public int? CA81_FBTKA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung VLT".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - TSE, Punkte
        /// </remarks>
        [Column("CA80_FBVLT")]
        public int? CA80_FBVLT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung VLP".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Lebensmittel pflanzlicher/tierischer Herkunft, Punkte
        /// </remarks>
        [Column("CA79_FBVLP")]
        public int? CA79_FBVLP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung VFM".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Futtermittel, Punkte
        /// </remarks>
        [Column("CA78_FBVFM")]
        public int? CA78_FBVFM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung VHO".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Hormone, Punkte
        /// </remarks>
        [Column("CA77_FBVHO")]
        public int? CA77_FBVHO { get; set; }

        /// <summary>
        /// Gets the value of "Stornomitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung storniert hat
        /// </remarks>
        [Column("STRN_MBN")]
        public int? STRN_MBN { get; set; }

        /// <summary>
        /// Gets the value of "Stornobetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung storniert hat
        /// </remarks>
        [Column("STRN_BNR")]
        public decimal? STRN_BNR { get; set; }

        /// <summary>
        /// Gets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

        /// <summary>
        /// Gets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

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

        /// <summary>
        /// Gets or sets the value of "Anteil Vorgänge insgesamt".
        /// </summary>
        /// <remarks>
        /// Vorgänge insgesamt als Anteil an aktuellen Meldungen
        /// </remarks>
        [Column("VG_VRG_GEA")]
        public Int64? VG_VRG_GEA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorgänge insgesamt".
        /// </summary>
        /// <remarks>
        /// Vorgänge insgesamt
        /// </remarks>
        [Column("VG_VRG_GES")]
        public Int64? VG_VRG_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anteil Vorgänge offen".
        /// </summary>
        /// <remarks>
        /// Vorgänge offen als Anteil an aktuellen Meldungen
        /// </remarks>
        [Column("VG_VRG_OFA")]
        public Int64? VG_VRG_OFA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorgänge offen".
        /// </summary>
        /// <remarks>
        /// Vorgänge offen
        /// </remarks>
        [Column("VG_VRG_OFF")]
        public Int64? VG_VRG_OFF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Ferkel (Bestand insgesamt)".
        /// </summary>
        /// <remarks>
        /// Anzahl Ferkel (HIT)
        /// </remarks>
        [Column("CA105_ANFE")]
        public Int64? CA105_ANFE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Summe Anzahl Schafe".
        /// </summary>
        /// <remarks>
        /// Anzahl (HIT)
        /// </remarks>
        [Column("CA106_ANSC")]
        public Int64? CA106_ANSC { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Schafe <= 9 Mon.".
        /// </summary>
        /// <remarks>
        /// Anzahl (HIT)
        /// </remarks>
        [Column("CA107_ANS1")]
        public Int64? CA107_ANS1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Schafe > 9 Mon. & < 19 Mon.".
        /// </summary>
        /// <remarks>
        /// Anzahl (HIT)
        /// </remarks>
        [Column("CA108_ANS2")]
        public Int64? CA108_ANS2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Schafe >= 19 Mon.".
        /// </summary>
        /// <remarks>
        /// Anzahl (HIT)
        /// </remarks>
        [Column("CA109_ANS3")]
        public Int64? CA109_ANS3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Summe Anzahl Ziegen".
        /// </summary>
        /// <remarks>
        /// Anzahl (HIT)
        /// </remarks>
        [Column("CA110_ANZI")]
        public Int64? CA110_ANZI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Ziegen <= 9 Mon.".
        /// </summary>
        /// <remarks>
        /// Anzahl (HIT)
        /// </remarks>
        [Column("CA111_ANZ1")]
        public Int64? CA111_ANZ1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Ziegen > 9 Mon. & < 19 Mon.".
        /// </summary>
        /// <remarks>
        /// Anzahl (HIT)
        /// </remarks>
        [Column("CA112_ANZ2")]
        public Int64? CA112_ANZ2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Ziegen >= 19 Mon.".
        /// </summary>
        /// <remarks>
        /// Anzahl (HIT)
        /// </remarks>
        [Column("CA113_ANZ3")]
        public Int64? CA113_ANZ3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren ELP".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - ELER Phosphat, in %
        /// </remarks>
        [Column("CB01_V_ELP")]
        public int? CB01_V_ELP { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren VTS".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Tierseuchen, in %
        /// </remarks>
        [Column("CB03_V_VTS")]
        public int? CB03_V_VTS { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren WDG".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Dauergrünland, in %
        /// </remarks>
        [Column("CB04_V_WDG")]
        public int? CB04_V_WDG { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren XUF".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Umwelt - FFH, in %
        /// </remarks>
        [Column("CB05_V_XUF")]
        public int? CB05_V_XUF { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren XUG".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Umwelt - Grundwasser, in %
        /// </remarks>
        [Column("CB06_V_XUG")]
        public int? CB06_V_XUG { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren XUV".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Umwelt - Vogelschutz, in %
        /// </remarks>
        [Column("CB07_V_XUV")]
        public int? CB07_V_XUV { get; set; }

        /// <summary>
        /// Gets or sets the value of "max.Verstoß aus Vorjahren XVP".
        /// </summary>
        /// <remarks>
        /// max.Verstoß der letzten 2 Jahre - Gesundheit - Pflanzenschutz, in %
        /// </remarks>
        [Column("CB08_V_XVP")]
        public int? CB08_V_XVP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung ELP".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - ELER Phosphat, Punkte
        /// </remarks>
        [Column("CB09_FBELP")]
        public int? CB09_FBELP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung VTS".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Tierseuchen, Punkte
        /// </remarks>
        [Column("CB11_FBVTS")]
        public int? CB11_FBVTS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung WDG".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Dauergrünland, Punkte
        /// </remarks>
        [Column("CB12_FBWDG")]
        public int? CB12_FBWDG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung XUF".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Umwelt - FFH, Punkte
        /// </remarks>
        [Column("CB13_FBXUF")]
        public int? CB13_FBXUF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung XUG".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Umwelt - Grundwasser, Punkte
        /// </remarks>
        [Column("CB14_FBXUG")]
        public int? CB14_FBXUG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung XUV".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Umwelt - Vogelschutz, Punkte
        /// </remarks>
        [Column("CB15_FBXUV")]
        public int? CB15_FBXUV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachbehördenbewertung XVP".
        /// </summary>
        /// <remarks>
        /// Fachbehördenbewertung - Gesundheit - Pflanzenschutz, Punkte
        /// </remarks>
        [Column("CB16_FBXVP")]
        public int? CB16_FBXVP { get; set; }

    }
}
