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
    /// Stammdaten zum Hoftierarzt für Betrieb mit aktueller Vollmacht, erweitert um Status (nur aktuelle)
    /// </summary>
    [Entity("VWHTFORBEX")]
    public class VWHTFORBEX
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
        /// Gets or sets the value of "Child-Betrieb".
        /// </summary>
        /// <remarks>
        /// Abhängiger Betrieb bei Zuordnung
        /// </remarks>
        [Column("BNR15_C")]
        [Required]
        public decimal? BNR15_C { get; set; }

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
        /// Gets or sets the value of "Anrede".
        /// </summary>
        /// <remarks>
        /// Anrede, ggf. mit Titel
        /// </remarks>
        [Column("ANREDE")]
        public string? ANREDE { get; set; }

        /// <summary>
        /// Gets or sets the value of "BHV1-Betriebsstatus, Bemerkungen des Benutzers".
        /// </summary>
        /// <remarks>
        /// für Bemerkungen des Bearbeiters
        /// </remarks>
        [Column("BHV1B_BEM")]
        public string? BHV1B_BEM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe der Ohrmarkennummern der Zuchtbullen".
        /// </summary>
        /// <remarks>
        /// ggf. mehrere mit Komma getrennt, auch abgegangene
        /// </remarks>
        [Column("BHV1B_BLOM")]
        public string? BHV1B_BLOM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Startdatum für Suche Basisuntersuchung".
        /// </summary>
        [Column("BHV1B_DAT1")]
        public DateOnly? BHV1B_DAT1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Startdatum für Suche Kontrolluntersuchung".
        /// </summary>
        [Column("BHV1B_DAT2")]
        public DateOnly? BHV1B_DAT2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Startdatum für Suche Abklärungsuchungen".
        /// </summary>
        [Column("BHV1B_DAT3")]
        public DateOnly? BHV1B_DAT3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Startdatum für Prüfung der Zugänge".
        /// </summary>
        [Column("BHV1B_DAT4")]
        public DateOnly? BHV1B_DAT4 { get; set; }

        /// <summary>
        /// Gets or sets the value of "BHV1-Betriebsstatus, Prüfergebnis - Basis".
        /// </summary>
        [Column("BHV1B_ERG1")]
        public int? BHV1B_ERG1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "BHV1-Betriebsstatus, Prüfergebnis - Kontrolle".
        /// </summary>
        [Column("BHV1B_ERG2")]
        public int? BHV1B_ERG2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "BHV1-Betriebsstatus, Prüfergebnis - Abklärung".
        /// </summary>
        [Column("BHV1B_ERG3")]
        public int? BHV1B_ERG3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "BHV1-Betriebsstatus, Prüfergebnis - Zugänge".
        /// </summary>
        [Column("BHV1B_ERG4")]
        public int? BHV1B_ERG4 { get; set; }

        /// <summary>
        /// Gets or sets the value of "BHV1-Betriebsstatus, Hinweise - Basis".
        /// </summary>
        [Column("BHV1B_HIN1")]
        public string? BHV1B_HIN1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "BHV1-Betriebsstatus, Hinweise - Kontrolle".
        /// </summary>
        [Column("BHV1B_HIN2")]
        public string? BHV1B_HIN2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "BHV1-Betriebsstatus, Hinweise - Abklärung".
        /// </summary>
        [Column("BHV1B_HIN3")]
        public string? BHV1B_HIN3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "BHV1-Betriebsstatus, Hinweise - Zugänge".
        /// </summary>
        [Column("BHV1B_HIN4")]
        public string? BHV1B_HIN4 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe zum Status - Impfbestand".
        /// </summary>
        /// <remarks>
        /// Impfstatus (wichtig für Zugangsbedingungen in anderen Bestand)
        /// </remarks>
        [Column("BHV1B_IB")]
        public int? BHV1B_IB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe zum Milchviehstatus".
        /// </summary>
        /// <remarks>
        /// Milchviehhaltung mit Milchabgabe von mind. 30 Proz.der Kühe (Kriterium für Zulassung von Tankmilch)
        /// </remarks>
        [Column("BHV1B_MV")]
        public bool? BHV1B_MV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum Fälligkeit der nächsten Kontrolluntersuchung".
        /// </summary>
        [Column("BHV1B_NEXT")]
        public DateOnly? BHV1B_NEXT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Basis berücksichtigen bei BHV1-Betriebsstatus".
        /// </summary>
        [Column("BHV1B_ST1")]
        public int? BHV1B_ST1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrolle berücksichtigen bei BHV1-Betriebsstatus".
        /// </summary>
        [Column("BHV1B_ST2")]
        public int? BHV1B_ST2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Abklärung berücksichtigen bei BHV1-Betriebsstatus".
        /// </summary>
        [Column("BHV1B_ST3")]
        public int? BHV1B_ST3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zugänge berücksichtigen bei BHV1-Betriebsstatus".
        /// </summary>
        [Column("BHV1B_ST4")]
        public int? BHV1B_ST4 { get; set; }

        /// <summary>
        /// Gets or sets the value of "BHV1-Betriebsstatus".
        /// </summary>
        /// <remarks>
        /// Gesamtstatus, Ergebnis aus Veterinärstatus (hat Vorrang) und HIT-Status
        /// </remarks>
        [Column("BHV1B_STA")]
        public int? BHV1B_STA { get; set; }

        /// <summary>
        /// Gets or sets the value of "BHV1-Betriebsstatus, HIT".
        /// </summary>
        [Column("BHV1B_STAH")]
        public int? BHV1B_STAH { get; set; }

        /// <summary>
        /// Gets or sets the value of "BHV1-Betriebsstatus, Veterinärbehörde".
        /// </summary>
        [Column("BHV1B_STAV")]
        public int? BHV1B_STAV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe ab welchem Alter männliche Rinder als Zuchtbulle gelten".
        /// </summary>
        /// <remarks>
        /// Alter in Monaten
        /// </remarks>
        [Column("BHV1B_ZB")]
        public int? BHV1B_ZB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsstatus erweiterter Modus (UN/BS)".
        /// </summary>
        [Column("BHV1_XMODE")]
        public int? BHV1_XMODE { get; set; }

        /// <summary>
        /// Gets or sets the value of "BVD-Betriebsstatus, Datum alle Tiere mit N-Status".
        /// </summary>
        /// <remarks>
        /// Ende Phase 1, Beginn Phase 2 - Beobachtungszeitraum
        /// </remarks>
        [Column("BVDB_DAT_1")]
        public DateOnly? BVDB_DAT_1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "BVD-Betriebsstatus, Datum Betrieb unverdächtig".
        /// </summary>
        /// <remarks>
        /// Ende Phase 2, Beginn Phase 3 - Aufrechterhaltung
        /// </remarks>
        [Column("BVDB_DAT_2")]
        public DateOnly? BVDB_DAT_2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "BVD-Betriebsstatus, Verstoß".
        /// </summary>
        /// <remarks>
        /// Ereignisdatum eines Verstoßes gegen die Bedingungen
        /// </remarks>
        [Column("BVDB_DAT_3")]
        public DateOnly? BVDB_DAT_3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "BVD-Betriebsstatus, Hinweise".
        /// </summary>
        /// <remarks>
        /// Hinweise zum Verstoß bzw. Status
        /// </remarks>
        [Column("BVDB_HINW")]
        public string? BVDB_HINW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beobachtungszeitraum ermitteln, BVD-Betriebsstatus".
        /// </summary>
        [Column("BVDB_ST1")]
        public int? BVDB_ST1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Aufrechterhaltung ermitteln, BVD-Betriebsstatus".
        /// </summary>
        [Column("BVDB_ST2")]
        public int? BVDB_ST2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "BVD-Betriebsstatus".
        /// </summary>
        /// <remarks>
        /// Gesamtstatus, Ergebnis aus Veterinärstatus (hat Vorrang) und HIT-Status
        /// </remarks>
        [Column("BVDB_STA")]
        public int? BVDB_STA { get; set; }

        /// <summary>
        /// Gets or sets the value of "BVD-Betriebsstatus, HIT".
        /// </summary>
        [Column("BVDB_STAH")]
        public int? BVDB_STAH { get; set; }

        /// <summary>
        /// Gets or sets the value of "BVD-Betriebsstatus, Veterinärbehörde".
        /// </summary>
        [Column("BVDB_STAV")]
        public int? BVDB_STAV { get; set; }

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
        /// Gets or sets the value of "Berechnungs-Zeitpunkt BHV1-Betriebsstatus".
        /// </summary>
        /// <remarks>
        /// Timestamp wann Ergebnis zuletzt gerechnet wurde
        /// </remarks>
        [Column("RECH_BHV")]
        public DateTime? RECH_BHV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Berechnungs-Zeitpunkt BVD-Betriebsstatus".
        /// </summary>
        /// <remarks>
        /// Timestamp wann Ergebnis zuletzt gerechnet wurde
        /// </remarks>
        [Column("RECH_BVD")]
        public DateTime? RECH_BVD { get; set; }

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
        /// Gets or sets the value of "Telefon".
        /// </summary>
        /// <remarks>
        /// Telefon-Anschluß
        /// </remarks>
        [Column("TELEFON")]
        public string? TELEFON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorname".
        /// </summary>
        /// <remarks>
        /// ein oder mehrere Vornamen
        /// </remarks>
        [Column("VORNAME")]
        public string? VORNAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Startdatum für Suche Kontrolluntersuchung".
        /// </summary>
        [Column("BRUB_DAT")]
        public DateOnly? BRUB_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Brucellose-Betriebsstatus, Prüfergebnis - Kontrolle".
        /// </summary>
        [Column("BRUB_ERG")]
        public int? BRUB_ERG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Brucellose-Betriebsstatus, Hinweise - Kontrolle".
        /// </summary>
        [Column("BRUB_HIN")]
        public string? BRUB_HIN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum Fälligkeit der nächsten Kontrolluntersuchung".
        /// </summary>
        [Column("BRUB_NEXT")]
        public DateOnly? BRUB_NEXT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrolle berücksichtigen bei Brucellose-Betriebsstatus".
        /// </summary>
        [Column("BRUB_ST")]
        public int? BRUB_ST { get; set; }

        /// <summary>
        /// Gets or sets the value of "Brucellose-Betriebsstatus".
        /// </summary>
        /// <remarks>
        /// Gesamtstatus, Ergebnis aus Veterinärstatus (hat Vorrang) und HIT-Status
        /// </remarks>
        [Column("BRUB_STA")]
        public int? BRUB_STA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Brucellose-Betriebsstatus, HIT".
        /// </summary>
        [Column("BRUB_STAH")]
        public int? BRUB_STAH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Brucellose-Betriebsstatus, Veterinärbehörde".
        /// </summary>
        [Column("BRUB_STAV")]
        public int? BRUB_STAV { get; set; }

        /// <summary>
        /// Gets or sets the value of "BVD-Betriebsstatus, Prüfergebnis - Zugänge".
        /// </summary>
        [Column("BVDB_ERG4")]
        public int? BVDB_ERG4 { get; set; }

        /// <summary>
        /// Gets or sets the value of "BVD-Betriebsstatus, Hinweise - Zugänge".
        /// </summary>
        [Column("BVDB_HIN4")]
        public string? BVDB_HIN4 { get; set; }

        /// <summary>
        /// Gets or sets the value of "BVD-Betriebsstatus, HIT-Schwere".
        /// </summary>
        [Column("BVDB_STAHS")]
        public int? BVDB_STAHS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum Fälligkeit der nächsten Untersuchung".
        /// </summary>
        [Column("DATE_NEXT")]
        public DateOnly? DATE_NEXT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Startdatum für Suche Leukose-Kontrolluntersuchung".
        /// </summary>
        [Column("LEUB_DAT")]
        public DateOnly? LEUB_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Leukose-Betriebsstatus, Prüfergebnis - Kontrolle".
        /// </summary>
        [Column("LEUB_ERG")]
        public int? LEUB_ERG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Leukose-Betriebsstatus, Hinweise - Kontrolle".
        /// </summary>
        [Column("LEUB_HIN")]
        public string? LEUB_HIN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum Fälligkeit der nächsten Leukose-Kontrolluntersuchung".
        /// </summary>
        [Column("LEUB_NEXT")]
        public DateOnly? LEUB_NEXT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontrolle berücksichtigen bei Leukose-Betriebsstatus".
        /// </summary>
        [Column("LEUB_ST")]
        public int? LEUB_ST { get; set; }

        /// <summary>
        /// Gets or sets the value of "Leukose-Betriebsstatus".
        /// </summary>
        /// <remarks>
        /// Gesamtstatus, Ergebnis aus Veterinärstatus (hat Vorrang) und HIT-Status
        /// </remarks>
        [Column("LEUB_STA")]
        public int? LEUB_STA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Leukose-Betriebsstatus, HIT".
        /// </summary>
        [Column("LEUB_STAH")]
        public int? LEUB_STAH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Leukose-Betriebsstatus, Veterinärbehörde".
        /// </summary>
        [Column("LEUB_STAV")]
        public int? LEUB_STAV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Leukose / Brucellose Betriebsstatus, Bemerkungen des Benutzers".
        /// </summary>
        /// <remarks>
        /// für Bemerkungen des Bearbeiters
        /// </remarks>
        [Column("LXBB_BEM")]
        public string? LXBB_BEM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Tiere aktuell im Bestand".
        /// </summary>
        [Column("LXBB_BEST")]
        public int? LXBB_BEST { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kuh-Anteil in Prozent".
        /// </summary>
        [Column("LXBB_KUHA")]
        public decimal? LXBB_KUHA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Kühe aktuell im Bestand".
        /// </summary>
        [Column("LXBB_KUHZ")]
        public int? LXBB_KUHZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Mastbullen-Anteil in Prozent".
        /// </summary>
        [Column("LXBB_M24A")]
        public decimal? LXBB_M24A { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Mastbullen ab 24 Mo. aktuell im Bestand".
        /// </summary>
        [Column("LXBB_M24Z")]
        public int? LXBB_M24Z { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe ab welchem Alter männliche Rinder als Zuchtbulle gelten".
        /// </summary>
        /// <remarks>
        /// Alter in Monaten
        /// </remarks>
        [Column("LXBB_ZB")]
        public int? LXBB_ZB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zuchtbullen-Anteil in Prozent".
        /// </summary>
        [Column("LXBB_ZBA")]
        public decimal? LXBB_ZBA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Zuchtbullen aktuell im Bestand".
        /// </summary>
        [Column("LXBB_ZBZ")]
        public int? LXBB_ZBZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Berechnungs-Zeitpunkt Leukose/Brucellose-Betriebsstatus".
        /// </summary>
        /// <remarks>
        /// Timestamp wann Ergebnis zuletzt gerechnet wurde
        /// </remarks>
        [Column("RECH_LXD")]
        public DateTime? RECH_LXD { get; set; }

    }
}
