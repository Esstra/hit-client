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
    /// Name und Adresse zu abgeschlossenem Zahlungs-Verkauf und -Verpachtung
    /// </summary>
    [Entity("FUNC_ZB_VX_ADR")]
    public class FUNC_ZB_VX_ADR
    {
        /// <summary>
        /// Gets or sets the value of "ZA-Abgeber-Betriebsnummer (Verkäufer oder Verpächter)".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Person bzw. InVeKoS / Unternehmen
        /// </remarks>
        [Column("ZB_V_BNR")]
        public decimal? ZB_V_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Abgeber Name in Kurzform".
        /// </summary>
        /// <remarks>
        /// Feld NAME aus Stammdaten
        /// </remarks>
        [Column("ZB_V_NAME")]
        public string? ZB_V_NAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Abgeber Name 2.Zeile".
        /// </summary>
        /// <remarks>
        /// Feld NAME aus Stammdaten
        /// </remarks>
        [Column("ZB_V_NAME2")]
        public string? ZB_V_NAME2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Abgeber Ort".
        /// </summary>
        /// <remarks>
        /// Feld ORT aus Stammdaten
        /// </remarks>
        [Column("ZB_V_ORT")]
        public string? ZB_V_ORT { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Abgeber Ortsteil".
        /// </summary>
        /// <remarks>
        /// Feld ORTSTEIL aus Stammdaten
        /// </remarks>
        [Column("ZB_V_OTEIL")]
        public string? ZB_V_OTEIL { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Abgeber PLZ".
        /// </summary>
        /// <remarks>
        /// Feld PLZ aus Stammdaten
        /// </remarks>
        [Column("ZB_V_PLZ")]
        public string? ZB_V_PLZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Abgeber Strasse Nr".
        /// </summary>
        /// <remarks>
        /// Feld NAME und NAME2 aus Stammdaten
        /// </remarks>
        [Column("ZB_V_STRNR")]
        public string? ZB_V_STRNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Übernehmer-Betriebsnummer (Käufer oder Pächter)".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Person bzw. InVeKoS / Unternehmen
        /// </remarks>
        [Column("ZB_Z_BNR")]
        public decimal? ZB_Z_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Übernehmer Name in Kurzform".
        /// </summary>
        /// <remarks>
        /// Feld NAME aus Stammdaten
        /// </remarks>
        [Column("ZB_Z_NAME")]
        public string? ZB_Z_NAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Übernehmer Name 2.Zeile".
        /// </summary>
        /// <remarks>
        /// Feld NAME aus Stammdaten
        /// </remarks>
        [Column("ZB_Z_NAME2")]
        public string? ZB_Z_NAME2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Übernehmer Ort".
        /// </summary>
        /// <remarks>
        /// Feld ORT aus Stammdaten
        /// </remarks>
        [Column("ZB_Z_ORT")]
        public string? ZB_Z_ORT { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Übernehmer Ortsteil".
        /// </summary>
        /// <remarks>
        /// Feld ORTSTEIL aus Stammdaten
        /// </remarks>
        [Column("ZB_Z_OTEIL")]
        public string? ZB_Z_OTEIL { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Übernehmer PLZ".
        /// </summary>
        /// <remarks>
        /// Feld PLZ aus Stammdaten
        /// </remarks>
        [Column("ZB_Z_PLZ")]
        public string? ZB_Z_PLZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Übernehmer Strasse Nr".
        /// </summary>
        /// <remarks>
        /// Feld NAME und NAME2 aus Stammdaten
        /// </remarks>
        [Column("ZB_Z_STRNR")]
        public string? ZB_Z_STRNR { get; set; }

    }
}
