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
    /// Flächenabgleich, Änderungen und Neuberechnungen (intern)
    /// </summary>
    [Entity("ZF_CHECK")]
    public class ZF_CHECK
    {
        /// <summary>
        /// Gets or sets the value of "Bewirtschaftungsland".
        /// </summary>
        [Column("BEWIR_LAND")]
        [Required]
        public int? BEWIR_LAND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zeitpunkt der letzen Ausführung des Abgleichs/Checks".
        /// </summary>
        /// <remarks>
        /// Timestamp der letzten Ausführung des Abgleichs, 1.1.1990 noch nie
        /// </remarks>
        [Column("CK_TS_DONE")]
        [Required]
        public DateTime? CK_TS_DONE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Letzter Zeitpunkt seit wann Abgleich/Check nötig".
        /// </summary>
        /// <remarks>
        /// Timestamp der letzten Änderung zugrunde liegender Daten
        /// </remarks>
        [Column("CK_TS_NEED")]
        [Required]
        public DateTime? CK_TS_NEED { get; set; }

        /// <summary>
        /// Gets or sets the value of "Flächenidentifikator".
        /// </summary>
        /// <remarks>
        /// einheitlicher Schlüssel zur Identifikation einer Fläche entsprechend dem System
        /// </remarks>
        [Column("FLIK")]
        [Required]
        public string? FLIK { get; set; }

    }
}
