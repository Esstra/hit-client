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
    /// Zahlungsansprüche, Aktion für Betrieb
    /// </summary>
    [Entity("ZB_AKT_BE")]
    public class ZB_AKT_BE
    {
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

        /// <summary>
        /// Gets or sets the value of "ZA-Änderungsaktion (mit Level)".
        /// </summary>
        [Column("ZB_AKT_LEV")]
        [Required]
        public int? ZB_AKT_LEV { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Änderungsaktion, laufende Nummer".
        /// </summary>
        [Column("ZB_AKT_LFN")]
        [Required]
        public int? ZB_AKT_LFN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer des Eigentümers oder Pächters".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Person bzw. InVeKoS / Unternehmen
        /// </remarks>
        [Column("ZB_EB_BNR")]
        [Required]
        public decimal? ZB_EB_BNR { get; set; }

        /// <summary>
        /// Gets the value of "Vom System generierte Pseudo-Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// zur Kennzeichnung der Änderung in MELD_BNR bzw. STRN_BNR
        /// </remarks>
        [Column("ZB_SYS_BNR")]
        public decimal? ZB_SYS_BNR { get; set; }

        /// <summary>
        /// Gets the value of "Umfang Inserts durch System bei einer Auftragsaktion".
        /// </summary>
        /// <remarks>
        /// zur Ermittlung des Änderungsumfangs
        /// </remarks>
        [Column("ZB_SYS_INS")]
        public Int64? ZB_SYS_INS { get; set; }

        /// <summary>
        /// Gets the value of "Umfang Stornos durch System bei einer Auftragsaktion".
        /// </summary>
        /// <remarks>
        /// zur Ermittlung des Stornoumfangs
        /// </remarks>
        [Column("ZB_SYS_STO")]
        public Int64? ZB_SYS_STO { get; set; }

        /// <summary>
        /// Gets or sets the value of "Globally Unique Identifier".
        /// </summary>
        /// <remarks>
        /// Format xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx (lower case)
        /// </remarks>
        [Column("GUID")]
        public string? GUID { get; set; }

    }
}
