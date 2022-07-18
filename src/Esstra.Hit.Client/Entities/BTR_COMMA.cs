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
    /// Bestätigter Kommunikationskanal (Abfrage, ohne interne Werte)
    /// </summary>
    [Entity("BTR_COMMA")]
    public class BTR_COMMA
    {
        /// <summary>
        /// Gets or sets the value of "Option 10".
        /// </summary>
        [Column("COMM_X10")]
        public bool? COMM_X10 { get; set; }

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
        /// Gets the value of "Zeitpunkt der Anforderung".
        /// </summary>
        [Column("COMM_ANFTS")]
        public DateTime? COMM_ANFTS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art des Kommunikationskanals".
        /// </summary>
        /// <remarks>
        /// Mobil, Mail usw.
        /// </remarks>
        [Column("COMM_ART")]
        [Required]
        public int? COMM_ART { get; set; }

        /// <summary>
        /// Gets the value of "Status der Anforderung".
        /// </summary>
        [Column("COMM_ASTA")]
        public int? COMM_ASTA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zeitpunkt der Bestätigung".
        /// </summary>
        [Column("COMM_BESTS")]
        public DateTime? COMM_BESTS { get; set; }

        /// <summary>
        /// Gets the value of "Zeitpunkt des Endes der Gültigkeit".
        /// </summary>
        [Column("COMM_ENDTS")]
        public DateTime? COMM_ENDTS { get; set; }

        /// <summary>
        /// Gets the value of "Anzahl fehlerhafter Bestätigungen".
        /// </summary>
        [Column("COMM_FANZ")]
        public int? COMM_FANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kommunikationsadresse".
        /// </summary>
        /// <remarks>
        /// wie Mailadresse oder Mobilnummer
        /// </remarks>
        [Column("COMM_URL")]
        [Required]
        public string? COMM_URL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 0, Standard für alle Optionen ohne spezifische Angabe".
        /// </summary>
        [Column("COMM_X00")]
        public bool? COMM_X00 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 1, Anforderung einer neuen PIN über diesen Weg zulässig".
        /// </summary>
        [Column("COMM_X01")]
        public bool? COMM_X01 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 2, VVVO-Vorgang".
        /// </summary>
        [Column("COMM_X02")]
        public bool? COMM_X02 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 3, TAM-Erinnerung".
        /// </summary>
        [Column("COMM_X03")]
        public bool? COMM_X03 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 4, HTML-Format".
        /// </summary>
        [Column("COMM_X04")]
        public bool? COMM_X04 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 5, Freigabe für Landesuntersuchungslabore".
        /// </summary>
        [Column("COMM_X05")]
        public bool? COMM_X05 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 6, Freigabe für Veterinärämter".
        /// </summary>
        [Column("COMM_X06")]
        public bool? COMM_X06 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 7, Erinnerung Stichtagsmeldung Schweine und Schafe/Ziegen zum 1. Januar".
        /// </summary>
        [Column("COMM_X07")]
        public bool? COMM_X07 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 8, Explizite Anforderung und Einwilligung HIT-Protokoll unverschlüsselt zu nutzen".
        /// </summary>
        /// <remarks>
        /// hier greift Default-Option 0 nicht!
        /// </remarks>
        [Column("COMM_X08")]
        public bool? COMM_X08 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 9, Obwohl HIT-Protokoll unverschlüsselt, explizit keine Benachrichtigungsmail bei Anmeldung".
        /// </summary>
        /// <remarks>
        /// hier greift Default-Option 0 nicht!
        /// </remarks>
        [Column("COMM_X09")]
        public bool? COMM_X09 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 11".
        /// </summary>
        [Column("COMM_X11")]
        public bool? COMM_X11 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 12".
        /// </summary>
        [Column("COMM_X12")]
        public bool? COMM_X12 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 13".
        /// </summary>
        [Column("COMM_X13")]
        public bool? COMM_X13 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 14".
        /// </summary>
        [Column("COMM_X14")]
        public bool? COMM_X14 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 15".
        /// </summary>
        [Column("COMM_X15")]
        public bool? COMM_X15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 16".
        /// </summary>
        [Column("COMM_X16")]
        public bool? COMM_X16 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 17".
        /// </summary>
        [Column("COMM_X17")]
        public bool? COMM_X17 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 18".
        /// </summary>
        [Column("COMM_X18")]
        public bool? COMM_X18 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 19".
        /// </summary>
        [Column("COMM_X19")]
        public bool? COMM_X19 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Option 20".
        /// </summary>
        [Column("COMM_X20")]
        public bool? COMM_X20 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Globally Unique Identifier".
        /// </summary>
        /// <remarks>
        /// Format xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx (lower case)
        /// </remarks>
        [Column("GUID")]
        public string? GUID { get; set; }

        /// <summary>
        /// Gets or sets the value of "Mitbenutzernummer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer innerhalb einer Betriebsnummer
        /// </remarks>
        [Column("MBN")]
        [Required]
        public int? MBN { get; set; }

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
        /// Gets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

    }
}