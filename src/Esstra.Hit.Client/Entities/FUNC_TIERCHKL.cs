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
    /// Tier-Check, eingeschränkte Prüfung von Rindern für beauftragte Stellen
    /// </summary>
    [Entity("FUNC_TIERCHKL")]
    public class FUNC_TIERCHKL
    {
        /// <summary>
        /// Gets or sets the value of "Ergebnis der Prüfung für Tier-Check".
        /// </summary>
        [Column("CHK_ERGEB")]
        [Required]
        public int? CHK_ERGEB { get; set; }

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
        /// Gets or sets the value of "Ohrmarke Tier (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// nur in Funktionen, wenn der Benutzer keine Möglichkeit hat ALPHALOM selber aufzurufen)
        /// </remarks>
        [Column("LOM_X")]
        [Required]
        public string? LOM_X { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum der Prüfung für Tier-Check".
        /// </summary>
        [Column("CHK_DATUM")]
        [Required]
        public DateOnly? CHK_DATUM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum des Zugangs bei erster Sammelstelle für Tier-Check".
        /// </summary>
        [Column("CHK_DAT_ES")]
        [Required]
        public DateOnly? CHK_DAT_ES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum des Zugangs für Tier-Check".
        /// </summary>
        [Column("CHK_DAT_ZU")]
        [Required]
        public DateOnly? CHK_DAT_ZU { get; set; }

    }
}
