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
    /// Zirkusregister Betriebsstammdaten (BTR_D mit Typ 700 ff)
    /// </summary>
    [Entity("ZR_BTR_D_A")]
    public class ZR_BTR_D_A
    {
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
        /// Gets or sets the value of "PLZ".
        /// </summary>
        /// <remarks>
        /// Postleitzahl, ggf. internat. ohne Staat
        /// </remarks>
        [Column("PLZ")]
        [Required]
        public string? PLZ { get; set; }

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
        /// Gets or sets the value of "Rechtsform".
        /// </summary>
        /// <remarks>
        /// Rechtsform des Betriebs
        /// </remarks>
        [Column("RE_FRM")]
        public int? RE_FRM { get; set; }

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
        /// Gets or sets the value of "Betrieb gültig von".
        /// </summary>
        /// <remarks>
        /// Timestamp ab wann der Satz fachlich gilt
        /// </remarks>
        [Column("DBET_VON")]
        [Required]
        public DateTime? DBET_VON { get; set; }

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
        /// Gets or sets the value of "InVeKos Nummer".
        /// </summary>
        /// <remarks>
        /// Landesinterne InVeKos-Registriernummer
        /// </remarks>
        [Column("IVK_NR")]
        public string? IVK_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Register-Nummer".
        /// </summary>
        /// <remarks>
        /// Handelsregister, Vereinsregister, etc.
        /// </remarks>
        [Column("REG_NR")]
        public string? REG_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "ILN".
        /// </summary>
        /// <remarks>
        /// International Location Number
        /// </remarks>
        [Column("ILN")]
        public decimal? ILN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Intern-Schlüssel".
        /// </summary>
        /// <remarks>
        /// zur Verfügung der Länder
        /// </remarks>
        [Column("INTERN")]
        public decimal? INTERN { get; set; }

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
        /// Gets or sets the value of "Ortsteil".
        /// </summary>
        /// <remarks>
        /// Ortsteil wenn erforderlich
        /// </remarks>
        [Column("ORTSTEIL")]
        public string? ORTSTEIL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geschlecht Person".
        /// </summary>
        /// <remarks>
        /// Geschlecht Person
        /// </remarks>
        [Column("GESCHL_P")]
        public int? GESCHL_P { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anrede".
        /// </summary>
        /// <remarks>
        /// Anrede, ggf. mit Titel
        /// </remarks>
        [Column("ANREDE")]
        public string? ANREDE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorname".
        /// </summary>
        /// <remarks>
        /// ein oder mehrere Vornamen
        /// </remarks>
        [Column("VORNAME")]
        public string? VORNAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nachname".
        /// </summary>
        /// <remarks>
        /// Nachname, inkl. Doppelnamen
        /// </remarks>
        [Column("NACHNAME")]
        public string? NACHNAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Firma/Organisation".
        /// </summary>
        /// <remarks>
        /// Firma bzw. Organisation
        /// </remarks>
        [Column("FIRMA")]
        public string? FIRMA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Postfach-PLZ".
        /// </summary>
        /// <remarks>
        /// Postfach-PLZ, ggf. internat. ohne Staat
        /// </remarks>
        [Column("PF_PLZ")]
        public string? PF_PLZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Postfach-Nr".
        /// </summary>
        /// <remarks>
        /// Nummer des Postfachs
        /// </remarks>
        [Column("PF_NR")]
        public string? PF_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Telefon".
        /// </summary>
        /// <remarks>
        /// Telefon-Anschluß
        /// </remarks>
        [Column("TELEFON")]
        public string? TELEFON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fax".
        /// </summary>
        /// <remarks>
        /// Fax-Anschluß
        /// </remarks>
        [Column("FAX")]
        public string? FAX { get; set; }

        /// <summary>
        /// Gets or sets the value of "E-Mail".
        /// </summary>
        /// <remarks>
        /// E-Mailadresse
        /// </remarks>
        [Column("EMAIL")]
        public string? EMAIL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geburtsdatum / Gründungsdatum".
        /// </summary>
        /// <remarks>
        /// Geburtsdatum natürliche Person, bzw. Gründungsdatum juristische Person
        /// </remarks>
        [Column("GEB_DATP")]
        public DateOnly? GEB_DATP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geburtsort".
        /// </summary>
        /// <remarks>
        /// Geburtsort einer Person exakt wie im Pass oder Ausweis angegeben
        /// </remarks>
        [Column("GEB_ORT")]
        public string? GEB_ORT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Person-Nummer".
        /// </summary>
        /// <remarks>
        /// zur Identifikation wenn Name und Geburtsdaten identisch, in Absprache mit Amt des Konfliktpartner
        /// </remarks>
        [Column("PERS_NR")]
        public Int64? PERS_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Unternehmen".
        /// </summary>
        /// <remarks>
        /// Unternehmen oder Betriebsstätte
        /// </remarks>
        [Column("UN_BS")]
        public int? UN_BS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Postanschrift abweichend".
        /// </summary>
        /// <remarks>
        /// Satz mit abweichender Postanschrft
        /// </remarks>
        [Column("POST_ABW")]
        public bool? POST_ABW { get; set; }

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
        /// Gets the value of "Systematischer Personenname".
        /// </summary>
        /// <remarks>
        /// vom System normierter Nachname und Vorname oder Name und Name2
        /// </remarks>
        [Column("SYS_NAME")]
        public string? SYS_NAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Grund für die fachliche Änderung bei Betriebsdaten".
        /// </summary>
        [Column("AEND_GRND")]
        [Required]
        public int? AEND_GRND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Firma/Organisation (Fortsetzung)".
        /// </summary>
        /// <remarks>
        /// Firma bzw. Organisation
        /// </remarks>
        [Column("FIRMA2")]
        [Required]
        public string? FIRMA2 { get; set; }

        /// <summary>
        /// Gets the value of "Systematischer Firmen- oder Personenname".
        /// </summary>
        /// <remarks>
        /// vom System normierte Firma oder Nachname und Vorname oder Name und Name2
        /// </remarks>
        [Column("SYS_NAME_2")]
        public string? SYS_NAME_2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "ISO-Kenner Staat".
        /// </summary>
        /// <remarks>
        /// Heimat-Staat des Betriebs mit Sitz außerhalb DE, die aber 276-BNR erhalten haben, z.B f.Transparenz
        /// </remarks>
        [Column("UR_STAAT")]
        public int? UR_STAAT { get; set; }

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
        /// Gets or sets the value of "Betrtyp gültig bis".
        /// </summary>
        /// <remarks>
        /// fachlich gültig bis oder aktuell (31.12.2100)
        /// </remarks>
        [Column("DTYP_BIS")]
        [Required]
        public DateTime? DTYP_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betrtyp gültig von".
        /// </summary>
        /// <remarks>
        /// Timestamp ab wann der Satz fachlich gilt
        /// </remarks>
        [Column("DTYP_VON")]
        [Required]
        public DateTime? DTYP_VON { get; set; }

    }
}
