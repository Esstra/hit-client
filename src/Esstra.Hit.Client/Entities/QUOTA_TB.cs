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
    /// Quota für TYP_BETR
    /// </summary>
    [Entity("QUOTA_TB")]
    public class QUOTA_TB
    {
        /// <summary>
        /// Gets or sets the value of "Aktion im HIT-Protokoll".
        /// </summary>
        /// <remarks>
        /// Aktion numerisch/char I,X,S...
        /// </remarks>
        [Column("AKTIONHP")]
        [Required]
        public int? AKTIONHP { get; set; }

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
        /// Gets or sets the value of "Quota Anzahl Aktionen".
        /// </summary>
        [Column("QU_ANZ_AKT")]
        [Required]
        public Int64? QU_ANZ_AKT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Quota Anzahl Rows per Aktionen".
        /// </summary>
        [Column("QU_ANZ_PER")]
        [Required]
        public Int64? QU_ANZ_PER { get; set; }

        /// <summary>
        /// Gets or sets the value of "Quota-Intervall".
        /// </summary>
        [Column("QU_INTER")]
        [Required]
        public int? QU_INTER { get; set; }

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
        /// Gets or sets the value of "Betriebstyp".
        /// </summary>
        /// <remarks>
        /// Betriebstyp, Rolle für HIT, als Grundlage der Rechte und Pflichten
        /// </remarks>
        [Column("TYP_BETR")]
        [Required]
        public int? TYP_BETR { get; set; }

    }
}