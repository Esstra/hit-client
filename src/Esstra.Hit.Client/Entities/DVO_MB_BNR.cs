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
    /// DVO-Meldebehörde-Betrieb
    /// </summary>
    [Entity("DVO_MB_BNR")]
    public class DVO_MB_BNR
    {
        /// <summary>
        /// Gets or sets the value of "Betriebsnummer DVO-Melder".
        /// </summary>
        [Column("BNR15_DVO")]
        [Required]
        public decimal? BNR15_DVO { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginn der DVO-Meldeverpflichtung".
        /// </summary>
        [Column("DVO_BEGINN")]
        [Required]
        public DateTime? DVO_BEGINN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ende der DVO-Meldeverpflichtung".
        /// </summary>
        [Column("DVO_ENDE")]
        [Required]
        public DateTime? DVO_ENDE { get; set; }

        /// <summary>
        /// Gets or sets the value of "DVO-Meldeverpflichtung Rinder".
        /// </summary>
        [Column("DVO_RI")]
        [Required]
        public bool? DVO_RI { get; set; }

        /// <summary>
        /// Gets or sets the value of "DVO-Meldeansprechperson Rinder".
        /// </summary>
        [Column("DVO_RI_KON")]
        [Required]
        public string? DVO_RI_KON { get; set; }

        /// <summary>
        /// Gets or sets the value of "DVO-Meldeverpflichtung Schafe".
        /// </summary>
        [Column("DVO_SA")]
        [Required]
        public bool? DVO_SA { get; set; }

        /// <summary>
        /// Gets or sets the value of "DVO-Meldeansprechperson Schafe".
        /// </summary>
        [Column("DVO_SA_KON")]
        [Required]
        public string? DVO_SA_KON { get; set; }

        /// <summary>
        /// Gets or sets the value of "DVO-Meldeverpflichtung Schweine".
        /// </summary>
        [Column("DVO_SW")]
        [Required]
        public bool? DVO_SW { get; set; }

        /// <summary>
        /// Gets or sets the value of "DVO-Meldeansprechperson Schweine".
        /// </summary>
        [Column("DVO_SW_KON")]
        [Required]
        public string? DVO_SW_KON { get; set; }

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
        /// Gets or sets the value of "Betriebsnummer DVO-Verwaltung".
        /// </summary>
        [Column("BNR15_DVOV")]
        [Required]
        public decimal? BNR15_DVOV { get; set; }

    }
}