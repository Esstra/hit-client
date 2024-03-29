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
    /// Wild-Tierfund Melde-App - Erfassung
    /// </summary>
    [Entity("WT_APP")]
    public class WT_APP
    {
        /// <summary>
        /// Gets or sets the value of "Wildursprungsmarke".
        /// </summary>
        [Column("WT_WILDURM")]
        [Required]
        public string? WT_WILDURM { get; set; }

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
        /// Gets or sets the value of "Globally Unique Identifier".
        /// </summary>
        /// <remarks>
        /// Format xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx (lower case)
        /// </remarks>
        [Column("GUID")]
        public string? GUID { get; set; }

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
        /// Gets or sets the value of "Nachname".
        /// </summary>
        /// <remarks>
        /// Nachname, inkl. Doppelnamen
        /// </remarks>
        [Column("NACHNAME")]
        [Required]
        public string? NACHNAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name in Kurzform".
        /// </summary>
        /// <remarks>
        /// Name in Kurzform für Adressfenster
        /// </remarks>
        [Column("NAME")]
        [Required]
        public string? NAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name 2.Zeile".
        /// </summary>
        /// <remarks>
        /// 2.Namenszeile für Adressfenster
        /// </remarks>
        [Column("NAME2")]
        [Required]
        public string? NAME2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ort".
        /// </summary>
        /// <remarks>
        /// Ort
        /// </remarks>
        [Column("ORT")]
        [Required]
        public string? ORT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ortsteil".
        /// </summary>
        /// <remarks>
        /// Ortsteil wenn erforderlich
        /// </remarks>
        [Column("ORTSTEIL")]
        [Required]
        public string? ORTSTEIL { get; set; }

        /// <summary>
        /// Gets or sets the value of "PLZ".
        /// </summary>
        /// <remarks>
        /// Postleitzahl, ggf. internat. ohne Staat
        /// </remarks>
        [Column("PLZ")]
        [Required]
        public string? PLZ { get; set; }

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
        /// Gets or sets the value of "Strasse Nr".
        /// </summary>
        /// <remarks>
        /// Straße und Hausnummer
        /// </remarks>
        [Column("STR_NR")]
        [Required]
        public string? STR_NR { get; set; }

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
        /// Gets or sets the value of "Vorname".
        /// </summary>
        /// <remarks>
        /// ein oder mehrere Vornamen
        /// </remarks>
        [Column("VORNAME")]
        [Required]
        public string? VORNAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Altersgruppe".
        /// </summary>
        [Column("WT_ALTGRP")]
        public int? WT_ALTGRP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kommentar / Bezeichnung für den Tierfund".
        /// </summary>
        [Column("WT_COMMENT")]
        [Required]
        public string? WT_COMMENT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Erleger/Findere Mailadresse".
        /// </summary>
        [Column("WT_EMAIL")]
        [Required]
        public string? WT_EMAIL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geschlecht".
        /// </summary>
        [Column("WT_GESCHL")]
        public int? WT_GESCHL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gewicht".
        /// </summary>
        [Column("WT_GEW")]
        public int? WT_GEW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zustand beim Wiegen".
        /// </summary>
        /// <remarks>
        /// Zustand beim Wiegen (aufgebrochen/unaufgebrochen)
        /// </remarks>
        [Column("WT_GEW_ZUS")]
        public int? WT_GEW_ZUS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum".
        /// </summary>
        /// <remarks>
        /// Datum der Erlegung / des Auffindens
        /// </remarks>
        [Column("WT_HDATE")]
        [Required]
        public DateOnly? WT_HDATE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hinweise  zum Zustand der Organe, falls diese untersucht werden".
        /// </summary>
        [Column("WT_HINWEIS")]
        [Required]
        public string? WT_HINWEIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Erleger/Finder Mobilfunknummer".
        /// </summary>
        [Column("WT_MOBIL")]
        [Required]
        public string? WT_MOBIL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Restriction Code".
        /// </summary>
        [Column("WT_RESTRIC")]
        public int? WT_RESTRIC { get; set; }

        /// <summary>
        /// Gets or sets the value of "AGS (Amtlicher Gemeindeschlüssel), Revier".
        /// </summary>
        [Column("WT_REVAGS")]
        [Required]
        public string? WT_REVAGS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gemeinde, Revier".
        /// </summary>
        [Column("WT_REVGDE")]
        [Required]
        public string? WT_REVGDE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Revier".
        /// </summary>
        [Column("WT_REVIER")]
        [Required]
        public string? WT_REVIER { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kommune, Revier".
        /// </summary>
        [Column("WT_REVKOM")]
        [Required]
        public string? WT_REVKOM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tierart".
        /// </summary>
        [Column("WT_TIERART")]
        public int? WT_TIERART { get; set; }

        /// <summary>
        /// Gets or sets the value of "Uhrzeit zum Zeitpunkt der Erfassung".
        /// </summary>
        [Column("WT_TIME")]
        [Required]
        public string? WT_TIME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Aufälligkeiten Organe".
        /// </summary>
        /// <remarks>
        /// Wurden and den Organen Auffälligkeiten festgestellt
        /// </remarks>
        [Column("WT_TODORG")]
        public int? WT_TODORG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Todesursache".
        /// </summary>
        [Column("WT_TODURS")]
        public int? WT_TODURS { get; set; }

        /// <summary>
        /// Gets or sets the value of "X-Koordinate".
        /// </summary>
        [Column("WT_X_KOORD")]
        public decimal? WT_X_KOORD { get; set; }

        /// <summary>
        /// Gets or sets the value of "Y-Koordinate".
        /// </summary>
        [Column("WT_Y_KOORD")]
        public decimal? WT_Y_KOORD { get; set; }

        /// <summary>
        /// Gets or sets the value of "Wildursprungsmarken-System".
        /// </summary>
        [Column("WT_WURMSYS")]
        [Required]
        public int? WT_WURMSYS { get; set; }

    }
}
