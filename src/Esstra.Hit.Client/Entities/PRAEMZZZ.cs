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
    /// Prämien Ergebnisse
    /// </summary>
    [Entity("PRAEMZZZ")]
    public class PRAEMZZZ
    {
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
        /// Gets or sets the value of "PlausiNr".
        /// </summary>
        /// <remarks>
        /// (seit 06.2004 5 statt 4stellig)
        /// </remarks>
        [Column("PLAUSINR")]
        [Required]
        public int? PLAUSINR { get; set; }

        /// <summary>
        /// Gets or sets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        [Required]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schwere".
        /// </summary>
        [Column("SCHWERE")]
        [Required]
        public int? SCHWERE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Prämienergebnis Wert 3".
        /// </summary>
        /// <remarks>
        /// Ergebnisangabe 3
        /// </remarks>
        [Column("PR_ERG_W3")]
        public string? PR_ERG_W3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Maximal Bearbeitungsstand".
        /// </summary>
        /// <remarks>
        /// Maximaler lokalen Bearbeitungsstand des Prämienantrags
        /// </remarks>
        [Column("PR_LOK_TSM")]
        [Required]
        public DateTime? PR_LOK_TSM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Prämienergebnis Wert 2".
        /// </summary>
        /// <remarks>
        /// Ergebnisangabe 2
        /// </remarks>
        [Column("PR_ERG_W2")]
        public string? PR_ERG_W2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Prämienergebnis Wert 1".
        /// </summary>
        /// <remarks>
        /// Ergebnisangabe 1
        /// </remarks>
        [Column("PR_ERG_W1")]
        public string? PR_ERG_W1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "VorgNr".
        /// </summary>
        /// <remarks>
        /// Vorgangsnummer des VVVO-Vorgangs
        /// </remarks>
        [Column("VORGNR")]
        [Required]
        public Int64? VORGNR { get; set; }

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
        /// Gets or sets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        [Required]
        public DateTime? SYS_VON { get; set; }

    }
}
