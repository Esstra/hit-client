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
    /// Zahlungsansprüche V2, Zukaufsmeldung von Übernehmer
    /// </summary>
    [Entity("ZB_ZUKAUF")]
    public class ZB_ZUKAUF
    {
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

        /// <summary>
        /// Gets or sets the value of "ZA-Verkäufer-Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Person bzw. InVeKoS / Unternehmen
        /// </remarks>
        [Column("ZB_VK_BNR")]
        [Required]
        public decimal? ZB_VK_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vertrags-Transaktionsnummer für ZA-Verkaufsvorgang".
        /// </summary>
        /// <remarks>
        /// vom System generierter Schlüssel, eindeutig innerhalb Verkäufer und Transaktion
        /// </remarks>
        [Column("ZB_VK_TAN")]
        [Required]
        public Int64? ZB_VK_TAN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamtumfang der Transaktion".
        /// </summary>
        /// <remarks>
        /// als ganze ZA mit 2 Nachkommastellen (nicht Ar-Basis)
        /// </remarks>
        [Column("ZB_VK_UMFG")]
        [Required]
        public decimal? ZB_VK_UMFG { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Zukäufer-Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Person bzw. InVeKoS / Unternehmen
        /// </remarks>
        [Column("ZB_ZK_BNR")]
        [Required]
        public decimal? ZB_ZK_BNR { get; set; }

    }
}
