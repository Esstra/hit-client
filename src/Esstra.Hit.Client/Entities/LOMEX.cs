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
    /// LOM-Exchange, für Dummies anstelle nicht speicherbarer Ohrmarke
    /// </summary>
    [Entity("LOMEX")]
    public class LOMEX
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
        /// Gets or sets the value of "Datum".
        /// </summary>
        /// <remarks>
        /// Stichtag oder Vorgangsdatum
        /// </remarks>
        [Column("DATUM")]
        [Required]
        public DateOnly? DATUM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Entity".
        /// </summary>
        [Column("ENTITY")]
        [Required]
        public string? ENTITY { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ersetz-Bemerkung".
        /// </summary>
        /// <remarks>
        /// Bemerkung warum Ersetzung notwendig war
        /// </remarks>
        [Column("EX_BEMERK")]
        [Required]
        public string? EX_BEMERK { get; set; }

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
        /// Gets or sets the value of "Ersetzte-Ohrmarke".
        /// </summary>
        /// <remarks>
        /// Orginalform der Ohrmarke
        /// </remarks>
        [Column("LOM_E")]
        [Required]
        public string? LOM_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Data-Timestamp von".
        /// </summary>
        /// <remarks>
        /// SYS_VON des Datensatzes
        /// </remarks>
        [Column("DATA_VON")]
        [Required]
        public DateTime? DATA_VON { get; set; }

    }
}
