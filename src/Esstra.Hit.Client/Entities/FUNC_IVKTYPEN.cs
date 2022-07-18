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
    /// Anzeige der IVK-Typen
    /// </summary>
    [Entity("FUNC_IVKTYPEN")]
    public class FUNC_IVKTYPEN
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
        /// Gets or sets the value of "Betrtyp gültig bis".
        /// </summary>
        /// <remarks>
        /// fachlich gültig bis oder aktuell (31.12.2100)
        /// </remarks>
        [Column("DTYP_BIS")]
        public DateTime? DTYP_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betrtyp gültig von".
        /// </summary>
        /// <remarks>
        /// Timestamp ab wann der Satz fachlich gilt
        /// </remarks>
        [Column("DTYP_VON")]
        public DateTime? DTYP_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebstyp".
        /// </summary>
        /// <remarks>
        /// Betriebstyp, Rolle für HIT, als Grundlage der Rechte und Pflichten
        /// </remarks>
        [Column("TYP_BETR")]
        public int? TYP_BETR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betreiebstyp (aufbereitet)".
        /// </summary>
        [Column("TYP_BETRX")]
        public string? TYP_BETRX { get; set; }

    }
}