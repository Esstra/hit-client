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
    /// Beantragte Flächen (1:N Detailtabelle, Flächentypbezogen)
    /// </summary>
    [Entity("ZF_ANTRAG")]
    public class ZF_ANTRAG
    {
        /// <summary>
        /// Gets or sets the value of "Information, je nach Typ der Antragsfläche".
        /// </summary>
        [Column("ANT_INF_NU")]
        public decimal? ANT_INF_NU { get; set; }

        /// <summary>
        /// Gets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Größe der festgestellten Fläche".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("FEST_GROES")]
        public decimal? FEST_GROES { get; set; }

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
        /// Gets or sets the value of "Feld-Schlag-ID Nummer".
        /// </summary>
        /// <remarks>
        /// Format noch nicht sicher (Vorschlag numerisch LONG 8stellig)
        /// </remarks>
        [Column("FS_ID_NR")]
        [Required]
        public Int64? FS_ID_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hauptbodennutzung".
        /// </summary>
        /// <remarks>
        /// laut gemeinsamer Nutzungstabelle
        /// </remarks>
        [Column("HB_NUTZ")]
        [Required]
        public int? HB_NUTZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Information, laut kontextabhängigem Codeset (von ZID festgelegt)".
        /// </summary>
        /// <remarks>
        /// bei Nutzung 75x - HOPFEN_EZG
        /// </remarks>
        [Column("SYS_CODE")]
        public int? SYS_CODE { get; set; }

        /// <summary>
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Information, je nach Typ der Antragsfläche".
        /// </summary>
        [Column("ANT_INF_CH")]
        public string? ANT_INF_CH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Größe der beantragten Fläche".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("ANT_GROESS")]
        [Required]
        public decimal? ANT_GROESS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Typ der Antragsfläche".
        /// </summary>
        /// <remarks>
        /// zur Unterscheidung in LF / LE und andere Satzarten
        /// </remarks>
        [Column("ANT_FL_TYP")]
        [Required]
        public int? ANT_FL_TYP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Antragsteller-Mitbenutzer".
        /// </summary>
        /// <remarks>
        /// Meldemitbenutzer des zuständigen Mitarbeiters
        /// </remarks>
        [Column("AN_AMT_MBN")]
        [Required]
        public int? AN_AMT_MBN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Antragsteller-Amt".
        /// </summary>
        /// <remarks>
        /// Registriernummer des zuständigen Amtes
        /// </remarks>
        [Column("AN_AMT_BNR")]
        [Required]
        public decimal? AN_AMT_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Laufende Satznummer innerhalb Antragsinformation".
        /// </summary>
        /// <remarks>
        /// Unterteilung unterhalb Feldstücks/Schlages-Identifikation zur Unterteilung der Nutz-Information
        /// </remarks>
        [Column("ANT_LFNR")]
        [Required]
        public int? ANT_LFNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ende des Antragszeitraumes".
        /// </summary>
        /// <remarks>
        /// Datum des Endes der Gültigkeit, z.Zt. Tag & Monat auf 31.12. Beschränkt
        /// </remarks>
        [Column("ANTDAT_BIS")]
        [Required]
        public DateOnly? ANTDAT_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginn des Antragszeitraumes".
        /// </summary>
        /// <remarks>
        /// Datum des Beginns der Gültigkeit, z.Zt. Tag & Monat auf 1.1. Beschränkt
        /// </remarks>
        [Column("ANTDAT_VON")]
        [Required]
        public DateOnly? ANTDAT_VON { get; set; }

        /// <summary>
        /// Gets the value of "Antragsstellungsland".
        /// </summary>
        [Column("ANTR_LAND")]
        public int? ANTR_LAND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Status des Antrags bezüglich Fehlernachprüfung".
        /// </summary>
        /// <remarks>
        /// mit Auswirkung auf weiteres Vorgehen Kollisionsprüfung
        /// </remarks>
        [Column("ANTR_STAT")]
        [Required]
        public int? ANTR_STAT { get; set; }

        /// <summary>
        /// Gets the value of "Bewirtschaftungsland".
        /// </summary>
        [Column("BEWIR_LAND")]
        public int? BEWIR_LAND { get; set; }

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
        /// Gets or sets the value of "Sorteninformation, laut kontextabhängigem Sortenschlüssel".
        /// </summary>
        /// <remarks>
        /// bei Nutzung 75x - SORTE_75x
        /// </remarks>
        [Column("SORTE")]
        public int? SORTE { get; set; }

        /// <summary>
        /// Gets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

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

    }
}
