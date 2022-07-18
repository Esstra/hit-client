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
    /// Betrieb für Risikoanalyse, nur aktuell nicht stornierte, strukturell analog zu BETRR
    /// </summary>
    [Entity("BTR_R_OLD")]
    public class BTR_R_OLD
    {
        /// <summary>
        /// Gets or sets the value of "Risikoanalyseart".
        /// </summary>
        /// <remarks>
        /// Art der Risikoanalyse
        /// </remarks>
        [Column("RIS_ART")]
        [Required]
        public int? RIS_ART { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kontroll-Verteiler".
        /// </summary>
        /// <remarks>
        /// Verteiler der in Risikoanalyse ausgewählten Betriebe auf Kontrollorgane
        /// </remarks>
        [Column("KTRL_VERT")]
        [Required]
        public int? KTRL_VERT { get; set; }

        /// <summary>
        /// Gets the value of "Risikoeintrag gültig bis".
        /// </summary>
        /// <remarks>
        /// fachlich gültig bis oder aktuell (31.12.2100)
        /// </remarks>
        [Column("DRIS_BIS")]
        public DateTime? DRIS_BIS { get; set; }

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
        /// Gets or sets the value of "Jahr der Risikoanalyse (Kontrolljahr)".
        /// </summary>
        /// <remarks>
        /// Jahresangabe, vierstellig
        /// </remarks>
        [Column("RIS_JAHR")]
        [Required]
        public int? RIS_JAHR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Risikoauswahl Merkmal".
        /// </summary>
        /// <remarks>
        /// Merkmal zur freine Verfügung
        /// </remarks>
        [Column("RIS_MERK")]
        [Required]
        public string? RIS_MERK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer des Unternehmens für Cross-Compliance".
        /// </summary>
        /// <remarks>
        /// Antragsteller-Registriernummer
        /// </remarks>
        [Column("BNR15_UNCC")]
        [Required]
        public decimal? BNR15_UNCC { get; set; }

        /// <summary>
        /// Gets or sets the value of "Risikoauswahlgrund".
        /// </summary>
        /// <remarks>
        /// Grund für Auswahl in Risikoanalyse
        /// </remarks>
        [Column("RIS_GRND")]
        [Required]
        public int? RIS_GRND { get; set; }

        /// <summary>
        /// Gets the value of "Risikoeintrag gültig von".
        /// </summary>
        /// <remarks>
        /// Timestamp ab wann der Satz fachlich gilt
        /// </remarks>
        [Column("DRIS_VON")]
        public DateTime? DRIS_VON { get; set; }

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

    }
}
