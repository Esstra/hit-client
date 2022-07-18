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
    /// Tier Bewegung zwischen 2 Betrieben, gemeinsame Rinder
    /// </summary>
    [Entity("TIERBETR2")]
    public class TIERBETR2
    {
        /// <summary>
        /// Gets or sets the value of "Data-Timestamp von".
        /// </summary>
        /// <remarks>
        /// SYS_VON des Datensatzes
        /// </remarks>
        [Column("DATA_VON")]
        [Required]
        public DateTime? DATA_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Data-Timestamp von (2.Betrieb)".
        /// </summary>
        /// <remarks>
        /// SYS_VON des Datensatzes
        /// </remarks>
        [Column("DATA_VON_2")]
        [Required]
        public DateTime? DATA_VON_2 { get; set; }

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
        /// Gets or sets the value of "wahrscheinliche Richtung der Tierbewegung".
        /// </summary>
        [Column("X_BEW_RICH")]
        [Required]
        public int? X_BEW_RICH { get; set; }

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
        /// Gets or sets the value of "Betriebsnummer (2. im Verbund)".
        /// </summary>
        /// <remarks>
        /// z.B. aus Kollisionsantrag oder Verbund
        /// </remarks>
        [Column("BNR15_2")]
        [Required]
        public decimal? BNR15_2 { get; set; }

    }
}
