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
    /// Abgleich Bestandsregister Rinder mit TAM-Bestandsänderungen
    /// </summary>
    [Entity("FUNC_TAMBESTV")]
    public class FUNC_TAMBESTV
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
        /// Gets or sets the value of "TAM-Bestand Mastkalb oder Mastrind".
        /// </summary>
        [Column("TAMBEST_KR")]
        public int? TAMBEST_KR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nutzungsart (nach § 58a AMG), erweitert".
        /// </summary>
        /// <remarks>
        /// (ggf. mit spezifischen Erweiterungen)
        /// </remarks>
        [Column("TAMB_FORM")]
        public int? TAMB_FORM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Aktion zur Korrektur TAM-Bestandsänderungsmeldung".
        /// </summary>
        [Column("TAMV_AKT")]
        public int? TAMV_AKT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art der Bestandsveränderung".
        /// </summary>
        [Column("TAMV_ART")]
        public int? TAMV_ART { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum der Bestandsveränderung".
        /// </summary>
        [Column("TAMV_DAT")]
        public DateOnly? TAMV_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Tiere der Bestandsveränderung, Istwert laut aktueller TAM-Meldung".
        /// </summary>
        [Column("TAMV_IST")]
        public Int64? TAMV_IST { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Tiere der Bestandsveränderung, Sollwert laut Register".
        /// </summary>
        [Column("TAMV_SOLL")]
        public Int64? TAMV_SOLL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kalenderhalbjahr".
        /// </summary>
        [Column("TAM_PERIOD")]
        public int? TAM_PERIOD { get; set; }

    }
}
