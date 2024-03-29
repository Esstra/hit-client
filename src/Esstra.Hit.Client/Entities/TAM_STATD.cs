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
    /// Statistik TAM (nach § 58b AMG), Sicht für Dritten
    /// </summary>
    [Entity("TAM_STATD")]
    public class TAM_STATD
    {
        /// <summary>
        /// Gets or sets the value of "Betriebsnummer Dritter".
        /// </summary>
        /// <remarks>
        /// speziell im Bereich Tierarzneimittel (TAM)
        /// </remarks>
        [Column("BNR15_DR")]
        [Required]
        public decimal? BNR15_DR { get; set; }

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
        /// Gets or sets the value of "Nutzungsart (nach § 58a AMG)".
        /// </summary>
        [Column("TAMH_FORM")]
        [Required]
        public int? TAMH_FORM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kalenderhalbjahr".
        /// </summary>
        [Column("TAM_PERIOD")]
        [Required]
        public int? TAM_PERIOD { get; set; }

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
        /// Gets or sets the value of "Antibiotika Anwendung Tier Tage".
        /// </summary>
        /// <remarks>
        /// (Arbeitstitel)
        /// </remarks>
        [Column("TAMS_AATT")]
        public Int64? TAMS_AATT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Antibiotika Therapiehäufigkeit, Wert zum aktuellen Zeitpunkt (Angabe nicht amtlich)".
        /// </summary>
        [Column("TAMS_ABHI")]
        public decimal? TAMS_ABHI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Meldungen des Halters zur Bestandserfassung".
        /// </summary>
        [Column("TAMS_BEST")]
        [Required]
        public int? TAMS_BEST { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Meldungen des Halters zur Bestandserfassung mit Problemen".
        /// </summary>
        [Column("TAMS_BESTX")]
        [Required]
        public int? TAMS_BESTX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Meldungen des Halters zur Bestandsveränderung".
        /// </summary>
        [Column("TAMS_BVER")]
        [Required]
        public int? TAMS_BVER { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Meldungen des Halters zur Bestandsveränderung mit Problemen".
        /// </summary>
        [Column("TAMS_BVERX")]
        [Required]
        public int? TAMS_BVERX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Durchschnittsbestand".
        /// </summary>
        [Column("TAMS_DURCH")]
        public decimal? TAMS_DURCH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Meldungen des Halters zur Erklärung bezüglich Dritter".
        /// </summary>
        [Column("TAMS_ERKL")]
        [Required]
        public int? TAMS_ERKL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Meldungen des Halters zur Erklärung bezüglich Dritter mit Problemen".
        /// </summary>
        [Column("TAMS_ERKLX")]
        [Required]
        public int? TAMS_ERKLX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Liegt Nutzungsart für Periode vor (laut Angaben der Verwaltung)".
        /// </summary>
        [Column("TAMS_HALTA")]
        [Required]
        public int? TAMS_HALTA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Haltung Tier Tage".
        /// </summary>
        /// <remarks>
        /// (Arbeitstitel)
        /// </remarks>
        [Column("TAMS_HATT")]
        public Int64? TAMS_HATT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Meldungen des Halters zu Versicherung".
        /// </summary>
        [Column("TAMS_HAVE")]
        [Required]
        public int? TAMS_HAVE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Abgleich Antibiotika-Verwendung gegen Versicherung des Halters".
        /// </summary>
        [Column("TAMS_HAVEX")]
        [Required]
        public int? TAMS_HAVEX { get; set; }

        /// <summary>
        /// Gets or sets the value of "verantwortlich für Abgabe/Anwendungs-Meldungen".
        /// </summary>
        [Column("TAMS_WER")]
        [Required]
        public int? TAMS_WER { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Meldungen zur Arzneimittel Abgabe und Anwendung".
        /// </summary>
        [Column("TAMS_XABAW")]
        [Required]
        public int? TAMS_XABAW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Meldungen zur Arzneimittel Abgabe und Anwendung mit Problemen".
        /// </summary>
        [Column("TAMS_XABAX")]
        [Required]
        public int? TAMS_XABAX { get; set; }

        /// <summary>
        /// Gets the value of "Berechnungs-Dauer".
        /// </summary>
        /// <remarks>
        /// Rechenzeit in Sekunden
        /// </remarks>
        [Column("RECH_SEK")]
        public Int64? RECH_SEK { get; set; }

        /// <summary>
        /// Gets the value of "Berechnungs-Zeitpunkt".
        /// </summary>
        /// <remarks>
        /// Timestamp wann Ergebnis zuletzt gerechnet wurde
        /// </remarks>
        [Column("RECH_TS")]
        public DateTime? RECH_TS { get; set; }

        /// <summary>
        /// Gets the value of "Berechnungs-Umfang".
        /// </summary>
        /// <remarks>
        /// Tierumsätze zum Zeitpunkt der Berechnung
        /// </remarks>
        [Column("RECH_UMF")]
        public Int64? RECH_UMF { get; set; }

        /// <summary>
        /// Gets or sets the value of "TAM-Bestand, Differenz rechnerischer - gemeldeter Anfangsbestand".
        /// </summary>
        [Column("TAMB_ABDIF")]
        public Int64? TAMB_ABDIF { get; set; }

        /// <summary>
        /// Gets or sets the value of "TAM-Bestand, rechnerischer Anfangsbestand als Soldo der Vorperiode)".
        /// </summary>
        [Column("TAMB_ABREC")]
        public Int64? TAMB_ABREC { get; set; }

        /// <summary>
        /// Gets or sets the value of "TAM-Bestand Saldo".
        /// </summary>
        [Column("TAMB_SALDO")]
        public Int64? TAMB_SALDO { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anrede".
        /// </summary>
        /// <remarks>
        /// Anrede, ggf. mit Titel
        /// </remarks>
        [Column("ANREDE")]
        public string? ANREDE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betrieb gültig bis".
        /// </summary>
        /// <remarks>
        /// fachlich gültig bis oder aktuell (31.12.2100)
        /// </remarks>
        [Column("DBET_BIS")]
        [Required]
        public DateTime? DBET_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betrieb gültig von".
        /// </summary>
        /// <remarks>
        /// Timestamp ab wann der Satz fachlich gilt
        /// </remarks>
        [Column("DBET_VON")]
        [Required]
        public DateTime? DBET_VON { get; set; }

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
        /// Gets or sets the value of "Firma/Organisation".
        /// </summary>
        /// <remarks>
        /// Firma bzw. Organisation
        /// </remarks>
        [Column("FIRMA")]
        public string? FIRMA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Firma/Organisation (Fortsetzung)".
        /// </summary>
        /// <remarks>
        /// Firma bzw. Organisation
        /// </remarks>
        [Column("FIRMA2")]
        public string? FIRMA2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geburtsdatum / Gründungsdatum".
        /// </summary>
        /// <remarks>
        /// Geburtsdatum natürliche Person, bzw. Gründungsdatum juristische Person
        /// </remarks>
        [Column("GEB_DATP")]
        public DateOnly? GEB_DATP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geschlecht Person".
        /// </summary>
        /// <remarks>
        /// Geschlecht Person
        /// </remarks>
        [Column("GESCHL_P")]
        public int? GESCHL_P { get; set; }

        /// <summary>
        /// Gets or sets the value of "Land, Landkreis und Gemeinde".
        /// </summary>
        /// <remarks>
        /// Belegenheit in DE, 7-8-stellig, für regionale Auswertungen, Form  LLKKKGGG z.B.  12064340, 8111000
        /// </remarks>
        [Column("LKR_GDE")]
        public Int64? LKR_GDE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Mobiltelefon".
        /// </summary>
        /// <remarks>
        /// Rufnummer mit Vorwahl
        /// </remarks>
        [Column("MOBILFON")]
        public string? MOBILFON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nachname".
        /// </summary>
        /// <remarks>
        /// Nachname, inkl. Doppelnamen
        /// </remarks>
        [Column("NACHNAME")]
        public string? NACHNAME { get; set; }

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
        /// Gets or sets the value of "Postfach-Nr".
        /// </summary>
        /// <remarks>
        /// Nummer des Postfachs
        /// </remarks>
        [Column("PF_NR")]
        public string? PF_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Postfach-PLZ".
        /// </summary>
        /// <remarks>
        /// Postfach-PLZ, ggf. internat. ohne Staat
        /// </remarks>
        [Column("PF_PLZ")]
        public string? PF_PLZ { get; set; }

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
        /// Gets or sets the value of "Rechtsform".
        /// </summary>
        /// <remarks>
        /// Rechtsform des Betriebs
        /// </remarks>
        [Column("RE_FRM")]
        public int? RE_FRM { get; set; }

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
        /// Gets or sets the value of "storniert (Teil A)".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information im Teil A technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS_A")]
        public DateTime? SYS_BIS_A { get; set; }

        /// <summary>
        /// Gets or sets the value of "Systematischer Personenname".
        /// </summary>
        /// <remarks>
        /// vom System normierter Nachname und Vorname oder Name und Name2
        /// </remarks>
        [Column("SYS_NAME")]
        public string? SYS_NAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Systematischer Firmen- oder Personenname".
        /// </summary>
        /// <remarks>
        /// vom System normierte Firma oder Nachname und Vorname oder Name und Name2
        /// </remarks>
        [Column("SYS_NAME_2")]
        public string? SYS_NAME_2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "gespeichert (Teil A)".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information im Teil A technisch gültig ist
        /// </remarks>
        [Column("SYS_VON_A")]
        public DateTime? SYS_VON_A { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Meldungen des Halters zur Bestandserfassung mit Fristüberschreitung".
        /// </summary>
        [Column("TAMS_BESTF")]
        [Required]
        public int? TAMS_BESTF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Meldungen des Halters zur Bestandsveränderung mit Fristüberschreitung".
        /// </summary>
        [Column("TAMS_BVERF")]
        [Required]
        public int? TAMS_BVERF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art der Antibiotika-Verwendung (Abgabe/Anwendung/0-Meldungen)".
        /// </summary>
        [Column("TAMS_XABA0")]
        [Required]
        public int? TAMS_XABA0 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Meldungen zur Arzneimittel Abgabe und Anwendung mit Fristüberschreitung".
        /// </summary>
        [Column("TAMS_XABAF")]
        [Required]
        public int? TAMS_XABAF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Telefon".
        /// </summary>
        /// <remarks>
        /// Telefon-Anschluß
        /// </remarks>
        [Column("TELEFON")]
        public string? TELEFON { get; set; }

        /// <summary>
        /// Gets or sets the value of "ISO-Kenner Staat".
        /// </summary>
        /// <remarks>
        /// Heimat-Staat des Betriebs mit Sitz außerhalb DE, die aber 276-BNR erhalten haben, z.B f.Transparenz
        /// </remarks>
        [Column("UR_STAAT")]
        public int? UR_STAAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorname".
        /// </summary>
        /// <remarks>
        /// ein oder mehrere Vornamen
        /// </remarks>
        [Column("VORNAME")]
        public string? VORNAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Antibiotika Therapiehäufigkeit, Wert zum Zeitpunkt der Kennzahlenermittlung (Angabe nicht amtlich)".
        /// </summary>
        [Column("TAMS_ABHK")]
        public decimal? TAMS_ABHK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Antibiotika Therapiehäufigkeit, Gruppe bezüglich Grenzwert, aktuell (Angabe nicht amtlich)".
        /// </summary>
        [Column("TAMS_ABHG")]
        public int? TAMS_ABHG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Antibiotika Therapiehäufigkeit, Gruppe Grenzwert, historisch zur Kennzahlermittlung (nicht amtlich)".
        /// </summary>
        [Column("TAMS_ABHH")]
        public int? TAMS_ABHH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12301".
        /// </summary>
        [Column("TAMS_12301")]
        [Required]
        public bool? TAMS_12301 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12302".
        /// </summary>
        [Column("TAMS_12302")]
        [Required]
        public bool? TAMS_12302 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12303".
        /// </summary>
        [Column("TAMS_12303")]
        [Required]
        public bool? TAMS_12303 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12304".
        /// </summary>
        [Column("TAMS_12304")]
        [Required]
        public bool? TAMS_12304 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12305".
        /// </summary>
        [Column("TAMS_12305")]
        [Required]
        public bool? TAMS_12305 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12306".
        /// </summary>
        [Column("TAMS_12306")]
        [Required]
        public bool? TAMS_12306 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12307".
        /// </summary>
        [Column("TAMS_12307")]
        [Required]
        public bool? TAMS_12307 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12308".
        /// </summary>
        [Column("TAMS_12308")]
        [Required]
        public bool? TAMS_12308 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12309".
        /// </summary>
        [Column("TAMS_12309")]
        [Required]
        public bool? TAMS_12309 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12310".
        /// </summary>
        [Column("TAMS_12310")]
        [Required]
        public bool? TAMS_12310 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12311".
        /// </summary>
        [Column("TAMS_12311")]
        [Required]
        public bool? TAMS_12311 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12312".
        /// </summary>
        [Column("TAMS_12312")]
        [Required]
        public bool? TAMS_12312 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12313".
        /// </summary>
        [Column("TAMS_12313")]
        [Required]
        public bool? TAMS_12313 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12314".
        /// </summary>
        [Column("TAMS_12314")]
        [Required]
        public bool? TAMS_12314 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12315".
        /// </summary>
        [Column("TAMS_12315")]
        [Required]
        public bool? TAMS_12315 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12316".
        /// </summary>
        [Column("TAMS_12316")]
        [Required]
        public bool? TAMS_12316 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12317".
        /// </summary>
        [Column("TAMS_12317")]
        [Required]
        public bool? TAMS_12317 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12318".
        /// </summary>
        [Column("TAMS_12318")]
        [Required]
        public bool? TAMS_12318 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12319".
        /// </summary>
        [Column("TAMS_12319")]
        [Required]
        public bool? TAMS_12319 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Plausi-Hinweis 12320".
        /// </summary>
        [Column("TAMS_12320")]
        [Required]
        public bool? TAMS_12320 { get; set; }

        /// <summary>
        /// Gets or sets the value of "TAM-Profil, Therapiehäufigkeit nur online (nicht schriftlich)".
        /// </summary>
        [Column("TAMS_THONL")]
        [Required]
        public int? TAMS_THONL { get; set; }

        /// <summary>
        /// Gets or sets the value of "TAM-Profil, Anwendungs/Abgabedatum der Behörde freigeben".
        /// </summary>
        [Column("TAMS_DATFR")]
        [Required]
        public int? TAMS_DATFR { get; set; }

        /// <summary>
        /// Gets or sets the value of "TAM-Profil, auch Daten zu nicht mitteilungspflichtigen Nutzungsarten der Behörde freigeben".
        /// </summary>
        [Column("TAMS_NMPFR")]
        [Required]
        public bool? TAMS_NMPFR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Liegt Nutzungsart für Periode vor (laut eigenen Angaben)".
        /// </summary>
        [Column("TAMS_HALTE")]
        [Required]
        public int? TAMS_HALTE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nutzungsart in Periode (erweiterter Status)".
        /// </summary>
        [Column("TAMS_HALTX")]
        [Required]
        public int? TAMS_HALTX { get; set; }

    }
}
