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
    /// Tierbestandserfassung (nach § 58b AMG), Sicht für Dritten
    /// </summary>
    [Entity("TAM_BESTD")]
    public class TAM_BESTD
    {
        /// <summary>
        /// Gets or sets the value of "Betriebsnummer Dritter".
        /// </summary>
        /// <remarks>
        /// speziell im Bereich Tierarzneimittel (TAM)
        /// </remarks>
        [Column("BNR15_DR")]
        [Required]
        public decimal? BNR15_DR { get; set; }

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
        /// Gets or sets the value of "Stichtag der Bestandsmeldung".
        /// </summary>
        [Column("TAMB_DAT")]
        [Required]
        public DateOnly? TAMB_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nutzungsart (nach § 58a AMG), erweitert".
        /// </summary>
        /// <remarks>
        /// (ggf. mit spezifischen Erweiterungen)
        /// </remarks>
        [Column("TAMB_FORM")]
        [Required]
        public int? TAMB_FORM { get; set; }

        /// <summary>
        /// Gets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

        /// <summary>
        /// Gets the value of "Meldedatum".
        /// </summary>
        /// <remarks>
        /// Datum des Meldeeingang
        /// </remarks>
        [Column("MELD_DAT")]
        public DateOnly? MELD_DAT { get; set; }

        /// <summary>
        /// Gets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

        /// <summary>
        /// Gets the value of "Meldeweg".
        /// </summary>
        /// <remarks>
        /// Meldeweg (Post,IVR,IN...)
        /// </remarks>
        [Column("MELD_WG")]
        public int? MELD_WG { get; set; }

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

        /// <summary>
        /// Gets or sets the value of "Anzahl Tiere am Stichtag im Bestand".
        /// </summary>
        [Column("TAMB_ANZ")]
        [Required]
        public Int64? TAMB_ANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kalenderhalbjahr".
        /// </summary>
        [Column("TAM_PERIOD")]
        [Required]
        public int? TAM_PERIOD { get; set; }

    }
}
