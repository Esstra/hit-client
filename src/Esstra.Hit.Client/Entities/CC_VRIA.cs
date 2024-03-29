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
    /// CC-Kontrolle nach ViehVerkV - Rinder, Anlage 1 Einzeltier
    /// </summary>
    [Entity("CC_VRIA")]
    public class CC_VRIA
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
        /// Gets the value of "Meldedatum".
        /// </summary>
        /// <remarks>
        /// Datum des Meldeeingang
        /// </remarks>
        [Column("MELD_DAT")]
        public DateOnly? MELD_DAT { get; set; }

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
        /// Gets or sets the value of "Jahr der Risikoanalyse (Kontrolljahr)".
        /// </summary>
        /// <remarks>
        /// Jahresangabe, vierstellig
        /// </remarks>
        [Column("RIS_JAHR")]
        [Required]
        public int? RIS_JAHR { get; set; }

        /// <summary>
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Anlage 1 Spalte 10".
        /// </summary>
        /// <remarks>
        /// Prüfung Rasse (Feststellung am Tier)
        /// </remarks>
        [Column("VOK_A1S10")]
        public int? VOK_A1S10 { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Anlage 1 Spalte 11".
        /// </summary>
        /// <remarks>
        /// Prüfung Kennzeichnung (Akten im Betrieb)
        /// </remarks>
        [Column("VOK_A1S11")]
        public int? VOK_A1S11 { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Anlage 1 Spalte 12".
        /// </summary>
        /// <remarks>
        /// Prüfung Bestandsregister (Akten im Betrieb)
        /// </remarks>
        [Column("VOK_A1S12")]
        public int? VOK_A1S12 { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Anlage 1 Spalte 13".
        /// </summary>
        /// <remarks>
        /// Prüfung Begleitpapier oder Pass (Akten im Betrieb)
        /// </remarks>
        [Column("VOK_A1S13")]
        public int? VOK_A1S13 { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Anlage 1 Spalte 14".
        /// </summary>
        /// <remarks>
        /// Prüfung Datenbankabgleich (Datenbank)
        /// </remarks>
        [Column("VOK_A1S14")]
        public int? VOK_A1S14 { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Anlage 1 Spalte 7".
        /// </summary>
        /// <remarks>
        /// Prüfung Kennzeichnung (Feststellung am Tier)
        /// </remarks>
        [Column("VOK_A1S7")]
        public int? VOK_A1S7 { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Anlage 1 Spalte 8".
        /// </summary>
        /// <remarks>
        /// Prüfung Angaben zum Alter (Feststellung am Tier)
        /// </remarks>
        [Column("VOK_A1S8")]
        public int? VOK_A1S8 { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Anlage 1 Spalte 9".
        /// </summary>
        /// <remarks>
        /// Prüfung Geschecht (Feststellung am Tier)
        /// </remarks>
        [Column("VOK_A1S9")]
        public int? VOK_A1S9 { get; set; }

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
        /// Gets the value of "Stornomitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung storniert hat
        /// </remarks>
        [Column("STRN_MBN")]
        public int? STRN_MBN { get; set; }

        /// <summary>
        /// Gets the value of "Stornobetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung storniert hat
        /// </remarks>
        [Column("STRN_BNR")]
        public decimal? STRN_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Anlage 1 Spalte Zusatz".
        /// </summary>
        [Column("VOK_A1SZ")]
        public int? VOK_A1SZ { get; set; }

    }
}
