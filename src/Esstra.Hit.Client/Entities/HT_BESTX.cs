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
    /// Bestellung Heimtierpässe (Sicht mit Betriebsdaten)
    /// </summary>
    [Entity("HT_BESTX")]
    public class HT_BESTX
    {
        /// <summary>
        /// Gets or sets the value of "Betriebsnummer ermächtigter Tierarzt, für Ausgaben von Heimtierpässen".
        /// </summary>
        [Column("BNR15_HTA")]
        [Required]
        public decimal? BNR15_HTA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer Druck legende Stelle für Heimtierpässe".
        /// </summary>
        [Column("BNR15_HTD")]
        [Required]
        public decimal? BNR15_HTD { get; set; }

        /// <summary>
        /// Gets the value of "Bestellanzahl Heimtierpässe".
        /// </summary>
        [Column("HT_BESTANZ")]
        public Int64? HT_BESTANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bestelldatum Heimtierpässe".
        /// </summary>
        [Column("HT_BESTDAT")]
        [Required]
        public DateOnly? HT_BESTDAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bestellnummer Heimtierpässe".
        /// </summary>
        [Column("HT_BESTNR")]
        [Required]
        public Int64? HT_BESTNR { get; set; }

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
        /// Gets the value of "Satzstatus".
        /// </summary>
        /// <remarks>
        /// Systemstatus des Satzes
        /// </remarks>
        [Column("SYS_STAT")]
        public int? SYS_STAT { get; set; }

        /// <summary>
        /// Gets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Globally Unique Identifier".
        /// </summary>
        /// <remarks>
        /// Format xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx (lower case)
        /// </remarks>
        [Column("GUID")]
        public string? GUID { get; set; }

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
        /// Gets or sets the value of "Geschlecht Person".
        /// </summary>
        /// <remarks>
        /// Geschlecht Person
        /// </remarks>
        [Column("GESCHL_P")]
        public int? GESCHL_P { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontaktdaten".
        /// </summary>
        [Column("HT_KONTAKT")]
        [Required]
        public string? HT_KONTAKT { get; set; }

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
        /// Gets or sets the value of "gespeichert (Teil A)".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information im Teil A technisch gültig ist
        /// </remarks>
        [Column("SYS_VON_A")]
        public DateTime? SYS_VON_A { get; set; }

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

    }
}
