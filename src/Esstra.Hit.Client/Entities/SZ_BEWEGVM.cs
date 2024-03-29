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
    /// Schaf/Ziegen Bewegung (nur zur Abfrage aus Sicht des Meldevertreters)
    /// </summary>
    [Entity("SZ_BEWEGVM")]
    public class SZ_BEWEGVM
    {
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
        /// Gets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl bewegter Schafe".
        /// </summary>
        /// <remarks>
        /// Anzahl Schafe in Bewegung
        /// </remarks>
        [Column("SZ_BEW_A_S")]
        public Int64? SZ_BEW_A_S { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl bewegter Ziegen".
        /// </summary>
        /// <remarks>
        /// Anzahl Ziegen in Bewegung
        /// </remarks>
        [Column("SZ_BEW_A_Z")]
        public Int64? SZ_BEW_A_Z { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ursprungsstaat".
        /// </summary>
        /// <remarks>
        /// Staat aus dem das Tier direkt kommt
        /// </remarks>
        [Column("LAND_URS")]
        public int? LAND_URS { get; set; }

        /// <summary>
        /// Gets the value of "Meldedatum".
        /// </summary>
        /// <remarks>
        /// Datum des Meldeeingang
        /// </remarks>
        [Column("MELD_DAT")]
        public DateOnly? MELD_DAT { get; set; }

        /// <summary>
        /// Gets the value of "Meldeweg".
        /// </summary>
        /// <remarks>
        /// Meldeweg (Post,IVR,IN...)
        /// </remarks>
        [Column("MELD_WG")]
        public int? MELD_WG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zugangsdatum".
        /// </summary>
        [Column("ZUGA_DAT")]
        [Required]
        public DateOnly? ZUGA_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Abgangsdatum".
        /// </summary>
        [Column("ABGA_DAT")]
        [Required]
        public DateOnly? ABGA_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorbesitzer Betrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Vorbesitzers
        /// </remarks>
        [Column("BNR15_VB")]
        [Required]
        public decimal? BNR15_VB { get; set; }

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
        /// Gets the value of "Satzstatus".
        /// </summary>
        /// <remarks>
        /// Systemstatus des Satzes
        /// </remarks>
        [Column("SYS_STAT")]
        public int? SYS_STAT { get; set; }

        /// <summary>
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

    }
}
