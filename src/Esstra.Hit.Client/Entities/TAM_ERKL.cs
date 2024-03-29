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
    /// Erklärung des Halters bezüglich Dritter (nach § 58 AMG)
    /// </summary>
    [Entity("TAM_ERKL")]
    public class TAM_ERKL
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
        /// Gets or sets the value of "Endezeitpunkt, der Eingabemöglichkeit".
        /// </summary>
        /// <remarks>
        /// bis wann eine Erklärung genutzt werden kann, d.h. IN welchem Zeitraum eingegeben werden kann (der Ende-Zeitpunkt ist ausschließlich)
        /// </remarks>
        [Column("TAME_BIS")]
        [Required]
        public DateTime? TAME_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Erlaube Dritten Abruf meiner Halter TAM-Abgabe/Anwendung".
        /// </summary>
        [Column("TAME_ER_AB")]
        [Required]
        public int? TAME_ER_AB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Erlaube Dritten Eintragungen TAM-Abgabe/Anwendung".
        /// </summary>
        [Column("TAME_ER_EI")]
        [Required]
        public int? TAME_ER_EI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nutzungsart (nach § 58 AMG)".
        /// </summary>
        /// <remarks>
        /// für Erklärung (auch nicht mitteilungspflichtige, weil wie Vollmacht)
        /// </remarks>
        [Column("TAME_FORM")]
        [Required]
        public int? TAME_FORM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginnzeitpunkt, der Eingabemöglichkeit".
        /// </summary>
        /// <remarks>
        /// ab wann eine Erklärung genutzt werden kann, d.h. IN welchem Zeitraum eingegeben werden kann (der Beginn-Zeitpunkt ist einschließlich)
        /// </remarks>
        [Column("TAME_VON")]
        [Required]
        public DateTime? TAME_VON { get; set; }

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
        /// Gets or sets the value of "Erlaube Dritten Abruf meiner Halter TAM-Nutzungsart".
        /// </summary>
        [Column("TAME_ER_A2")]
        [Required]
        public bool? TAME_ER_A2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Erlaube Dritten Abruf meiner Halter TAM-Tierbestand / Bestandsveränderungen".
        /// </summary>
        [Column("TAME_ER_A3")]
        [Required]
        public bool? TAME_ER_A3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Erlaube Dritten Eintragungen TAM-Nutzungsart".
        /// </summary>
        [Column("TAME_ER_E2")]
        [Required]
        public bool? TAME_ER_E2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Erlaube Dritten Eintragungen TAM-Tierbestand / Bestandsveränderungen".
        /// </summary>
        [Column("TAME_ER_E3")]
        [Required]
        public bool? TAME_ER_E3 { get; set; }

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
        /// Gets or sets the value of "Endedatum, für wann gemeldet werden kann".
        /// </summary>
        /// <remarks>
        /// Letztes mögliches Abgabe/Anwendungs- oder Ereignisdatum, d.h. FÜR welchem Zeitraum eingegeben werden kann (das Ende-Datum ist einschließlich)
        /// </remarks>
        [Column("TAME_FWBIS")]
        public DateOnly? TAME_FWBIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginndatum, für wann gemeldet werden kann".
        /// </summary>
        /// <remarks>
        /// Erstes mögliches Abgabe/Anwendungs- oder Ereignisdatum, d.h. FÜR welchem Zeitraum eingegeben werden kann (das Beginn-Datum ist einschließlich)
        /// </remarks>
        [Column("TAME_FWVON")]
        public DateOnly? TAME_FWVON { get; set; }

    }
}
