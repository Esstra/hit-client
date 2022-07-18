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
    /// Zahlungsansprüche, Handelsbesonderheiten Betriebsbezogen, Hinweise
    /// </summary>
    [Entity("ZA_HANBES")]
    public class ZA_HANBES
    {
        /// <summary>
        /// Gets or sets the value of "Ende der Gültigkeit des Besonderheit oder Beschränkung bei Betrieb".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem Besonderheit nicht mehr gültig ist, damit ggf. ident. mit nächstem Beginn
        /// </remarks>
        [Column("ZA_HB_BIS")]
        [Required]
        public DateTime? ZA_HB_BIS { get; set; }

        /// <summary>
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art der Besonderheit oder Beschränkung bei Betrieb".
        /// </summary>
        [Column("ZA_HB_ART")]
        [Required]
        public int? ZA_HB_ART { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Betriebsnummer mit Handelsbeschränkung".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer oder Landes-Dummy 276xx0000000000
        /// </remarks>
        [Column("ZA_HB_BNR")]
        [Required]
        public decimal? ZA_HB_BNR { get; set; }

        /// <summary>
        /// Gets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets the value of "Stornomitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung storniert hat
        /// </remarks>
        [Column("STRN_MBN")]
        public int? STRN_MBN { get; set; }

        /// <summary>
        /// Gets the value of "Stornobetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung storniert hat
        /// </remarks>
        [Column("STRN_BNR")]
        public decimal? STRN_BNR { get; set; }

        /// <summary>
        /// Gets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

        /// <summary>
        /// Gets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Grund der Besonderheit oder Beschränkung bei Betrieb".
        /// </summary>
        [Column("ZA_HB_GRND")]
        [Required]
        public int? ZA_HB_GRND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginn der Gültigkeit des Besonderheit oder Beschränkung bei Betrieb".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem die neue Besonderheit gültig ist
        /// </remarks>
        [Column("ZA_HB_VON")]
        [Required]
        public DateTime? ZA_HB_VON { get; set; }

    }
}
