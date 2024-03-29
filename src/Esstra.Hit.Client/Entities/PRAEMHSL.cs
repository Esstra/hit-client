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
    /// Hausschlachtung
    /// </summary>
    [Entity("PRAEMHSL")]
    public class PRAEMHSL
    {
        /// <summary>
        /// Gets or sets the value of "Lebendgewicht".
        /// </summary>
        /// <remarks>
        /// Lebendgewicht vor Schlachtung
        /// </remarks>
        [Column("SCHL_LEB")]
        public decimal? SCHL_LEB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kategorie".
        /// </summary>
        /// <remarks>
        /// Kategorie des Schlachtkörpers
        /// </remarks>
        [Column("SCHL_KAT")]
        public int? SCHL_KAT { get; set; }

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
        /// Gets or sets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        [Required]
        public int? MELD_MBN { get; set; }

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
        /// Gets or sets the value of "Lokaler Bearbeitungsstand".
        /// </summary>
        /// <remarks>
        /// Zeitpunkt der letzten lokalen Bearbeitung
        /// </remarks>
        [Column("PR_LOK_TS")]
        public DateTime? PR_LOK_TS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schlachtdatum".
        /// </summary>
        [Column("SCHL_DAT")]
        [Required]
        public DateOnly? SCHL_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schlachtgewicht".
        /// </summary>
        /// <remarks>
        /// Gewicht des Schlachtkörpers
        /// </remarks>
        [Column("SCHL_GEW")]
        public decimal? SCHL_GEW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        [Required]
        public decimal? MELD_BNR { get; set; }

    }
}
