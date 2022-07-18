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
    /// Schaf/Ziegen Stichtagsmeldung
    /// </summary>
    [Entity("SZ_STICHTA")]
    public class SZ_STICHTA
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
        /// Gets or sets the value of "Anzahl Schafe der Gruppe 3 - ab 19 Monate".
        /// </summary>
        /// <remarks>
        /// >= 19 Monate
        /// </remarks>
        [Column("SZ_A_G3_S")]
        [Required]
        public Int64? SZ_A_G3_S { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Schafe der Gruppe 2 - über 9 bis unter 19 Monate".
        /// </summary>
        /// <remarks>
        /// > 9 und < 19 Monate
        /// </remarks>
        [Column("SZ_A_G2_S")]
        [Required]
        public Int64? SZ_A_G2_S { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Schafe der Gruppe 1 - bis 9 Monate".
        /// </summary>
        /// <remarks>
        /// <= 9 Monate
        /// </remarks>
        [Column("SZ_A_G1_S")]
        [Required]
        public Int64? SZ_A_G1_S { get; set; }

        /// <summary>
        /// Gets or sets the value of "Stichtag".
        /// </summary>
        /// <remarks>
        /// Stichtag für Schafe/Ziegenbestandserfassung
        /// </remarks>
        [Column("SZ_STICHDT")]
        [Required]
        public DateOnly? SZ_STICHDT { get; set; }

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
        /// Gets the value of "Meldeweg".
        /// </summary>
        /// <remarks>
        /// Meldeweg (Post,IVR,IN...)
        /// </remarks>
        [Column("MELD_WG")]
        public int? MELD_WG { get; set; }

        /// <summary>
        /// Gets the value of "Meldedatum".
        /// </summary>
        /// <remarks>
        /// Datum des Meldeeingang
        /// </remarks>
        [Column("MELD_DAT")]
        public DateOnly? MELD_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Ziegen der Gruppe 3 - ab 19 Monate".
        /// </summary>
        /// <remarks>
        /// >= 19 Monate
        /// </remarks>
        [Column("SZ_A_G3_Z")]
        [Required]
        public Int64? SZ_A_G3_Z { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Ziegen der Gruppe 2 - über 9 bis unter 19 Monate".
        /// </summary>
        /// <remarks>
        /// > 9 und < 19 Monate
        /// </remarks>
        [Column("SZ_A_G2_Z")]
        [Required]
        public Int64? SZ_A_G2_Z { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Ziegen der Gruppe 1 - bis 9 Monate".
        /// </summary>
        /// <remarks>
        /// <= 9 Monate
        /// </remarks>
        [Column("SZ_A_G1_Z")]
        [Required]
        public Int64? SZ_A_G1_Z { get; set; }

        /// <summary>
        /// Gets the value of "Satzstatus".
        /// </summary>
        /// <remarks>
        /// Systemstatus des Satzes
        /// </remarks>
        [Column("SYS_STAT")]
        public int? SYS_STAT { get; set; }

    }
}