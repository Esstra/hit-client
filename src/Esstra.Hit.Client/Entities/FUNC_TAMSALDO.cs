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
    /// TAM-Bestand und Bestandsänderungen, Saldo und Durchschnitt
    /// </summary>
    [Entity("FUNC_TAMSALDO")]
    public class FUNC_TAMSALDO
    {
        /// <summary>
        /// Gets or sets the value of "Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Registriernummer für Betrieb, Langform mit B.Land und Staat
        /// </remarks>
        [Column("BNR15")]
        public decimal? BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Betriebsschlüssel für Ausgabe i.d.F. ll rkk gggg nnnn
        /// </remarks>
        [Column("BNR15_X")]
        public string? BNR15_X { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum".
        /// </summary>
        /// <remarks>
        /// Stichtag oder Vorgangsdatum
        /// </remarks>
        [Column("DATUM")]
        public DateOnly? DATUM { get; set; }

        /// <summary>
        /// Gets or sets the value of "BIS-Datum".
        /// </summary>
        /// <remarks>
        /// Ober-Grenze für Abfragefunktionen
        /// </remarks>
        [Column("DAT_BIS")]
        public DateOnly? DAT_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "VON-Datum".
        /// </summary>
        /// <remarks>
        /// Unter-Grenze für Abfragefunktionen
        /// </remarks>
        [Column("DAT_VON")]
        public DateOnly? DAT_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "TAM-Bestand Durchschnitt bis Rechenstichtag".
        /// </summary>
        [Column("TAMB_AVG")]
        public decimal? TAMB_AVG { get; set; }

        /// <summary>
        /// Gets or sets the value of "TAM-Bestand Durchschnitt bis Halbjahresende".
        /// </summary>
        [Column("TAMB_AVGX")]
        public decimal? TAMB_AVGX { get; set; }

        /// <summary>
        /// Gets or sets the value of "TAM-Bestand Fehler in Bestandsveränderungsmitteilungen".
        /// </summary>
        [Column("TAMB_ERR")]
        public int? TAMB_ERR { get; set; }

        /// <summary>
        /// Gets or sets the value of "TAM-Bestand Fehlermeldung".
        /// </summary>
        [Column("TAMB_ERRM")]
        public string? TAMB_ERRM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nutzungsart (nach § 58a AMG), erweitert".
        /// </summary>
        /// <remarks>
        /// (ggf. mit spezifischen Erweiterungen)
        /// </remarks>
        [Column("TAMB_FORM")]
        public int? TAMB_FORM { get; set; }

        /// <summary>
        /// Gets or sets the value of "TAM-Bestand kumulierte Tiertage Anfang bis Rechenstichtag".
        /// </summary>
        [Column("TAMB_KUM")]
        public Int64? TAMB_KUM { get; set; }

        /// <summary>
        /// Gets or sets the value of "TAM-Bestand kumulierte Tiertage Anfang bis Halbjahresende".
        /// </summary>
        [Column("TAMB_KUMX")]
        public Int64? TAMB_KUMX { get; set; }

        /// <summary>
        /// Gets or sets the value of "TAM-Bestand Datum der letzten Bestandsänderung".
        /// </summary>
        [Column("TAMB_LAST")]
        public DateOnly? TAMB_LAST { get; set; }

        /// <summary>
        /// Gets or sets the value of "TAM-Bestand Saldo".
        /// </summary>
        [Column("TAMB_SALDO")]
        public Int64? TAMB_SALDO { get; set; }

        /// <summary>
        /// Gets or sets the value of "TAM-Bestand Anzahl Tage Anfang bis Rechenstichtag".
        /// </summary>
        [Column("TAMB_TAGE")]
        public int? TAMB_TAGE { get; set; }

        /// <summary>
        /// Gets or sets the value of "TAM-Bestand Anzahl Tage Anfang bis Halbjahresende".
        /// </summary>
        [Column("TAMB_TAGEX")]
        public int? TAMB_TAGEX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kalenderhalbjahr".
        /// </summary>
        [Column("TAM_PERIOD")]
        public int? TAM_PERIOD { get; set; }

        /// <summary>
        /// Gets or sets the value of "TAM-Bestand zum Halbjahresbeginn".
        /// </summary>
        [Column("TAMB_START")]
        public Int64? TAMB_START { get; set; }

    }
}
