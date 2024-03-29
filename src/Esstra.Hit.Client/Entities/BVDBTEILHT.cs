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
    /// Betriebs-Teilnahmeerklärung (BVD-Verfahren, Impfstatus), für Hoftierarzt mit aktueller Vollmacht
    /// </summary>
    [Entity("BVDBTEILHT")]
    public class BVDBTEILHT
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
        /// Gets or sets the value of "Jungtierfensterumfang".
        /// </summary>
        /// <remarks>
        /// Umfang der letzten Kontaktstichprobe
        /// </remarks>
        [Column("JTF_UMF")]
        public int? JTF_UMF { get; set; }

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
        /// Gets or sets the value of "Programm Verfahrensmethode".
        /// </summary>
        [Column("BVDBT_VE_M")]
        public int? BVDBT_VE_M { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebs-Beitrittserklärung Datum".
        /// </summary>
        /// <remarks>
        /// Datum des gültigen, letzen Antrags
        /// </remarks>
        [Column("BVDBT_DAT")]
        [Required]
        public DateOnly? BVDBT_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Programm Einstiegsart".
        /// </summary>
        [Column("BVDBT_EIN")]
        public int? BVDBT_EIN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebs-Beitrittserklärung mit Zustimmung zur Datenweitergabe".
        /// </summary>
        /// <remarks>
        /// Art der Beitrittserklärung und Umfang der Datenweitergabe
        /// </remarks>
        [Column("BVDBT_ERK")]
        [Required]
        public int? BVDBT_ERK { get; set; }

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
        /// Gets or sets the value of "Betriebs-Beitrittserklärung Endedatum".
        /// </summary>
        /// <remarks>
        /// wenn Teilnahme gekündigt, letztes Datum des Teilnahmnezeitraumes
        /// </remarks>
        [Column("BVDBT_END")]
        [Required]
        public DateOnly? BVDBT_END { get; set; }

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
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

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

    }
}
