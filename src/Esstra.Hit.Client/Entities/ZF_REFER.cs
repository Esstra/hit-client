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
    /// Referenzflächen (1:N Detailtabelle, Flächentypbezogen)
    /// </summary>
    [Entity("ZF_REFER")]
    public class ZF_REFER
    {
        /// <summary>
        /// Gets or sets the value of "Typ der Referenzfläche".
        /// </summary>
        /// <remarks>
        /// zur Unterscheidung in Gesamtfläche und verschiedene Anteile
        /// </remarks>
        [Column("REF_FL_TYP")]
        [Required]
        public int? REF_FL_TYP { get; set; }

        /// <summary>
        /// Gets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

        /// <summary>
        /// Gets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Flächenidentifikator".
        /// </summary>
        /// <remarks>
        /// einheitlicher Schlüssel zur Identifikation einer Fläche entsprechend dem System
        /// </remarks>
        [Column("FLIK")]
        [Required]
        public string? FLIK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bewirtschafter-Mitbenutzer".
        /// </summary>
        /// <remarks>
        /// Meldemitbenutzer des zuständigen Mitarbeiters
        /// </remarks>
        [Column("BW_AMT_MBN")]
        [Required]
        public int? BW_AMT_MBN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bewirtschafter-Amt".
        /// </summary>
        /// <remarks>
        /// Registriernummer des zuständigen Amtes
        /// </remarks>
        [Column("BW_AMT_BNR")]
        [Required]
        public decimal? BW_AMT_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bodennutzungskategorie".
        /// </summary>
        [Column("BN_KAT")]
        public int? BN_KAT { get; set; }

        /// <summary>
        /// Gets the value of "Bewirtschaftungsland".
        /// </summary>
        [Column("BEWIR_LAND")]
        public int? BEWIR_LAND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Information, je nach Typ der Referenzfläche".
        /// </summary>
        [Column("REF_INF_NU")]
        public decimal? REF_INF_NU { get; set; }

        /// <summary>
        /// Gets or sets the value of "Status der Referenzfläche".
        /// </summary>
        /// <remarks>
        /// zur Abschätzung der Verlässlichkeit und Stabilität
        /// </remarks>
        [Column("REF_STATUS")]
        [Required]
        public int? REF_STATUS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art des Referenzsystems".
        /// </summary>
        [Column("REF_SYSTEM")]
        [Required]
        public int? REF_SYSTEM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ende des Referenzzeitraumes".
        /// </summary>
        /// <remarks>
        /// Datum des Endes der Gültigkeit, z.Zt. Tag & Monat auf 31.12. Beschränkt
        /// </remarks>
        [Column("REFDAT_BIS")]
        [Required]
        public DateOnly? REFDAT_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginn des Referenzzeitraumes".
        /// </summary>
        /// <remarks>
        /// Datum des Beginns der Gültigkeit, z.Zt. Tag & Monat auf 1.1. Beschränkt
        /// </remarks>
        [Column("REFDAT_VON")]
        [Required]
        public DateOnly? REFDAT_VON { get; set; }

        /// <summary>
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets the value of "Satzstatus".
        /// </summary>
        /// <remarks>
        /// Systemstatus des Satzes
        /// </remarks>
        [Column("SYS_STAT")]
        public int? SYS_STAT { get; set; }

        /// <summary>
        /// Gets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Information, je nach Typ der Referenzfläche".
        /// </summary>
        [Column("REF_INF_CH")]
        public string? REF_INF_CH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Größe der Referenzfläche".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("REF_GROESS")]
        [Required]
        public decimal? REF_GROESS { get; set; }

    }
}
