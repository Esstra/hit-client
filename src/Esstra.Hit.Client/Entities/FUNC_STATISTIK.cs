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
    /// Sitzungsstatistik
    /// </summary>
    [Entity("FUNC_STATISTIK")]
    public class FUNC_STATISTIK
    {
        /// <summary>
        /// Gets the value of "Anzahl Retrieve".
        /// </summary>
        [Column("STAT_R")]
        public Int64? STAT_R { get; set; }

        /// <summary>
        /// Gets the value of "Anzahl Rows".
        /// </summary>
        [Column("STAT_ROWS")]
        public Int64? STAT_ROWS { get; set; }

        /// <summary>
        /// Gets the value of "Anzahl Storno".
        /// </summary>
        [Column("STAT_S")]
        public Int64? STAT_S { get; set; }

        /// <summary>
        /// Gets the value of "Anzahl Update".
        /// </summary>
        [Column("STAT_U")]
        public Int64? STAT_U { get; set; }

        /// <summary>
        /// Gets the value of "Entity".
        /// </summary>
        [Column("ENTITY")]
        public string? ENTITY { get; set; }

        /// <summary>
        /// Gets the value of "Entityname".
        /// </summary>
        [Column("ENTITYNAME")]
        public string? ENTITYNAME { get; set; }

        /// <summary>
        /// Gets the value of "Anzahl Confirm/Check".
        /// </summary>
        [Column("STAT_C")]
        public Int64? STAT_C { get; set; }

        /// <summary>
        /// Gets the value of "Anzahl Delete".
        /// </summary>
        [Column("STAT_D")]
        public Int64? STAT_D { get; set; }

        /// <summary>
        /// Gets the value of "Anzahl Insert".
        /// </summary>
        [Column("STAT_I")]
        public Int64? STAT_I { get; set; }

        /// <summary>
        /// Gets the value of "Anzahl Excecute".
        /// </summary>
        [Column("STAT_X")]
        public Int64? STAT_X { get; set; }

        /// <summary>
        /// Gets the value of "Typ der Entität".
        /// </summary>
        /// <remarks>
        /// Gruppierung bez. Tier, Betrieb, Prämie ...
        /// </remarks>
        [Column("TYP")]
        public string? TYP { get; set; }

    }
}