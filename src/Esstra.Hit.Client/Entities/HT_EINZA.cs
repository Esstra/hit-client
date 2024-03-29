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
    /// Einzug/Stilllegung Heimtierpässe (anonymisierte Sicht für Verwaltung)
    /// </summary>
    [Entity("HT_EINZA")]
    public class HT_EINZA
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
        /// Gets or sets the value of "Betriebsnummer beauftragter Tierarzt, für Ausgaben von Heimtierpässen (anonymisiert)".
        /// </summary>
        [Column("BNR15_HTAA")]
        [Required]
        public decimal? BNR15_HTAA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl eingezogener Heimtierpässe".
        /// </summary>
        [Column("HT_EINZANZ")]
        [Required]
        public Int64? HT_EINZANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art des Einzug".
        /// </summary>
        [Column("HT_EINZART")]
        [Required]
        public int? HT_EINZART { get; set; }

        /// <summary>
        /// Gets or sets the value of "Einzugsdatum Heimtierpässe".
        /// </summary>
        [Column("HT_EINZDAT")]
        [Required]
        public DateOnly? HT_EINZDAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Obergrenze der Heimtierausweis Nummernserie".
        /// </summary>
        [Column("HT_PASSOG")]
        [Required]
        public decimal? HT_PASSOG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untergrenze der Heimtierausweis Nummernserie".
        /// </summary>
        [Column("HT_PASSUG")]
        [Required]
        public decimal? HT_PASSUG { get; set; }

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
