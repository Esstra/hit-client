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
    /// HIT-Zugang mit PIN (ab 1.4.2004 read only)
    /// </summary>
    [Entity("BETRH")]
    public class BETRH
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
        /// Gets or sets the value of "PIN (Passwort) Wiederholung".
        /// </summary>
        /// <remarks>
        /// Wiederholung des persönliches Passwort
        /// </remarks>
        [Column("PIN2")]
        public string? PIN2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "PIN (Passwort)".
        /// </summary>
        /// <remarks>
        /// Personen-Identifikationsnummer d.h. persönliches Passwort (in alten Betriebsdaten nur 6 Stellen)
        /// </remarks>
        [Column("PIN")]
        [Required]
        public string? PIN { get; set; }

        /// <summary>
        /// Gets the value of "Betrdat.HIT gültig von".
        /// </summary>
        /// <remarks>
        /// Timestamp ab wann der Satz fachlich gilt
        /// </remarks>
        [Column("DHIT_VON")]
        public DateTime? DHIT_VON { get; set; }

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
        /// Gets the value of "Betrdat.HIT gültig bis".
        /// </summary>
        /// <remarks>
        /// fachlich gültig bis oder aktuell (31.12.2100)
        /// </remarks>
        [Column("DHIT_BIS")]
        public DateTime? DHIT_BIS { get; set; }

    }
}
