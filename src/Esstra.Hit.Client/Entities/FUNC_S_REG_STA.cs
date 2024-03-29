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
    /// Schweinebestandsregister Statistikfunktion
    /// </summary>
    [Entity("FUNC_S_REG_STA")]
    public class FUNC_S_REG_STA
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
        /// Gets or sets the value of "Anzahl Tage".
        /// </summary>
        [Column("DAT_TAGE")]
        public Int64? DAT_TAGE { get; set; }

        /// <summary>
        /// Gets or sets the value of "VON-Datum".
        /// </summary>
        /// <remarks>
        /// Unter-Grenze für Abfragefunktionen
        /// </remarks>
        [Column("DAT_VON")]
        public DateOnly? DAT_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Schweine abgegangen".
        /// </summary>
        [Column("SB_ANZ_AB")]
        public Int64? SB_ANZ_AB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Schweine am Ende".
        /// </summary>
        [Column("SB_ANZ_END")]
        public Int64? SB_ANZ_END { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Schweine zu Beginn".
        /// </summary>
        [Column("SB_ANZ_STA")]
        public Int64? SB_ANZ_STA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Schweine verendet".
        /// </summary>
        [Column("SB_ANZ_TO")]
        public Int64? SB_ANZ_TO { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Tiertage Schweine".
        /// </summary>
        [Column("SB_ANZ_TT")]
        public Int64? SB_ANZ_TT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Schweine zugegangen".
        /// </summary>
        [Column("SB_ANZ_ZU")]
        public Int64? SB_ANZ_ZU { get; set; }

        /// <summary>
        /// Gets or sets the value of "durchschnittliche Anzahl Schweine".
        /// </summary>
        [Column("SB_AVG")]
        public decimal? SB_AVG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anteil verendet pro Zugang".
        /// </summary>
        [Column("SB_TO_ANT")]
        public decimal? SB_TO_ANT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tiergruppe".
        /// </summary>
        /// <remarks>
        /// Tiergruppe Schweine
        /// </remarks>
        [Column("SB_TRG")]
        public int? SB_TRG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tiergruppe (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Tiergruppe Schweine für Ausgabe i.d.F  1,RBT
        /// </remarks>
        [Column("SB_TRG_X")]
        public string? SB_TRG_X { get; set; }

        /// <summary>
        /// Gets or sets the value of "durchschnittliche Verweildauer".
        /// </summary>
        [Column("SB_VW_DAU")]
        public decimal? SB_VW_DAU { get; set; }

        /// <summary>
        /// Gets or sets the value of "Verhältnis Zugang zu Bestand".
        /// </summary>
        [Column("SB_ZB_VER")]
        public decimal? SB_ZB_VER { get; set; }

    }
}
