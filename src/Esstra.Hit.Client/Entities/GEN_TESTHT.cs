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
    /// Labor Testergebnisse (generisch), für Hoftierarzt mit aktueller Vollmacht
    /// </summary>
    [Entity("GEN_TESTHT")]
    public class GEN_TESTHT
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
        /// Gets or sets the value of "Parent-Betrieb".
        /// </summary>
        /// <remarks>
        /// Root-Betrieb bei Zuordnung
        /// </remarks>
        [Column("BNR15_P")]
        [Required]
        public decimal? BNR15_P { get; set; }

        /// <summary>
        /// Gets or sets the value of "PID-Betrieb, Proben-Identifikation Ausgabebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Proben-ID-Bereich verwaltet (ursprünglich BSE, dann universell)
        /// </remarks>
        [Column("BSEPID_BNR")]
        [Required]
        public decimal? BSEPID_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "PID-Probe, Proben-Identifikation Sub-Part".
        /// </summary>
        /// <remarks>
        /// spezifische eindeutige ID innerhalb des Systems einer Ausgabestelle (urspr. BSE, dann universell)
        /// </remarks>
        [Column("BSEPID_SUB")]
        [Required]
        public string? BSEPID_SUB { get; set; }

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
        /// Gets or sets the value of "Zuordnung gültig von".
        /// </summary>
        /// <remarks>
        /// Timestamp ab wann der Satz fachlich gilt
        /// </remarks>
        [Column("DZUO_VON")]
        [Required]
        public DateTime? DZUO_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsergebnis/Laborbefund, generisch".
        /// </summary>
        [Column("GEN_ERG")]
        [Required]
        public int? GEN_ERG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsmethode, generisch".
        /// </summary>
        [Column("GEN_METH")]
        [Required]
        public int? GEN_METH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tierseuche bei generischen Laboruntersuchung, z.Zt. laut TSN-Liste".
        /// </summary>
        [Column("GEN_SEUCHE")]
        [Required]
        public int? GEN_SEUCHE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tierart, für generisch Laborergebnisse".
        /// </summary>
        [Column("GEN_TIERA")]
        [Required]
        public int? GEN_TIERA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsart, generisch".
        /// </summary>
        /// <remarks>
        /// Art serologisch, virologisch,...
        /// </remarks>
        [Column("GEN_UART")]
        [Required]
        public int? GEN_UART { get; set; }

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
        /// Gets or sets the value of "Mess-Wert (Rohdaten)".
        /// </summary>
        /// <remarks>
        /// Format je nach Test
        /// </remarks>
        [Column("MESS_WERT")]
        public decimal? MESS_WERT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl in Pool".
        /// </summary>
        [Column("POOL_ANZ")]
        public Int64? POOL_ANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art der Poolung bei generischen Laboruntersuchung".
        /// </summary>
        [Column("POOL_ART")]
        public int? POOL_ART { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tier- oder Gruppen-ID".
        /// </summary>
        [Column("POOL_ID")]
        [Required]
        public string? POOL_ID { get; set; }

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
        /// Gets or sets the value of "Auftraggeber".
        /// </summary>
        /// <remarks>
        /// Auftraggeber-Betriebsnr. für Untersuchungsauftrag, Halter, Tierarzt, Auktionator oder Veterinär
        /// </remarks>
        [Column("UNTAUF_BNR")]
        public decimal? UNTAUF_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungslabor".
        /// </summary>
        /// <remarks>
        /// Betriebsnr des Untersuchungslabor oder -anstalt
        /// </remarks>
        [Column("UNTS_BNR15")]
        [Required]
        public decimal? UNTS_BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Probeneingang - Datum".
        /// </summary>
        /// <remarks>
        /// Datum des Zeitpunkts der Einzelprobenerfassung
        /// </remarks>
        [Column("UNTS_EDAT")]
        [Required]
        public DateOnly? UNTS_EDAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsgrund, im Untersuchungsauftrag".
        /// </summary>
        [Column("UNTS_GRUND")]
        public int? UNTS_GRUND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsmaterial, im Untersuchungsauftrag".
        /// </summary>
        [Column("UNTS_MAT")]
        public int? UNTS_MAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Probennahmedatum".
        /// </summary>
        /// <remarks>
        /// Datum der Entnahme der Probe beim Tier
        /// </remarks>
        [Column("UNTS_NDAT")]
        [Required]
        public DateOnly? UNTS_NDAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsdatum".
        /// </summary>
        /// <remarks>
        /// Datum der Untersuchung im Labor
        /// </remarks>
        [Column("UNTS_UDAT")]
        [Required]
        public DateOnly? UNTS_UDAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer Verbringungs-Ziel / Empfänger".
        /// </summary>
        [Column("BNR15_ZIEL")]
        public decimal? BNR15_ZIEL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Freigabe der generischen Befunde".
        /// </summary>
        [Column("GEN_FREIG")]
        [Required]
        public int? GEN_FREIG { get; set; }

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

    }
}
