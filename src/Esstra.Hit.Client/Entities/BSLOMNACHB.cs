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
    /// LOM-Nachbestellungen (zur Betriebsstätte)
    /// </summary>
    [Entity("BSLOMNACHB")]
    public class BSLOMNACHB
    {
        /// <summary>
        /// Gets or sets the value of "Zuordnung gültig von".
        /// </summary>
        /// <remarks>
        /// Timestamp ab wann der Satz fachlich gilt
        /// </remarks>
        [Column("DZUO_VON")]
        [Required]
        public DateTime? DZUO_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Parent-Betrieb".
        /// </summary>
        /// <remarks>
        /// Root-Betrieb bei Zuordnung
        /// </remarks>
        [Column("BNR15_P")]
        [Required]
        public decimal? BNR15_P { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zuordnung gültig bis".
        /// </summary>
        /// <remarks>
        /// fachlich gültig bis oder aktuell (31.12.2100)
        /// </remarks>
        [Column("DZUO_BIS")]
        [Required]
        public DateTime? DZUO_BIS { get; set; }

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
        /// Gets or sets the value of "Bestellanzahl".
        /// </summary>
        /// <remarks>
        /// Nachbestellung Einfach/Doppel-Ohrmarke
        /// </remarks>
        [Column("BESTZAHL")]
        [Required]
        public int? BESTZAHL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bestellgrund".
        /// </summary>
        /// <remarks>
        /// Grund der Ohrmarken-Nachbestellung
        /// </remarks>
        [Column("BESTGRND")]
        public int? BESTGRND { get; set; }

        /// <summary>
        /// Gets or sets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets the value of "Satzstatus".
        /// </summary>
        /// <remarks>
        /// Systemstatus des Satzes
        /// </remarks>
        [Column("SYS_STAT")]
        public int? SYS_STAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nachbestellungsdatum".
        /// </summary>
        /// <remarks>
        /// Datum der LOM-Nachbestellung
        /// </remarks>
        [Column("NACH_DAT")]
        [Required]
        public DateOnly? NACH_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldeweg".
        /// </summary>
        /// <remarks>
        /// Meldeweg (Post,IVR,IN...)
        /// </remarks>
        [Column("MELD_WG")]
        public int? MELD_WG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldedatum".
        /// </summary>
        /// <remarks>
        /// Datum des Meldeeingang
        /// </remarks>
        [Column("MELD_DAT")]
        public DateOnly? MELD_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohrmarke".
        /// </summary>
        /// <remarks>
        /// IDENTIFICATION NUMBER
        /// </remarks>
        [Column("LOM")]
        [Required]
        public decimal? LOM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art der Ohrmarke für Nachbestellung".
        /// </summary>
        /// <remarks>
        /// Art und Hersteller der Ohrmarke für Nachbestellung, länderspeziifisch
        /// </remarks>
        [Column("LOM_ART_NB")]
        [Required]
        public int? LOM_ART_NB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art der Ohrmarke konventionell / elektronisch".
        /// </summary>
        [Column("LOM_ART_KE")]
        public int? LOM_ART_KE { get; set; }

    }
}
