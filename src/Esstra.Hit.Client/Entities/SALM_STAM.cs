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
    /// Salmonellen-Eigenkontrollen, Stammdaten zum Stall
    /// </summary>
    [Entity("SALM_STAM")]
    public class SALM_STAM
    {
        /// <summary>
        /// Gets or sets the value of "Nutzungart, Nutzungsrichtung".
        /// </summary>
        [Column("SA_FORM")]
        public int? SA_FORM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geflügelart".
        /// </summary>
        [Column("SA_GEFLART")]
        [Required]
        public int? SA_GEFLART { get; set; }

        /// <summary>
        /// Gets or sets the value of "Haltungsart, Haltungsform".
        /// </summary>
        [Column("SA_HALTART")]
        [Required]
        public int? SA_HALTART { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name der Stalleinheit".
        /// </summary>
        [Column("SA_NAME")]
        [Required]
        public string? SA_NAME { get; set; }

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
        /// Gets or sets the value of "Nummer der Stalleinheit".
        /// </summary>
        [Column("SA_STNR")]
        [Required]
        public Int64? SA_STNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Globally Unique Identifier".
        /// </summary>
        /// <remarks>
        /// Format xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx (lower case)
        /// </remarks>
        [Column("GUID")]
        public string? GUID { get; set; }

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
        /// Gets or sets the value of "Einstallalter in Tagen".
        /// </summary>
        [Column("SA_ALTER_E")]
        public int? SA_ALTER_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Durchgangsende, Ausstalldatum".
        /// </summary>
        /// <remarks>
        /// Letzter Tag
        /// </remarks>
        [Column("SA_DG_END")]
        public DateOnly? SA_DG_END { get; set; }

        /// <summary>
        /// Gets or sets the value of "Durchgangsbeginn, Einstalldatum".
        /// </summary>
        /// <remarks>
        /// Erster Tag
        /// </remarks>
        [Column("SA_DG_STA")]
        [Required]
        public DateOnly? SA_DG_STA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bemerkungen zum Stall".
        /// </summary>
        [Column("SA_SBEM")]
        [Required]
        public string? SA_SBEM { get; set; }

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

        /// <summary>
        /// Gets or sets the value of "Tierzahl in Stalleinheit zu Beginn des Durchgangs".
        /// </summary>
        [Column("SA_KAP")]
        [Required]
        public Int64? SA_KAP { get; set; }

    }
}
