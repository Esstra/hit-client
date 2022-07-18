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
    /// Nachbestellung von Transpondern für Equiden
    /// </summary>
    [Entity("EQ_TR_NABE")]
    public class EQ_TR_NABE
    {
        /// <summary>
        /// Gets or sets the value of "Registriernummer Transponder-Nachbesteller".
        /// </summary>
        /// <remarks>
        /// Registriernummer der Stelle die Transponder für Equiden nachbestellt
        /// </remarks>
        [Column("BNR15_NB_E")]
        [Required]
        public decimal? BNR15_NB_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Registriernummer Transponder-Ausgeber / zuteilende Stelle".
        /// </summary>
        /// <remarks>
        /// Registriernummer der Stelle die Transponder für Equiden zuteilt bzw. konkret ausgibt
        /// </remarks>
        [Column("BNR15_TZ_E")]
        [Required]
        public decimal? BNR15_TZ_E { get; set; }

        /// <summary>
        /// Gets the value of "Meldedatum".
        /// </summary>
        /// <remarks>
        /// Datum des Meldeeingang
        /// </remarks>
        [Column("MELD_DAT")]
        public DateOnly? MELD_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum der Nachbestellung Equiden-Transponder".
        /// </summary>
        /// <remarks>
        /// Datum der Nachbestellung von Transpondern für Equiden
        /// </remarks>
        [Column("TR_NB_DAT")]
        [Required]
        public DateOnly? TR_NB_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Grund der Nachbestellung Equiden-Transponder".
        /// </summary>
        [Column("TR_NB_GRND")]
        [Required]
        public int? TR_NB_GRND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Transponder-Nr".
        /// </summary>
        /// <remarks>
        /// IDENTIFICATION NUMBER, momentan beschränkt auf Equiden
        /// </remarks>
        [Column("TRNR15")]
        [Required]
        public decimal? TRNR15 { get; set; }

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
        /// Gets the value of "Satzstatus".
        /// </summary>
        /// <remarks>
        /// Systemstatus des Satzes
        /// </remarks>
        [Column("SYS_STAT")]
        public int? SYS_STAT { get; set; }

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