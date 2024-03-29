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
    /// Produktionsrichtung Milchkuhhaltung 2009
    /// </summary>
    [Entity("PROD_MH09")]
    public class PROD_MH09
    {
        /// <summary>
        /// Gets or sets the value of "Betriebsnummer des Antragstellers".
        /// </summary>
        [Column("BNR15_AS")]
        [Required]
        public decimal? BNR15_AS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Laufende Nummer des Eintrags für Antragsteller".
        /// </summary>
        /// <remarks>
        /// pro Antragsteller können mehrere Produktionsrichtungsinformationen exisitieren
        /// </remarks>
        [Column("MH09_LFNR")]
        [Required]
        public int? MH09_LFNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hierarchiestufe der Zuordnung".
        /// </summary>
        [Column("MH09_LEVEL")]
        [Required]
        public int? MH09_LEVEL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Qualitätsindikator".
        /// </summary>
        /// <remarks>
        /// alles größer 0 kann auf Probleme hinweisen
        /// </remarks>
        [Column("MH09_QUALI")]
        [Required]
        public int? MH09_QUALI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Registriernummer für Betrieb, Langform mit B.Land und Staat
        /// </remarks>
        [Column("BNR15")]
        [Required]
        public decimal? BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Früheste Gültigkeit der Milchkuhhalter-Eigenschaft".
        /// </summary>
        /// <remarks>
        /// Min. SYS_VON aus PROD_RICHT für PROD_S_MIK=1
        /// </remarks>
        [Column("MH09_MIN")]
        [Required]
        public DateTime? MH09_MIN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Maximale Gültigkeit der Milchkuhhalter-Eigenschaft".
        /// </summary>
        /// <remarks>
        /// Max. SYS_BIS aus PROD_RICHT für PROD_S_MIK=1
        /// </remarks>
        [Column("MH09_MAX")]
        [Required]
        public DateTime? MH09_MAX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Milchkuhhaltung".
        /// </summary>
        /// <remarks>
        /// Produktionsrichtung, für Statistik relevant
        /// </remarks>
        [Column("PROD_S_MIK")]
        [Required]
        public int? PROD_S_MIK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ammen- / Mutterkuhhaltung".
        /// </summary>
        /// <remarks>
        /// Produktionsrichtung, für Statistik relevant
        /// </remarks>
        [Column("PROD_S_MUK")]
        [Required]
        public int? PROD_S_MUK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ammen- / Mutterkuhhaltung, irgendwann".
        /// </summary>
        /// <remarks>
        /// war Produktionsrichtung PROD_S_MUK=1 irgendwann vorhanden
        /// </remarks>
        [Column("MH09_MUK")]
        [Required]
        public bool? MH09_MUK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Parent-Betrieb, aus der 1.Zuordnung".
        /// </summary>
        /// <remarks>
        /// übergeordneter Betrieb auf 1.Hierarchiestufe, TYP_ZUO i.d.R. 1, 5 oder 16
        /// </remarks>
        [Column("BNR15_P1")]
        public decimal? BNR15_P1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zuordnungstyp, aus der 1.Zuordnung".
        /// </summary>
        /// <remarks>
        /// Typ der Betriebszuordnung auf 1.Hierarchiestufe, i.d.R. 1, 5 oder 16
        /// </remarks>
        [Column("TYP_ZUO_P1")]
        public int? TYP_ZUO_P1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Parent-Betrieb, aus der 2.Zuordnung".
        /// </summary>
        /// <remarks>
        /// übergeordneter Betrieb auf 2.Hierarchiestufe, TYP_ZUO i.d.R. 5 oder 16
        /// </remarks>
        [Column("BNR15_P2")]
        public decimal? BNR15_P2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zuordnungstyp, aus der 2.Zuordnung".
        /// </summary>
        /// <remarks>
        /// Typ der Betriebszuordnung auf 2.Hierarchiestufe, i.d.R. 5 oder 16
        /// </remarks>
        [Column("TYP_ZUO_P2")]
        public int? TYP_ZUO_P2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Parent-Betrieb, aus der 3.Zuordnung".
        /// </summary>
        /// <remarks>
        /// übergeordneter Betrieb auf 3.Hierarchiestufe, TYP_ZUO i.d.R. 16
        /// </remarks>
        [Column("BNR15_P3")]
        public decimal? BNR15_P3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zuordnungstyp, aus der 3.Zuordnung".
        /// </summary>
        /// <remarks>
        /// Typ der Betriebszuordnung auf 3.Hierarchiestufe, i.d.R. 16
        /// </remarks>
        [Column("TYP_ZUO_P3")]
        public int? TYP_ZUO_P3 { get; set; }

    }
}
