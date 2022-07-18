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
    /// Abgleich Bestandsregister Schweine mit TAM-Bestand
    /// </summary>
    [Entity("FUNC_TAMBESWB")]
    public class FUNC_TAMBESWB
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
        /// Gets or sets the value of "TAM-Bestand Mastferkel oder Mastschwein".
        /// </summary>
        [Column("TAMBEST_FS")]
        public int? TAMBEST_FS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Aktion zur Korrektur TAM-Bestandsmeldung".
        /// </summary>
        [Column("TAMB_AKT")]
        public int? TAMB_AKT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Stichtag der Bestandsmeldung".
        /// </summary>
        [Column("TAMB_DAT")]
        public DateOnly? TAMB_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nutzungsart (nach § 58a AMG), erweitert".
        /// </summary>
        /// <remarks>
        /// (ggf. mit spezifischen Erweiterungen)
        /// </remarks>
        [Column("TAMB_FORM")]
        public int? TAMB_FORM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Tiere am Stichtag im Bestand, Istwert laut aktueller TAM-Meldung".
        /// </summary>
        [Column("TAMB_IST")]
        public Int64? TAMB_IST { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Tiere am Stichtag im Bestand, Sollwert laut Register".
        /// </summary>
        [Column("TAMB_SOLL")]
        public Int64? TAMB_SOLL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kalenderhalbjahr".
        /// </summary>
        [Column("TAM_PERIOD")]
        public int? TAM_PERIOD { get; set; }

    }
}
