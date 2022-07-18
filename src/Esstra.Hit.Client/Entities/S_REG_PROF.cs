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
    /// Profil mit Einstellungen zum Schweinebestandsregister
    /// </summary>
    [Entity("S_REG_PROF")]
    public class S_REG_PROF
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
        /// Gets or sets the value of "Schweineregister-Profil, Datenfreigabe für Behörde".
        /// </summary>
        [Column("SRG_PR_DB")]
        public int? SRG_PR_DB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schweineregister-Profil, TAM-Anfangsbestandsmeldung automatisch aus Register".
        /// </summary>
        [Column("SRG_PR_TB")]
        public bool? SRG_PR_TB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schweineregister-Profil, TAM-Bestandsveränderungsmeldung automatisch aus Register".
        /// </summary>
        [Column("SRG_PR_TV")]
        public bool? SRG_PR_TV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schweineregister-Profil, VVVO-Zugangsmeldung automatisch aus Register".
        /// </summary>
        [Column("SRG_PR_VB")]
        public bool? SRG_PR_VB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schweineregister-Profil, VVVO-Stichtagsmeldung automatisch aus Register".
        /// </summary>
        [Column("SRG_PR_VS")]
        public bool? SRG_PR_VS { get; set; }

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
