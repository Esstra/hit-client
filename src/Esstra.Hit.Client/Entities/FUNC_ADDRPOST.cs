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
    /// Postanschrift zum Betrieb
    /// </summary>
    [Entity("FUNC_ADDRPOST")]
    public class FUNC_ADDRPOST
    {
        /// <summary>
        /// Gets or sets the value of "Name 2.Zeile".
        /// </summary>
        /// <remarks>
        /// 2.Namenszeile für Adressfenster
        /// </remarks>
        [Column("NAME2")]
        public string? NAME2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "PLZ".
        /// </summary>
        /// <remarks>
        /// Postleitzahl, ggf. internat. ohne Staat
        /// </remarks>
        [Column("PLZ")]
        public string? PLZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ortsteil".
        /// </summary>
        /// <remarks>
        /// Ortsteil wenn erforderlich
        /// </remarks>
        [Column("ORTSTEIL")]
        public string? ORTSTEIL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Registriernummer für Betrieb, Langform mit B.Land und Staat
        /// </remarks>
        [Column("BNR15")]
        public decimal? BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name in Kurzform".
        /// </summary>
        /// <remarks>
        /// Name in Kurzform für Adressfenster
        /// </remarks>
        [Column("NAME")]
        public string? NAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Strasse Nr".
        /// </summary>
        /// <remarks>
        /// Straße und Hausnummer
        /// </remarks>
        [Column("STR_NR")]
        public string? STR_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ort".
        /// </summary>
        /// <remarks>
        /// Ort
        /// </remarks>
        [Column("ORT")]
        public string? ORT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anrede".
        /// </summary>
        /// <remarks>
        /// Anrede, ggf. mit Titel
        /// </remarks>
        [Column("ANREDE")]
        public string? ANREDE { get; set; }

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
        /// Gets or sets the value of "ISO-Staat (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// ISO-Länderschlüssel (als Alpha-Code in Funktionen)
        /// </remarks>
        [Column("ILANDX")]
        public string? ILANDX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nachname".
        /// </summary>
        /// <remarks>
        /// Nachname, inkl. Doppelnamen
        /// </remarks>
        [Column("NACHNAME")]
        public string? NACHNAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name, gesamt aus Vorname, Nachname oder Firma (je nach Rechtsform und Vorliegen)".
        /// </summary>
        [Column("NAME_GES")]
        public string? NAME_GES { get; set; }

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
        /// Gets or sets the value of "Rechtsform".
        /// </summary>
        /// <remarks>
        /// Rechtsform des Betriebs
        /// </remarks>
        [Column("RE_FRM")]
        public int? RE_FRM { get; set; }

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
        /// Gets or sets the value of "Adresse, gesamt aus STR_NR, PLZ, ORT, ORTSTEIL (je nach Rechtsform und Vorliegen)".
        /// </summary>
        [Column("ADDR_GES")]
        public string? ADDR_GES { get; set; }

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
        /// Gets or sets the value of "Kontakt, gesamt aus Telefon, Fax, Mail, Mobil (je nach Rechtsform und Vorliegen)".
        /// </summary>
        [Column("KONTAKT")]
        public string? KONTAKT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Mobiltelefon".
        /// </summary>
        /// <remarks>
        /// Rufnummer mit Vorwahl
        /// </remarks>
        [Column("MOBILFON")]
        public string? MOBILFON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name + ggf. Name2".
        /// </summary>
        [Column("NAME12")]
        public string? NAME12 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Telefon".
        /// </summary>
        /// <remarks>
        /// Telefon-Anschluß
        /// </remarks>
        [Column("TELEFON")]
        public string? TELEFON { get; set; }

    }
}
