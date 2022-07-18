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
    /// Last Login
    /// </summary>
    [Entity("BTR_LL")]
    public class BTR_LL
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
        /// Gets the value of "Anzahl fehlgeschlagener Anmeldungen im System".
        /// </summary>
        [Column("LL_CNT_NOK")]
        public Int64? LL_CNT_NOK { get; set; }

        /// <summary>
        /// Gets the value of "Anzahl erfolgreicher Anmeldungen im System".
        /// </summary>
        [Column("LL_CNT_OK")]
        public Int64? LL_CNT_OK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zeitpunkt der letzten erfolgreichen Anmeldung im System, über HIT-Vollmacht".
        /// </summary>
        [Column("LL_TS_HITV")]
        public DateTime? LL_TS_HITV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zeitpunkt der letzten erfolgreichen Anmeldung im System".
        /// </summary>
        [Column("LL_TS_LAST")]
        public DateTime? LL_TS_LAST { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zeitpunkt der letzten fehlgeschlagenen Anmeldung im System".
        /// </summary>
        [Column("LL_TS_MISS")]
        public DateTime? LL_TS_MISS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zeitpunkt der vorhergehenden erfolgreichen Anmeldung im System".
        /// </summary>
        [Column("LL_TS_PREV")]
        public DateTime? LL_TS_PREV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zeitpunkt der letzten erfolgreichen Anmeldung im System, über ZID-Vollmacht".
        /// </summary>
        [Column("LL_TS_ZIDV")]
        public DateTime? LL_TS_ZIDV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Mitbenutzernummer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer innerhalb einer Betriebsnummer
        /// </remarks>
        [Column("MBN")]
        [Required]
        public int? MBN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Last uncrypt use".
        /// </summary>
        [Column("LL_UC_LAST")]
        public DateTime? LL_UC_LAST { get; set; }

        /// <summary>
        /// Gets or sets the value of "Last uncrypt type".
        /// </summary>
        [Column("LL_UC_TYPE")]
        public int? LL_UC_TYPE { get; set; }

    }
}