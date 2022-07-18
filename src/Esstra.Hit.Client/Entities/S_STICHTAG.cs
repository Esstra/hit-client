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
    /// Schweine Stichtagsmeldung
    /// </summary>
    [Entity("S_STICHTAG")]
    public class S_STICHTAG
    {
        /// <summary>
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets the value of "Cluster-Spalte".
        /// </summary>
        /// <remarks>
        /// Systemintern
        /// </remarks>
        [Column("SYS_CLUST")]
        public int? SYS_CLUST { get; set; }

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
        /// Gets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

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
        /// Gets or sets the value of "Anzahl Schweine Gruppe 1".
        /// </summary>
        /// <remarks>
        /// bis 2007 Zuchtschweine, inkl. Saugferkel, ab 2008 Zuchtsauen
        /// </remarks>
        [Column("S_ANZ_G1")]
        [Required]
        public Int64? S_ANZ_G1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Schweine der Gruppe 2".
        /// </summary>
        /// <remarks>
        /// bis 2007 Mastschweine, ab 2008 Anzahl sonstige Zucht- und Mastschweine über 30 kg
        /// </remarks>
        [Column("S_ANZ_G2")]
        [Required]
        public Int64? S_ANZ_G2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Stichtag".
        /// </summary>
        /// <remarks>
        /// Stichtag für Schweinebestandserfassung
        /// </remarks>
        [Column("S_STICHDAT")]
        [Required]
        public DateOnly? S_STICHDAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Schweine der Gruppe 3".
        /// </summary>
        /// <remarks>
        /// bis 2007 leer, ab 2008 Anzahl Ferkel bis einschließlich 30 kg
        /// </remarks>
        [Column("S_ANZ_G3")]
        public Int64? S_ANZ_G3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Mastschweine ab 30kg, innerhalb Gruppe 2".
        /// </summary>
        /// <remarks>
        /// ab 2016 Anzahl Mastschweine ab 30kg, als Untergruppe zu Gruppe 2 (G2 !)
        /// </remarks>
        [Column("S_ANZ_G3M")]
        public Int64? S_ANZ_G3M { get; set; }

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