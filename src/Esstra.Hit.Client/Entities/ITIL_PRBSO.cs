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
    /// Problems and Solutions
    /// </summary>
    [Entity("ITIL_PRBSO")]
    public class ITIL_PRBSO
    {
        /// <summary>
        /// Gets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

        /// <summary>
        /// Gets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

        /// <summary>
        /// Gets the value of "Stornobetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung storniert hat
        /// </remarks>
        [Column("STRN_BNR")]
        public decimal? STRN_BNR { get; set; }

        /// <summary>
        /// Gets the value of "Stornomitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung storniert hat
        /// </remarks>
        [Column("STRN_MBN")]
        public int? STRN_MBN { get; set; }

        /// <summary>
        /// Gets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Problem-Solution ID; Relation zu Incident-TicketID".
        /// </summary>
        [Column("PRBSO_ID")]
        [Required]
        public Int64? PRBSO_ID { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bearbeiter des Incidents bzw. Problems".
        /// </summary>
        [Column("IN_PS_BEA")]
        [Required]
        public int? IN_PS_BEA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Problem/Lösungs Kategorie".
        /// </summary>
        [Column("PRBSO_KAT")]
        [Required]
        public int? PRBSO_KAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Status des Problems bzw. Lösung des Incidents".
        /// </summary>
        [Column("PRBSO_STA")]
        [Required]
        public int? PRBSO_STA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Auftragsnummer in der Projektverwaltung".
        /// </summary>
        /// <remarks>
        /// ggf. Querverweis zur Projektverwaltung
        /// </remarks>
        [Column("PV_AUFNR")]
        public Int64? PV_AUFNR { get; set; }

        /// <summary>
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Stichwörter zur Suche von Problem/Lösung".
        /// </summary>
        [Column("PRBSO_BTRF")]
        [Required]
        public string? PRBSO_BTRF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beschreibung von Problem/Lösung".
        /// </summary>
        [Column("PRBSO_TEXT")]
        [Required]
        public string? PRBSO_TEXT { get; set; }

    }
}
