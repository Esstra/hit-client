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
    /// CC-Kontrolle Bereich 3 Tierschutz, Anlage A Feststellungen (Statistik-View, nur aktuelle)
    /// </summary>
    [Entity("CC_TX3A2S")]
    public class CC_TX3A2S
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
        /// Gets or sets the value of "Betriebsnummer des Unternehmens für Cross-Compliance".
        /// </summary>
        /// <remarks>
        /// Antragsteller-Registriernummer
        /// </remarks>
        [Column("BNR15_UNCC")]
        [Required]
        public decimal? BNR15_UNCC { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Datum".
        /// </summary>
        /// <remarks>
        /// Datum der Vor-Ort-Kontrolle
        /// </remarks>
        [Column("VOK_DAT")]
        [Required]
        public DateOnly? VOK_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Jahr der Risikoanalyse (Kontrolljahr)".
        /// </summary>
        /// <remarks>
        /// Jahresangabe, vierstellig
        /// </remarks>
        [Column("RIS_JAHR")]
        [Required]
        public int? RIS_JAHR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tierart, Tierschutz Anlage A".
        /// </summary>
        [Column("T_XX")]
        [Required]
        public int? T_XX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Stichwort, Tierschutz".
        /// </summary>
        [Column("T_YYY")]
        [Required]
        public int? T_YYY { get; set; }

        /// <summary>
        /// Gets or sets the value of "Stichwort, Tierschutz - Gruppe".
        /// </summary>
        [Column("T_YYY_GRP")]
        [Required]
        public int? T_YYY_GRP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl verschiedener Grade".
        /// </summary>
        [Column("T_ABC_ANZ")]
        [Required]
        public Int64? T_ABC_ANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Maßnahmen".
        /// </summary>
        [Column("T_XYZ_ANZ")]
        [Required]
        public int? T_XYZ_ANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Summe Tiere".
        /// </summary>
        [Column("T_ANZ_SUM")]
        [Required]
        public Int64? T_ANZ_SUM { get; set; }

    }
}
