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
    /// Ersterfassung (nur lesend, insbes. für Kalbung)
    /// </summary>
    [Entity("ERSTERFK")]
    public class ERSTERFK
    {
        /// <summary>
        /// Gets or sets the value of "Geburtsdatum".
        /// </summary>
        /// <remarks>
        /// Geburtsdatum Rind
        /// </remarks>
        [Column("GEB_DATR")]
        [Required]
        public DateOnly? GEB_DATR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geschlecht".
        /// </summary>
        /// <remarks>
        /// Geschlecht Rind
        /// </remarks>
        [Column("GESCHL_R")]
        [Required]
        public int? GESCHL_R { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ursprungsstaat".
        /// </summary>
        /// <remarks>
        /// Staat aus dem das Tier direkt kommt
        /// </remarks>
        [Column("LAND_URS")]
        public int? LAND_URS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Rasse".
        /// </summary>
        /// <remarks>
        /// Rasse laut ADR-Schlüssel
        /// </remarks>
        [Column("RASSE")]
        [Required]
        public int? RASSE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Mutter".
        /// </summary>
        /// <remarks>
        /// Ohrmarkennummer Muttertier
        /// </remarks>
        [Column("LOM_MUT")]
        public decimal? LOM_MUT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohrmarke".
        /// </summary>
        /// <remarks>
        /// IDENTIFICATION NUMBER
        /// </remarks>
        [Column("LOM")]
        [Required]
        public decimal? LOM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Alpha-Ohrmarke Mutter".
        /// </summary>
        /// <remarks>
        /// alte alphanumerische Ohrmarke der Mutter
        /// </remarks>
        [Column("LOM_MUTA")]
        public string? LOM_MUTA { get; set; }

        /// <summary>
        /// Gets or sets the value of "alte Alfa-Ohrmarke".
        /// </summary>
        [Column("LOM_A")]
        public string? LOM_A { get; set; }

        /// <summary>
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

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
        /// Gets or sets the value of "Geburtsbetrieb".
        /// </summary>
        /// <remarks>
        /// Geburtsbetrieb bei Ersterfassungssatz
        /// </remarks>
        [Column("BNR15_GEB")]
        public decimal? BNR15_GEB { get; set; }

        /// <summary>
        /// Gets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets the value of "Satzstatus".
        /// </summary>
        /// <remarks>
        /// Systemstatus des Satzes
        /// </remarks>
        [Column("SYS_STAT")]
        public int? SYS_STAT { get; set; }

    }
}
