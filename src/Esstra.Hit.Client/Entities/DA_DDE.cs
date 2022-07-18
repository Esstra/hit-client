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
    /// Data-Dictionary (ADIS) View MELDUNGEN
    /// </summary>
    [Entity("DA_DDE")]
    public class DA_DDE
    {
        /// <summary>
        /// Gets or sets the value of "Name in Kurzform".
        /// </summary>
        /// <remarks>
        /// Name in Kurzform für Adressfenster
        /// </remarks>
        [Column("NAME")]
        public string? NAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Data-Dictionary Spezifikation".
        /// </summary>
        /// <remarks>
        /// für ADIS ADED
        /// </remarks>
        [Column("DDSPEZ")]
        public string? DDSPEZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "DDE".
        /// </summary>
        [Column("DDE")]
        public string? DDE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beschreib".
        /// </summary>
        [Column("BESCHREIB")]
        public string? BESCHREIB { get; set; }

    }
}