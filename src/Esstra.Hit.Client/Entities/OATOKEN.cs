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
    /// OIDC Token
    /// </summary>
    [Entity("OATOKEN")]
    public class OATOKEN
    {
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
        /// Gets or sets the value of "Weiterleitungs-URI für OAuth-Antworten".
        /// </summary>
        [Column("OI_RED_URI")]
        [Required]
        public string? OI_RED_URI { get; set; }

        /// <summary>
        /// Gets or sets the value of "OIDC-Session-Id des verwendeten ID-Tokens".
        /// </summary>
        [Column("OI_NONCE")]
        [Required]
        public string? OI_NONCE { get; set; }

        /// <summary>
        /// Gets the value of "OIDC-Token".
        /// </summary>
        [Column("OI_TOKEN")]
        public string? OI_TOKEN { get; set; }

        /// <summary>
        /// Gets the value of "OIDC-Token gültig bis".
        /// </summary>
        /// <remarks>
        /// exkludiert
        /// </remarks>
        [Column("OI_TOK_BIS")]
        public DateTime? OI_TOK_BIS { get; set; }

        /// <summary>
        /// Gets the value of "OIDC-Token gültig ab".
        /// </summary>
        /// <remarks>
        /// inkludiert
        /// </remarks>
        [Column("OI_TOK_VON")]
        public DateTime? OI_TOK_VON { get; set; }

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
        /// Gets or sets the value of "Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Registriernummer für Betrieb, Langform mit B.Land und Staat
        /// </remarks>
        [Column("BNR15")]
        [Required]
        public decimal? BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Typ des OIDC-Tokens".
        /// </summary>
        [Column("OI_TOK_TYP")]
        [Required]
        public int? OI_TOK_TYP { get; set; }

        /// <summary>
        /// Gets or sets the value of "OIDC-Client-Id".
        /// </summary>
        /// <remarks>
        /// (case sensitive, Kunde und HIT/ZID vereinbaren, Buchstaben + Ziffern)
        /// </remarks>
        [Column("OI_C_ID")]
        [Required]
        public string? OI_C_ID { get; set; }

    }
}
