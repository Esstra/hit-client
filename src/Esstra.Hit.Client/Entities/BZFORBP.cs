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
    /// Betriebszuordnungen zum Child einer Zuordnung mit gegebenem Parent
    /// </summary>
    [Entity("BZFORBP")]
    public class BZFORBP
    {
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
        /// Gets or sets the value of "Parent-Betrieb".
        /// </summary>
        /// <remarks>
        /// Root-Betrieb bei Zuordnung
        /// </remarks>
        [Column("BNR15_P")]
        [Required]
        public decimal? BNR15_P { get; set; }

        /// <summary>
        /// Gets or sets the value of "Parent-Betrieb (View Teil A)".
        /// </summary>
        /// <remarks>
        /// Root-Betrieb bei Zuordnung
        /// </remarks>
        [Column("BNR15_P_A")]
        [Required]
        public decimal? BNR15_P_A { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zuordnung gültig bis".
        /// </summary>
        /// <remarks>
        /// fachlich gültig bis oder aktuell (31.12.2100)
        /// </remarks>
        [Column("DZUO_BIS")]
        public DateTime? DZUO_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zuordnung gültig bis (View Teil A)".
        /// </summary>
        /// <remarks>
        /// fachlich gültig bis oder aktuell (31.12.2100)
        /// </remarks>
        [Column("DZUO_BIS_A")]
        [Required]
        public DateTime? DZUO_BIS_A { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zuordnung gültig von".
        /// </summary>
        /// <remarks>
        /// Timestamp ab wann der Satz fachlich gilt
        /// </remarks>
        [Column("DZUO_VON")]
        public DateTime? DZUO_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zuordnung gültig von (View Teil A)".
        /// </summary>
        /// <remarks>
        /// Timestamp ab wann der Satz fachlich gilt
        /// </remarks>
        [Column("DZUO_VON_A")]
        [Required]
        public DateTime? DZUO_VON_A { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        [Required]
        public int? MELD_MBN { get; set; }

        /// <summary>
        /// Gets or sets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "storniert (Teil A)".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information im Teil A technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS_A")]
        [Required]
        public DateTime? SYS_BIS_A { get; set; }

        /// <summary>
        /// Gets or sets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        [Required]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "gespeichert (Teil A)".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information im Teil A technisch gültig ist
        /// </remarks>
        [Column("SYS_VON_A")]
        [Required]
        public DateTime? SYS_VON_A { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zuordnungstyp".
        /// </summary>
        /// <remarks>
        /// Typ der Betriebszuordnung
        /// </remarks>
        [Column("TYP_ZUO")]
        [Required]
        public int? TYP_ZUO { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zuordnungstyp (View Teil A)".
        /// </summary>
        /// <remarks>
        /// Typ der Betriebszuordnung
        /// </remarks>
        [Column("TYP_ZUO_A")]
        [Required]
        public int? TYP_ZUO_A { get; set; }

    }
}
