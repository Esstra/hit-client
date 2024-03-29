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
    /// Plausi-Prämien Jahreszuordnung
    /// </summary>
    [Entity("PLSPRMJ")]
    public class PLSPRMJ
    {
        /// <summary>
        /// Gets or sets the value of "Jahr".
        /// </summary>
        /// <remarks>
        /// Jahresangabe, vierstellig
        /// </remarks>
        [Column("JAHR")]
        [Required]
        public int? JAHR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vermarktungsart".
        /// </summary>
        /// <remarks>
        /// Vermarktungsart, z.B. im Prämienantrag
        /// </remarks>
        [Column("VERM_ART")]
        [Required]
        public int? VERM_ART { get; set; }

        /// <summary>
        /// Gets or sets the value of "PlausiNr".
        /// </summary>
        /// <remarks>
        /// (seit 06.2004 5 statt 4stellig)
        /// </remarks>
        [Column("PLAUSINR")]
        [Required]
        public int? PLAUSINR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Prämienart".
        /// </summary>
        /// <remarks>
        /// Prämienart für INVEKOS
        /// </remarks>
        [Column("PRAE_ART")]
        [Required]
        public int? PRAE_ART { get; set; }

    }
}
