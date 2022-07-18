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
    /// Vollmachtgeber Tierumsatz (vielfach, zur Umfangsprüfung Bestandsregister)
    /// </summary>
    [Entity("VGTIERUMS")]
    public class VGTIERUMS
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
        /// Gets or sets the value of "Anzahl Meldugen".
        /// </summary>
        /// <remarks>
        /// verschiedene Verwendung, u.a. Betriebsvorgänge
        /// </remarks>
        [Column("ANZ_MELD")]
        public Int64? ANZ_MELD { get; set; }

        /// <summary>
        /// Gets or sets the value of "Parent-Betrieb".
        /// </summary>
        /// <remarks>
        /// Root-Betrieb bei Zuordnung
        /// </remarks>
        [Column("BNR15_P")]
        public decimal? BNR15_P { get; set; }

    }
}