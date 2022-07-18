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
    /// CC-Kontrolle Anhang, binäres Objekt
    /// </summary>
    [Entity("CC_BLOB")]
    public class CC_BLOB
    {
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
        /// Gets or sets the value of "Betriebsnummer des Unternehmens für Cross-Compliance".
        /// </summary>
        /// <remarks>
        /// Antragsteller-Registriernummer
        /// </remarks>
        [Column("BNR15_UNCC")]
        [Required]
        public decimal? BNR15_UNCC { get; set; }

        /// <summary>
        /// Gets or sets the value of "Speicher für das binäre Objekt".
        /// </summary>
        /// <remarks>
        /// für binäre Daten (max. 5 MB)
        /// </remarks>
        [Column("CCB_BLOBX")]
        [Required]
        public string? CCB_BLOBX { get; set; }

        /// <summary>
        /// Gets or sets the value of "internes Aktenzeichen/Aktenbetreff bei der CC-Fachüberwachungsbehörde".
        /// </summary>
        [Column("CCB_INTERN")]
        [Required]
        public string? CCB_INTERN { get; set; }

        /// <summary>
        /// Gets or sets the value of "CC-Standard, zu dem das binäre Objekt gehört".
        /// </summary>
        [Column("CCB_STD")]
        [Required]
        public int? CCB_STD { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum und Zeit, Erstellung".
        /// </summary>
        [Column("FILE_CREA")]
        public DateTime? FILE_CREA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Dateidatum und Zeit".
        /// </summary>
        [Column("FILE_DATE")]
        public DateTime? FILE_DATE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beschreibung zum Dateiinhalt, Bemerkungen".
        /// </summary>
        [Column("FILE_DESC")]
        [Required]
        public string? FILE_DESC { get; set; }

        /// <summary>
        /// Gets or sets the value of "Änderungsdatum und Zeit".
        /// </summary>
        [Column("FILE_MODI")]
        public DateTime? FILE_MODI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Dateiname, ohne Pfad".
        /// </summary>
        [Column("FILE_NAME")]
        [Required]
        public string? FILE_NAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Dateigröße (in Bytes)".
        /// </summary>
        [Column("FILE_SIZE")]
        public Int64? FILE_SIZE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Dateityp, Namenserweiterung".
        /// </summary>
        /// <remarks>
        /// i.d.R. 3 oder 4 Stellen, wie DOC oder DOCX
        /// </remarks>
        [Column("FILE_TYPE")]
        public string? FILE_TYPE { get; set; }

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
        /// Gets or sets the value of "Jahr der Risikoanalyse (Kontrolljahr)".
        /// </summary>
        /// <remarks>
        /// Jahresangabe, vierstellig
        /// </remarks>
        [Column("RIS_JAHR")]
        [Required]
        public int? RIS_JAHR { get; set; }

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
        /// Gets or sets the value of "VOK Datum".
        /// </summary>
        /// <remarks>
        /// Datum der Vor-Ort-Kontrolle
        /// </remarks>
        [Column("VOK_DAT")]
        [Required]
        public DateOnly? VOK_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "laufende Nummer des Objekts innerhalb der Kontrolle".
        /// </summary>
        [Column("CCB_NR")]
        [Required]
        public int? CCB_NR { get; set; }

    }
}
