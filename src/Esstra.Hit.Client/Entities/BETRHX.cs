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
    /// HIT-Zugang-Miss (ab 1.4.2004 read only)
    /// </summary>
    [Entity("BETRHX")]
    public class BETRHX
    {
        /// <summary>
        /// Gets or sets the value of "Falscheingabe bei PIN (Passwort)".
        /// </summary>
        /// <remarks>
        /// Speichern einer falschen PIN um Scanning zu ermitteln
        /// </remarks>
        [Column("PIN_MISS")]
        [Required]
        public string? PIN_MISS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Mitbenutzernummer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer innerhalb einer Betriebsnummer
        /// </remarks>
        [Column("MBN")]
        [Required]
        public int? MBN { get; set; }

        /// <summary>
        /// Gets or sets the value of "IP-Adresse bei PIN-Miss".
        /// </summary>
        /// <remarks>
        /// Speichern der IP-Adresse um Scanning zu ermitteln
        /// </remarks>
        [Column("IP_MISS")]
        [Required]
        public string? IP_MISS { get; set; }

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
        /// Gets or sets the value of "TS der falschen PIN-Eingabe".
        /// </summary>
        /// <remarks>
        /// TS um max. 5 Misses pro Tag zuzulassen
        /// </remarks>
        [Column("TS_MISS")]
        [Required]
        public DateTime? TS_MISS { get; set; }

    }
}