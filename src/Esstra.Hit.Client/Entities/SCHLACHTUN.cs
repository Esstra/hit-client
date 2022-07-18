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
    /// Schlachtmeldung
    /// </summary>
    [Entity("SCHLACHTUN")]
    public class SCHLACHTUN
    {
        /// <summary>
        /// Gets or sets the value of "Fettklasse".
        /// </summary>
        /// <remarks>
        /// Fettklasse Schlachtkörper
        /// </remarks>
        [Column("SCHL_FK")]
        public int? SCHL_FK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schlachtdatum".
        /// </summary>
        [Column("SCHL_DAT")]
        [Required]
        public DateOnly? SCHL_DAT { get; set; }

        /// <summary>
        /// Gets the value of "Meldedatum".
        /// </summary>
        /// <remarks>
        /// Datum des Meldeeingang
        /// </remarks>
        [Column("MELD_DAT")]
        public DateOnly? MELD_DAT { get; set; }

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
        /// Gets or sets the value of "Ohrmarke".
        /// </summary>
        /// <remarks>
        /// IDENTIFICATION NUMBER
        /// </remarks>
        [Column("LOM")]
        [Required]
        public decimal? LOM { get; set; }

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
        /// Gets the value of "Meldeweg".
        /// </summary>
        /// <remarks>
        /// Meldeweg (Post,IVR,IN...)
        /// </remarks>
        [Column("MELD_WG")]
        public int? MELD_WG { get; set; }

        /// <summary>
        /// Gets the value of "Cluster-Spalte".
        /// </summary>
        /// <remarks>
        /// Systemintern
        /// </remarks>
        [Column("SYS_CLUST")]
        public int? SYS_CLUST { get; set; }

        /// <summary>
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gewicht verworfen".
        /// </summary>
        /// <remarks>
        /// Gewicht der verworfen Teile des Schlachtkörpers
        /// </remarks>
        [Column("SCHL_VERW")]
        public decimal? SCHL_VERW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schlachtnummer".
        /// </summary>
        /// <remarks>
        /// Schlachtnr. des Schlachtbetriebes
        /// </remarks>
        [Column("SCHL_NR")]
        [Required]
        public decimal? SCHL_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Lebendgewicht".
        /// </summary>
        /// <remarks>
        /// Lebendgewicht vor Schlachtung
        /// </remarks>
        [Column("SCHL_LEB")]
        public decimal? SCHL_LEB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kategorie".
        /// </summary>
        /// <remarks>
        /// Kategorie des Schlachtkörpers
        /// </remarks>
        [Column("SCHL_KAT")]
        [Required]
        public int? SCHL_KAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Handelsklasse".
        /// </summary>
        /// <remarks>
        /// Handelsklasse Schlachtkörper
        /// </remarks>
        [Column("SCHL_HK")]
        public int? SCHL_HK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schlacht/Tötungsgrund".
        /// </summary>
        /// <remarks>
        /// Grund bei Sonderschlachtungen oder angeordneter Tötung
        /// </remarks>
        [Column("SCHL_GRND")]
        public int? SCHL_GRND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schlachtgewicht".
        /// </summary>
        /// <remarks>
        /// Gewicht des Schlachtkörpers
        /// </remarks>
        [Column("SCHL_GEW")]
        public decimal? SCHL_GEW { get; set; }

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

    }
}