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
    /// Data-Dictionary View CSETS inner join CODES
    /// </summary>
    [Entity("D_CSET_COD")]
    public class D_CSET_COD
    {
        /// <summary>
        /// Gets or sets the value of "Setname".
        /// </summary>
        /// <remarks>
        /// Name des Codesets
        /// </remarks>
        [Column("SETNAME")]
        public string? SETNAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Codetext".
        /// </summary>
        /// <remarks>
        /// Text zum Code
        /// </remarks>
        [Column("CODETEXT")]
        public string? CODETEXT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Codeset".
        /// </summary>
        /// <remarks>
        /// Key des Codesets
        /// </remarks>
        [Column("CODESET")]
        public string? CODESET { get; set; }

        /// <summary>
        /// Gets or sets the value of "Codenr".
        /// </summary>
        /// <remarks>
        /// Numerischer Code
        /// </remarks>
        [Column("CODENR")]
        public Int64? CODENR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Alpha-Code".
        /// </summary>
        /// <remarks>
        /// alphabetischer Kurzcode
        /// </remarks>
        [Column("CODE")]
        public string? CODE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachlich gültig bis (1. Entity in View)".
        /// </summary>
        /// <remarks>
        /// fachlich gültig bis oder aktuell (31.12.2100)
        /// </remarks>
        [Column("FACH_BIS_1")]
        public DateTime? FACH_BIS_1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachlich gültig bis (2. Entity in View)".
        /// </summary>
        /// <remarks>
        /// fachlich gültig bis oder aktuell (31.12.2100)
        /// </remarks>
        [Column("FACH_BIS_2")]
        public DateTime? FACH_BIS_2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachlich gültig von (1. Entity in View)".
        /// </summary>
        /// <remarks>
        /// Timestamp ab wann der Satz fachlich gilt
        /// </remarks>
        [Column("FACH_VON_1")]
        public DateTime? FACH_VON_1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachlich gültig von (2. Entity in View)".
        /// </summary>
        /// <remarks>
        /// Timestamp ab wann der Satz fachlich gilt
        /// </remarks>
        [Column("FACH_VON_2")]
        public DateTime? FACH_VON_2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "storniert, 1.Zuordnung".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information im Teil 1 technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS_1")]
        public DateTime? SYS_BIS_1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "storniert, 2.Zuordnung".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information im Teil 2 technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS_2")]
        public DateTime? SYS_BIS_2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "gespeichert, 1.Zuordnung".
        /// </summary>
        [Column("SYS_VON_1")]
        public DateTime? SYS_VON_1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "gespeichert, 2.Zuordnung".
        /// </summary>
        [Column("SYS_VON_2")]
        public DateTime? SYS_VON_2 { get; set; }

    }
}