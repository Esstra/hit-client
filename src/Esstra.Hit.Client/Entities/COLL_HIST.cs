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
    /// Collection History
    /// </summary>
    [Entity("COLL_HIST")]
    public class COLL_HIST
    {
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
        /// Gets or sets the value of "Laufende Nummer der Collection".
        /// </summary>
        [Column("COLL_LFNR")]
        [Required]
        public int? COLL_LFNR { get; set; }

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
        /// Gets or sets the value of "Beschreibung zur Dokumentation oder RS-Befehl der Collection-Änderung".
        /// </summary>
        [Column("COLL_RS")]
        [Required]
        public string? COLL_RS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zeitpunkt der Collection-Änderung".
        /// </summary>
        [Column("COLL_TS")]
        [Required]
        public DateTime? COLL_TS { get; set; }

    }
}
