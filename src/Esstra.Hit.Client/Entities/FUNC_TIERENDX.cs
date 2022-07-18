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
    /// Tierende-Daten (extended, ohne Anzeigeeinschränkung)
    /// </summary>
    [Entity("FUNC_TIERENDX")]
    public class FUNC_TIERENDX
    {
        /// <summary>
        /// Gets or sets the value of "Tierendedatum".
        /// </summary>
        /// <remarks>
        /// Datum der Schlachtung, Verendung oder Ausfuhr
        /// </remarks>
        [Column("DAT_END")]
        public DateOnly? DAT_END { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ende-Betrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Endebetriebes im Tierende
        /// </remarks>
        [Column("BNR15_EB")]
        public decimal? BNR15_EB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ende-Betrieb (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Endebetriebes im Tierende
        /// </remarks>
        [Column("BNR15_EBX")]
        public string? BNR15_EBX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schlachtnummer".
        /// </summary>
        /// <remarks>
        /// Schlachtnr. des Schlachtbetriebes
        /// </remarks>
        [Column("SCHL_NR")]
        public decimal? SCHL_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tier-Ende".
        /// </summary>
        /// <remarks>
        /// Tier-Ende Tod (differenziert!), Schlachtung ...
        /// </remarks>
        [Column("TIER_END")]
        public int? TIER_END { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schlachtgewicht".
        /// </summary>
        /// <remarks>
        /// Gewicht des Schlachtkörpers
        /// </remarks>
        [Column("SCHL_GEW")]
        public decimal? SCHL_GEW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kategorie".
        /// </summary>
        /// <remarks>
        /// Kategorie des Schlachtkörpers
        /// </remarks>
        [Column("SCHL_KAT")]
        public int? SCHL_KAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kategorie (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Kategorie  i.d.F XX
        /// </remarks>
        [Column("SCHL_KATX")]
        public string? SCHL_KATX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tier-Ende (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Tier-Ende i.d.F XX
        /// </remarks>
        [Column("TIER_ENDX")]
        public string? TIER_ENDX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Lebendgewicht".
        /// </summary>
        /// <remarks>
        /// Lebendgewicht vor Schlachtung
        /// </remarks>
        [Column("SCHL_LEB")]
        public decimal? SCHL_LEB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohrmarke".
        /// </summary>
        /// <remarks>
        /// IDENTIFICATION NUMBER
        /// </remarks>
        [Column("LOM")]
        public decimal? LOM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohrmarke Tier (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// nur in Funktionen, wenn der Benutzer keine Möglichkeit hat ALPHALOM selber aufzurufen)
        /// </remarks>
        [Column("LOM_X")]
        public string? LOM_X { get; set; }

    }
}
