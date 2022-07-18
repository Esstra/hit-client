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
    /// Aktuelle Hinweise
    /// </summary>
    [Entity("HINWEIS")]
    public class HINWEIS
    {
        /// <summary>
        /// Gets or sets the value of "Wichtigkeit".
        /// </summary>
        [Column("HINW_SCHW")]
        [Required]
        public int? HINW_SCHW { get; set; }

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
        /// Gets or sets the value of "Hinweistext".
        /// </summary>
        [Column("HINWEIS")]
        [Required]
        [JsonPropertyName("HINWEIS")]
        public string? _HINWEIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Endezeitpunkt Hinweis".
        /// </summary>
        /// <remarks>
        /// Endes der fachlichen Gültigkeit (identisch zu nächstem Beginn, oder 31.12.2100 wenn aktuell)
        /// </remarks>
        [Column("HINW_BIS")]
        [Required]
        public DateTime? HINW_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginnzeitpunkt Hinweis".
        /// </summary>
        /// <remarks>
        /// Beginns der fachlichen Gültigkeit
        /// </remarks>
        [Column("HINW_VON")]
        [Required]
        public DateTime? HINW_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis-Ziel".
        /// </summary>
        [Column("HINW_ZIEL")]
        [Required]
        public string? HINW_ZIEL { get; set; }

        /// <summary>
        /// Gets the value of "Betriebsnummer bis".
        /// </summary>
        /// <remarks>
        /// Obergrenze BNR
        /// </remarks>
        [Column("BNR15_ZB")]
        public decimal? BNR15_ZB { get; set; }

        /// <summary>
        /// Gets the value of "Betriebsnummer von".
        /// </summary>
        /// <remarks>
        /// Untergrenze BNR
        /// </remarks>
        [Column("BNR15_ZV")]
        public decimal? BNR15_ZV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Globally Unique Identifier".
        /// </summary>
        /// <remarks>
        /// Format xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx (lower case)
        /// </remarks>
        [Column("GUID")]
        public string? GUID { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis-Format".
        /// </summary>
        /// <remarks>
        /// Für welches System / welche Gruppe ist der Hinweis
        /// </remarks>
        [Column("HINW_FORM")]
        [Required]
        public int? HINW_FORM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis-Zielbereich".
        /// </summary>
        [Column("HINW_ZBER")]
        [Required]
        public int? HINW_ZBER { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweis-Zielsystem/Gruppe".
        /// </summary>
        /// <remarks>
        /// Für welches System / welche Gruppe ist der Hinweis
        /// </remarks>
        [Column("HINW_ZSYS")]
        [Required]
        public int? HINW_ZSYS { get; set; }

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

    }
}