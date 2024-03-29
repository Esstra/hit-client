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
    /// Meldungen-Elemente
    /// </summary>
    [Entity("MELD_ELE")]
    public class MELD_ELE
    {
        /// <summary>
        /// Gets or sets the value of "Bemerkung".
        /// </summary>
        [Column("BEMERKUNG")]
        public string? BEMERKUNG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Entity".
        /// </summary>
        [Column("ENTITY")]
        [Required]
        public string? ENTITY { get; set; }

        /// <summary>
        /// Gets or sets the value of "Feldname".
        /// </summary>
        [Column("FELDNAME")]
        [Required]
        public string? FELDNAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Feldnr".
        /// </summary>
        [Column("FELDNR")]
        [Required]
        public int? FELDNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Prompt".
        /// </summary>
        [Column("PROMPT")]
        public string? PROMPT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Required".
        /// </summary>
        [Column("REQUIRED")]
        [Required]
        public string? REQUIRED { get; set; }

    }
}
