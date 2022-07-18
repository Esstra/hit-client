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
    /// Geburtsmeldung (zur Betriebsstätte)
    /// </summary>
    [Entity("BSGEBURT")]
    public class BSGEBURT
    {
        /// <summary>
        /// Gets or sets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Cluster-Spalte".
        /// </summary>
        /// <remarks>
        /// Systemintern
        /// </remarks>
        [Column("SYS_CLUST")]
        public int? SYS_CLUST { get; set; }

        /// <summary>
        /// Gets the value of "Satzstatus".
        /// </summary>
        /// <remarks>
        /// Systemstatus des Satzes
        /// </remarks>
        [Column("SYS_STAT")]
        public int? SYS_STAT { get; set; }

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
        /// Gets or sets the value of "Parent-Betrieb".
        /// </summary>
        /// <remarks>
        /// Root-Betrieb bei Zuordnung
        /// </remarks>
        [Column("BNR15_P")]
        [Required]
        public decimal? BNR15_P { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zuordnung gültig bis".
        /// </summary>
        /// <remarks>
        /// fachlich gültig bis oder aktuell (31.12.2100)
        /// </remarks>
        [Column("DZUO_BIS")]
        [Required]
        public DateTime? DZUO_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zuordnung gültig von".
        /// </summary>
        /// <remarks>
        /// Timestamp ab wann der Satz fachlich gilt
        /// </remarks>
        [Column("DZUO_VON")]
        [Required]
        public DateTime? DZUO_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Embryotransfer".
        /// </summary>
        /// <remarks>
        /// Kalb aus Embryotransfer 0/1
        /// </remarks>
        [Column("ET_KALB")]
        public int? ET_KALB { get; set; }

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
        /// Gets or sets the value of "Verbleib".
        /// </summary>
        /// <remarks>
        /// Verbleib des Kalbes
        /// </remarks>
        [Column("VERBLEIB")]
        public int? VERBLEIB { get; set; }

        /// <summary>
        /// Gets or sets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geburtsverlauf".
        /// </summary>
        /// <remarks>
        /// Geburtsverlauf
        /// </remarks>
        [Column("GEB_VERL")]
        public int? GEB_VERL { get; set; }

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
        /// Gets or sets the value of "Kennzeichnungsart".
        /// </summary>
        /// <remarks>
        /// Art der Kennzeichnung LOM, Sender ...
        /// </remarks>
        [Column("KENZ_ART")]
        public int? KENZ_ART { get; set; }

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
        /// Gets or sets the value of "Mutter".
        /// </summary>
        /// <remarks>
        /// Ohrmarkennummer Muttertier
        /// </remarks>
        [Column("LOM_MUT")]
        [Required]
        public decimal? LOM_MUT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Mehrling (LKV)".
        /// </summary>
        /// <remarks>
        /// Mehrling für LKV-Angaben, nach ADR 1=Einling, 2=Zwilling …
        /// </remarks>
        [Column("MEHRLADR")]
        public int? MEHRLADR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Mehrling".
        /// </summary>
        /// <remarks>
        /// Mehrling nach VVVO / HIT  0=Nein, 1=Ja
        /// </remarks>
        [Column("MEHRLING")]
        public int? MEHRLING { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldedatum".
        /// </summary>
        /// <remarks>
        /// Datum des Meldeeingang
        /// </remarks>
        [Column("MELD_DAT")]
        public DateOnly? MELD_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldeweg".
        /// </summary>
        /// <remarks>
        /// Meldeweg (Post,IVR,IN...)
        /// </remarks>
        [Column("MELD_WG")]
        public int? MELD_WG { get; set; }

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
        /// Gets or sets the value of "Festliegen".
        /// </summary>
        /// <remarks>
        /// Festliegen (Milchfieber) des Muttertieres
        /// </remarks>
        [Column("GEB_FEST")]
        public int? GEB_FEST { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nabelbruch".
        /// </summary>
        /// <remarks>
        /// Nabelbruch beim Kalb vorhanden ja/nein
        /// </remarks>
        [Column("GEB_NABBR")]
        public int? GEB_NABBR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nachgeburtsverhaltung".
        /// </summary>
        /// <remarks>
        /// Nachgeburtsverhaltung beim Muttertier vorhanden ja/nein
        /// </remarks>
        [Column("GEB_NAGEBV")]
        public int? GEB_NAGEBV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tiername".
        /// </summary>
        /// <remarks>
        /// Tiername landesweise nach Liste oder für einzelne Länder freie Eingabe
        /// </remarks>
        [Column("TIERNAME")]
        public string? TIERNAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tiernamen-Nummer".
        /// </summary>
        /// <remarks>
        /// Tiername landesweise numrisch codiert oder 0 für freie Eingabe
        /// </remarks>
        [Column("TIERNAMENR")]
        public Int64? TIERNAMENR { get; set; }

    }
}