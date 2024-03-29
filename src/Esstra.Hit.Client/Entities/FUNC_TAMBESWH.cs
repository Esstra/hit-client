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
    /// Abgleich Bestandsregister Schweine mit TAM-Nutzungsart
    /// </summary>
    [Entity("FUNC_TAMBESWH")]
    public class FUNC_TAMBESWH
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
        /// Gets or sets the value of "Aktion zur Korrektur TAM-Nutzungsartmeldung".
        /// </summary>
        [Column("TAMH_AKT")]
        public int? TAMH_AKT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Endezeitpunkt Nutzungsart".
        /// </summary>
        [Column("TAMH_BIS")]
        public DateTime? TAMH_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginndatum der Periode für Nutzungsart".
        /// </summary>
        [Column("TAMH_DAT")]
        public DateOnly? TAMH_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nutzungsart (nach § 58a AMG)".
        /// </summary>
        [Column("TAMH_FORM")]
        public int? TAMH_FORM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nutzungsart, Istwert laut aktueller TAM-Meldung".
        /// </summary>
        /// <remarks>
        /// siehe TAMS_HALT
        /// </remarks>
        [Column("TAMH_IST")]
        public int? TAMH_IST { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nutzungsart, Istwert laut aktueller TAM-Meldung, differenziert Pflicht/freiwillig".
        /// </summary>
        [Column("TAMH_ISTPF")]
        public int? TAMH_ISTPF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nutzungsart, Sollwert laut Register".
        /// </summary>
        [Column("TAMH_SOLL")]
        public bool? TAMH_SOLL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginnzeitpunkt Nutzungsart".
        /// </summary>
        [Column("TAMH_VON")]
        public DateTime? TAMH_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kalenderhalbjahr".
        /// </summary>
        [Column("TAM_PERIOD")]
        public int? TAM_PERIOD { get; set; }

    }
}
