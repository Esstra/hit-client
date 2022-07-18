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
    [Entity("ZA_AKT_BE")]
    public class ZA_AKT_BE
    {
        /// <summary>
        /// Gets or sets the value of "ZA-Änderungsaktion, laufende Nummer".
        /// </summary>
        [Column("ZA_AKT_LFN")]
        [Required]
        public int? ZA_AKT_LFN { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Änderungsaktion (mit Level)".
        /// </summary>
        [Column("ZA_AKT_LEV")]
        [Required]
        public int? ZA_AKT_LEV { get; set; }

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
        /// Gets the value of "Umfang Stornos durch System bei einer Auftragsaktion".
        /// </summary>
        /// <remarks>
        /// zur Ermittlung des Stornoumfangs
        /// </remarks>
        [Column("ZA_SYS_STO")]
        public Int64? ZA_SYS_STO { get; set; }

        /// <summary>
        /// Gets the value of "Umfang Inserts durch System bei einer Auftragsaktion".
        /// </summary>
        /// <remarks>
        /// zur Ermittlung des Änderungsumfangs
        /// </remarks>
        [Column("ZA_SYS_INS")]
        public Int64? ZA_SYS_INS { get; set; }

        /// <summary>
        /// Gets the value of "Vom System generierte Pseudo-Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// zur Kennzeichnung der Änderung in MELD_BNR bzw. STRN_BNR
        /// </remarks>
        [Column("ZA_SYS_BNR")]
        public decimal? ZA_SYS_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginnzeitpunkt der Änderung der Zahlungsansprüche".
        /// </summary>
        [Column("ZA_ERH_VON")]
        public DateTime? ZA_ERH_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamtbetrag des BIB aus der NR für diese Änderungsaktion".
        /// </summary>
        /// <remarks>
        /// z.B. innerhalb Tabak + Milcherhöhung führt zu Änderung des NR-Betrags und Anteils
        /// </remarks>
        [Column("ZA_ERH_NR")]
        public decimal? ZA_ERH_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamtbetrag des BIB für diese Änderungsaktion".
        /// </summary>
        /// <remarks>
        /// z.B. Tabak + Milcherhöhung führt zu Zeitwerterhöhung
        /// </remarks>
        [Column("ZA_ERH_BIB")]
        public decimal? ZA_ERH_BIB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer des Eigentümers oder Pächters".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Person bzw. InVeKoS / Unternehmen
        /// </remarks>
        [Column("ZA_EB_BNR")]
        [Required]
        public decimal? ZA_EB_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Änderungsaktion soll von der ZID automation durchgeführt werden".
        /// </summary>
        /// <remarks>
        /// notwendige Datenänderungen in Grund, Zeitattr. Usw führt ZID automatisch durch oder das Land selbst
        /// </remarks>
        [Column("ZA_AUTOMAT")]
        [Required]
        public bool? ZA_AUTOMAT { get; set; }

    }
}