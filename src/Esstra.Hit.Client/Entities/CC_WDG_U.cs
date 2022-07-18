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
    /// CC-Kontrolle Bereich 4 weiteres - Dauergrünland (Sicht für UN)
    /// </summary>
    [Entity("CC_WDG_U")]
    public class CC_WDG_U
    {
        /// <summary>
        /// Gets or sets the value of "Auswahlgrund".
        /// </summary>
        /// <remarks>
        /// Grund für Auswahl zur Vor-Ort-Kontrolle
        /// </remarks>
        [Column("AUSW_GRND")]
        public int? AUSW_GRND { get; set; }

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
        /// Gets or sets the value of "CC Bemerkung im Teil F".
        /// </summary>
        /// <remarks>
        /// Ausführungen zu Bewertung, Bagatelle und Follow-Up
        /// </remarks>
        [Column("CC_BEM_F")]
        public string? CC_BEM_F { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum der Durchführung des Follow up".
        /// </summary>
        [Column("CC_FOL_DAT")]
        public DateOnly? CC_FOL_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Follow up Status".
        /// </summary>
        /// <remarks>
        /// Angabe ob Follow up erforderlich und ggf. durchgeführt
        /// </remarks>
        [Column("CC_FOL_UP")]
        [Required]
        public int? CC_FOL_UP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Welche Teile fehlen noch, bzw. wie weit fertig".
        /// </summary>
        /// <remarks>
        /// Angaben welche Teile der Eingabe noch fehlen, bzw. wie weit fertig
        /// </remarks>
        [Column("CC_MISSING")]
        [Required]
        public int? CC_MISSING { get; set; }

        /// <summary>
        /// Gets or sets the value of "Cross-Check Bemerkung im Teil B".
        /// </summary>
        /// <remarks>
        /// Ausführungen zu den Feststellungen / Hinweisen, zu festgestellten Verstößen oder Hinweise
        /// </remarks>
        [Column("CROS_BEM_B")]
        public string? CROS_BEM_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "Cross-Check Bemerkung im Teil H".
        /// </summary>
        /// <remarks>
        /// Ausführungen zu den Feststellungen / Hinweisen, als Mitteilung für andere Behörde
        /// </remarks>
        [Column("CROS_BEM_H")]
        public string? CROS_BEM_H { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum der Information der zuständigen Fachbehörde".
        /// </summary>
        /// <remarks>
        /// Mitteilung über Hinweise auf Verstoß gegen anderw. Verpflichtungen, außerhalb eigener Zuständigkeit
        /// </remarks>
        [Column("CROS_INDAT")]
        public DateOnly? CROS_INDAT { get; set; }

        /// <summary>
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

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
        /// Gets or sets the value of "Änderungsgrund".
        /// </summary>
        /// <remarks>
        /// Grund der Erfassung, Änderung oder Korrektur, insbesondere bei Kontrollberichten
        /// </remarks>
        [Column("MELD_GRND")]
        [Required]
        public int? MELD_GRND { get; set; }

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
        /// Gets or sets the value of "Jahr der Risikoanalyse (Kontrolljahr)".
        /// </summary>
        /// <remarks>
        /// Jahresangabe, vierstellig
        /// </remarks>
        [Column("RIS_JAHR")]
        [Required]
        public int? RIS_JAHR { get; set; }

        /// <summary>
        /// Gets the value of "Stornobetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung storniert hat
        /// </remarks>
        [Column("STRN_BNR")]
        public decimal? STRN_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Änderungsgrund für Storno".
        /// </summary>
        /// <remarks>
        /// Grund des Storno, insbesondere bei Kontrollberichten
        /// </remarks>
        [Column("STRN_GRND")]
        [Required]
        public int? STRN_GRND { get; set; }

        /// <summary>
        /// Gets the value of "Stornomitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung storniert hat
        /// </remarks>
        [Column("STRN_MBN")]
        public int? STRN_MBN { get; set; }

        /// <summary>
        /// Gets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamtbewertung Fahrlässigkeit der geprüften Rechtsakte".
        /// </summary>
        [Column("VERST_GES")]
        public int? VERST_GES { get; set; }

        /// <summary>
        /// Gets the value of "Prozentsatz Sanktionierung Fahrlässig + ggf. Vorsatz (ganzzahlig)".
        /// </summary>
        [Column("VERST_SUM")]
        public int? VERST_SUM { get; set; }

        /// <summary>
        /// Gets the value of "Systembewertung Fahrlässigkeit der geprüften Rechtsakte".
        /// </summary>
        [Column("VERST_SYS")]
        public int? VERST_SYS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Verstoß gegen den Standard / Rechtsakt - ja/nein".
        /// </summary>
        [Column("VERSTOSS")]
        public bool? VERSTOSS { get; set; }

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
        /// Gets or sets the value of "Datum des fachlichen Abschlusses der Prüfung".
        /// </summary>
        [Column("VOK_ENDDAT")]
        public DateOnly? VOK_ENDDAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK gestattet".
        /// </summary>
        /// <remarks>
        /// Wurde Vor-Ort-Kontrolle gestattet
        /// </remarks>
        [Column("VOK_GEST")]
        [Required]
        public int? VOK_GEST { get; set; }

        /// <summary>
        /// Gets or sets the value of "Prozentsatz Sanktionierung wenn Vorsatz vorliegt (ganzzahlig)".
        /// </summary>
        [Column("VORS_GES")]
        public int? VORS_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Wurden die erteilten Auflagen eingehalten".
        /// </summary>
        [Column("WDG_AUF_OK")]
        public bool? WDG_AUF_OK { get; set; }

        /// <summary>
        /// Gets or sets the value of "DGL-Flächen nach Inkrafttreten der Genehmigungspflicht umgebrochen".
        /// </summary>
        [Column("WDG_DGL_UM")]
        public int? WDG_DGL_UM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Prüfer-Bewertung bei Verstoß gegen 1.systemat. Kriterium im Bereich 4 Weitere - WDG".
        /// </summary>
        /// <remarks>
        /// Prüfer-Bewertung bei Erhalt von Dauergrünland (bis 2011 DGL-Flächen ohne Genehmigung umgebrochen)
        /// </remarks>
        [Column("WDG_S1_PR")]
        public int? WDG_S1_PR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Regelverstoß gegen 1.systemat. Kriterium im Bereich 4 Weitere - WDG".
        /// </summary>
        /// <remarks>
        /// Regelverstoß bei Erhalt von Dauergrünland (bis 2011 DGL-Flächen ohne Genehmigung umgebrochen)
        /// </remarks>
        [Column("WDG_S1_RE")]
        public int? WDG_S1_RE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorsatz beim Verstoß gegen 1.systemat. Kriterium im Bereich 4 Weitere - WDG".
        /// </summary>
        /// <remarks>
        /// Vorsatz bei Erhalt von Dauergrünland (bis 2011 DGL-Flächen ohne Genehmigung umgebrochen)
        /// </remarks>
        [Column("WDG_S1_VO")]
        public bool? WDG_S1_VO { get; set; }

        /// <summary>
        /// Gets or sets the value of "Prüfer-Bewertung bei Verstoß gegen 2.systemat. Kriterium im Bereich 4 Weitere - WDG".
        /// </summary>
        /// <remarks>
        /// Prüfer-Bewertung bei Auflagen nicht eingehalten
        /// </remarks>
        [Column("WDG_S2_PR")]
        public int? WDG_S2_PR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Regelverstoß gegen 2.systemat. Kriterium im Bereich 4 Weitere - WDG".
        /// </summary>
        /// <remarks>
        /// Regelverstoß bei Auflagen nicht eingehalten
        /// </remarks>
        [Column("WDG_S2_RE")]
        public int? WDG_S2_RE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorsatz beim Verstoß gegen 2.systemat. Kriterium im Bereich 4 Weitere - WDG".
        /// </summary>
        /// <remarks>
        /// Vorsatz bei Auflagen nicht eingehalten
        /// </remarks>
        [Column("WDG_S2_VO")]
        public bool? WDG_S2_VO { get; set; }

        /// <summary>
        /// Gets or sets the value of "Verstoßfeststellungen an kontrollierten Betrieb versendet/übergeben".
        /// </summary>
        [Column("FEST_VERS")]
        [Required]
        public bool? FEST_VERS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Versand/Übergabedatum der Verstoßfeststellungen an kontrollierten Betrieb".
        /// </summary>
        [Column("VERS_DAT")]
        public DateOnly? VERS_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum der Vorankündigung der Kontrolle".
        /// </summary>
        [Column("VOK_ADAT")]
        public DateOnly? VOK_ADAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "bei VOK anwesende Auskunftsperson".
        /// </summary>
        [Column("VOK_APERS")]
        public string? VOK_APERS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Informtion bei VOK mit Unterschrift belegt".
        /// </summary>
        [Column("VOK_INFO")]
        [Required]
        public bool? VOK_INFO { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Prüfer".
        /// </summary>
        /// <remarks>
        /// Prüfende Person (Mitbenutzeridentifikation)
        /// </remarks>
        [Column("VOK_PERS")]
        public string? VOK_PERS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Cross-Check Bemerkung im Teil B (Fortsetzung)".
        /// </summary>
        /// <remarks>
        /// Ausführungen zu den Feststellungen / Hinweisen, zu festgestellten Verstößen oder Hinweise
        /// </remarks>
        [Column("CROS_BEMB2")]
        public string? CROS_BEMB2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis auf Verstoß Bereich 1 Umwelt - ELER Phosphat".
        /// </summary>
        [Column("CROS_ELP")]
        [Required]
        public bool? CROS_ELP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrolle ohne Beisein des Betriebsinhabers oder eines Vertreters".
        /// </summary>
        /// <remarks>
        /// Wurde Vor-Ort-Kontrolle ohne Beisein des Betriebsinhabers oder eines Vertreters durchgeführt
        /// </remarks>
        [Column("VOK_OB")]
        [Required]
        public bool? VOK_OB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Umbruch ohne erford. Genehmigung/ Beachtung einer Anordnung zur Wiederansaat/Schaffung Ersatzfläche".
        /// </summary>
        [Column("WDG_AN_BEA")]
        public int? WDG_AN_BEA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Verpflichtung eingehalten (Abschließende Feststellung zum Erhalt von Dauergrünland)".
        /// </summary>
        [Column("WDG_BED_OK")]
        public int? WDG_BED_OK { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Datum der Hauptkontrolle".
        /// </summary>
        /// <remarks>
        /// diese Kontrolle ist zwar an anderem Datum durchgeführt, gehört aber zusammen zu einer Kontrolle vom Hauptdatum
        /// </remarks>
        [Column("VOK_DATX")]
        public DateOnly? VOK_DATX { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Datum der Retro-Feststellung".
        /// </summary>
        [Column("VOK_DATRET")]
        public DateOnly? VOK_DATRET { get; set; }

    }
}
