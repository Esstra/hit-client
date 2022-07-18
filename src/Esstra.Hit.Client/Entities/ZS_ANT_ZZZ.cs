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
    /// Antragsabgleich Ergebnisse
    /// </summary>
    [Entity("ZS_ANT_ZZZ")]
    public class ZS_ANT_ZZZ
    {
        /// <summary>
        /// Gets or sets the value of "Antragsmaßnahme für Antragstellerabgleich".
        /// </summary>
        [Column("ANTR_MAS")]
        [Required]
        public int? ANTR_MAS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorgang Wert 5".
        /// </summary>
        /// <remarks>
        /// Ergebnisangabe 5
        /// </remarks>
        [Column("ZID_VORG_5")]
        public string? ZID_VORG_5 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorgang Wert 2".
        /// </summary>
        /// <remarks>
        /// Ergebnisangabe 2
        /// </remarks>
        [Column("ZID_VORG_2")]
        public string? ZID_VORG_2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorgang Wert 4".
        /// </summary>
        /// <remarks>
        /// Ergebnisangabe 4
        /// </remarks>
        [Column("ZID_VORG_4")]
        public string? ZID_VORG_4 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorgang Wert 3".
        /// </summary>
        /// <remarks>
        /// Ergebnisangabe 3
        /// </remarks>
        [Column("ZID_VORG_3")]
        public string? ZID_VORG_3 { get; set; }

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
        /// Gets or sets the value of "PlausiNr".
        /// </summary>
        /// <remarks>
        /// (seit 06.2004 5 statt 4stellig)
        /// </remarks>
        [Column("PLAUSINR")]
        [Required]
        public int? PLAUSINR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schwere".
        /// </summary>
        [Column("SCHWERE")]
        [Required]
        public int? SCHWERE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Prämienantragnummer".
        /// </summary>
        /// <remarks>
        /// Nummer des Antrag, mit 01..16 für Land am Anfang
        /// </remarks>
        [Column("PR_ANTR_NR")]
        [Required]
        public string? PR_ANTR_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorgang Wert 6".
        /// </summary>
        /// <remarks>
        /// Ergebnisangabe 6
        /// </remarks>
        [Column("ZID_VORG_6")]
        public string? ZID_VORG_6 { get; set; }

        /// <summary>
        /// Gets or sets the value of "VorgLfn".
        /// </summary>
        /// <remarks>
        /// innerhalb Vorgangsnr bzw. Betrieb, Tier oder Antrag
        /// </remarks>
        [Column("VORGLFN")]
        [Required]
        public int? VORGLFN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Jahr".
        /// </summary>
        /// <remarks>
        /// Jahresangabe, vierstellig
        /// </remarks>
        [Column("JAHR")]
        [Required]
        public int? JAHR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorgang Wert 1".
        /// </summary>
        /// <remarks>
        /// Ergebnisangabe 1
        /// </remarks>
        [Column("ZID_VORG_1")]
        public string? ZID_VORG_1 { get; set; }

    }
}
