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
    /// Zahlungsansprüche V2, Änderungen an ZA zu Betrieben und ZA-Serien
    /// </summary>
    [Entity("ZB_BETR_ZA")]
    public class ZB_BETR_ZA
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
        /// Gets or sets the value of "Data-Timestamp von".
        /// </summary>
        /// <remarks>
        /// SYS_VON des Datensatzes
        /// </remarks>
        [Column("DATA_VON")]
        [Required]
        public DateTime? DATA_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlungsanspruchs-Land".
        /// </summary>
        /// <remarks>
        /// Land das den ZA ausgegeben hat. Dient mit Serie und Nr zur Identifikation.
        /// </remarks>
        [Column("ZB_LAND")]
        [Required]
        public int? ZB_LAND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Serie".
        /// </summary>
        /// <remarks>
        /// Seriennummer des Zahlungsanspruchs als 1. Teil der Identifikation
        /// </remarks>
        [Column("ZB_SERIE")]
        [Required]
        public Int64? ZB_SERIE { get; set; }

    }
}
