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
    /// Equidenpass
    /// </summary>
    [Entity("EQ_PASS")]
    public class EQ_PASS
    {
        /// <summary>
        /// Gets or sets the value of "Laufende Nummer des Equiden-Dokuments".
        /// </summary>
        /// <remarks>
        /// Laufende Nummer bei Erst- und Nachausstellung (Erstausstellungen 1, weitere Ausstellungen 2..n)
        /// </remarks>
        [Column("DOKLFN_E")]
        [Required]
        public int? DOKLFN_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Transponder-Nr".
        /// </summary>
        /// <remarks>
        /// IDENTIFICATION NUMBER, momentan beschränkt auf Equiden
        /// </remarks>
        [Column("TRNR15")]
        [Required]
        public decimal? TRNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Equidenpass Dokumentenart".
        /// </summary>
        /// <remarks>
        /// Pass-Art (Original, Duplikat, Ersatz)
        /// </remarks>
        [Column("DOKART_E")]
        [Required]
        public int? DOKART_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Aussteller des Equidenpasses".
        /// </summary>
        /// <remarks>
        /// Registriernummer der Stelle, die den Equidenpass ausgestellt hat
        /// </remarks>
        [Column("BNR15_PA_E")]
        [Required]
        public decimal? BNR15_PA_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ausstellungsdatum des Equidenpasses".
        /// </summary>
        /// <remarks>
        /// Datum der Pass-Ausstellung
        /// </remarks>
        [Column("AUS_DAT_E")]
        [Required]
        public DateOnly? AUS_DAT_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Equidennummer UELN".
        /// </summary>
        /// <remarks>
        /// Unique equestrian lifetime number (Eingabe mit DE erlaubt)
        /// </remarks>
        [Column("UELN")]
        public string? UELN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Einfuhrdatum Equide".
        /// </summary>
        [Column("EINDAT_E")]
        public DateOnly? EINDAT_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geburtsdatum Equide".
        /// </summary>
        [Column("GEBDAT_E")]
        [Required]
        public DateOnly? GEBDAT_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geburtsstaat Equide".
        /// </summary>
        /// <remarks>
        /// Geburtsstaat laut ISO-Schlüssel (Eingabe mit Buchstabencode erlaubt)
        /// </remarks>
        [Column("GEB_LAND_E")]
        [Required]
        public int? GEB_LAND_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Herkunftsstaat Equide".
        /// </summary>
        /// <remarks>
        /// Herkunftsstaat laut ISO-Schlüssel (Eingabe mit Buchstabencode erlaubt)
        /// </remarks>
        [Column("HER_LAND_E")]
        public int? HER_LAND_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art des Equiden".
        /// </summary>
        /// <remarks>
        /// spezielle Art des Equiden (Pferd, Esel, Zebra)
        /// </remarks>
        [Column("ART_E")]
        [Required]
        public int? ART_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geschlecht des Equiden".
        /// </summary>
        [Column("GESCHL_E")]
        [Required]
        public int? GESCHL_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Farbe des Equiden".
        /// </summary>
        [Column("FARBE_E")]
        [Required]
        public int? FARBE_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Implantationsstelle des Transponders".
        /// </summary>
        /// <remarks>
        /// Ort der Chip-Implantation (Standard oder abweichend)
        /// </remarks>
        [Column("TR_IMPL")]
        [Required]
        public int? TR_IMPL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Status des Equiden".
        /// </summary>
        /// <remarks>
        /// Status (nicht registriert, registriert)
        /// </remarks>
        [Column("STATUS_E")]
        [Required]
        public int? STATUS_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Eignung für den menschlichen Verzehr".
        /// </summary>
        [Column("LME_E")]
        [Required]
        public int? LME_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Registriernummer des Equidenhalters".
        /// </summary>
        [Column("BNR15_HE")]
        [Required]
        public decimal? BNR15_HE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Registriernummer des Tierarztes/Transponder-Setzers".
        /// </summary>
        /// <remarks>
        /// Tierarzt oder sonstige sachkundige Person, die Transponder gesetzt hat, ggf. Organisation mit MBN
        /// </remarks>
        [Column("BNR15_CH_E")]
        [Required]
        public decimal? BNR15_CH_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Mitbenutzerkennung des Transponder-Setzers".
        /// </summary>
        /// <remarks>
        /// ggf. Mitbenutzer einer Organisation, wie Brennmeister im Zuchtverband
        /// </remarks>
        [Column("MBN_CH_E")]
        [Required]
        public int? MBN_CH_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name des Equiden".
        /// </summary>
        [Column("TIERNAME_E")]
        public string? TIERNAME_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name des Equiden-Eigentümers".
        /// </summary>
        [Column("NAME_EI_E")]
        public string? NAME_EI_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Staat des Equiden-Eigentümers".
        /// </summary>
        /// <remarks>
        /// ISO-Kenner Staat
        /// </remarks>
        [Column("STAAT_EI_E")]
        public int? STAAT_EI_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "PLZ des Equiden-Eigentümers".
        /// </summary>
        /// <remarks>
        /// Postleitzahl
        /// </remarks>
        [Column("PLZ_EI_E")]
        public string? PLZ_EI_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Wohnort des Equiden-Eigentümers".
        /// </summary>
        /// <remarks>
        /// Ort, ggf mit Ortsteil
        /// </remarks>
        [Column("ORT_EI_E")]
        public string? ORT_EI_E { get; set; }

        /// <summary>
        /// Gets or sets the value of "Straße, Hausnummer des Equiden-Eigentümers".
        /// </summary>
        /// <remarks>
        /// Straße, Hausnummer
        /// </remarks>
        [Column("STRNR_EI_E")]
        public string? STRNR_EI_E { get; set; }

        /// <summary>
        /// Gets the value of "Meldedatum".
        /// </summary>
        /// <remarks>
        /// Datum des Meldeeingang
        /// </remarks>
        [Column("MELD_DAT")]
        public DateOnly? MELD_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Änderungsdatum des Equidenpasses".
        /// </summary>
        /// <remarks>
        /// Datum der Pass-Änderung
        /// </remarks>
        [Column("AEND_DAT_E")]
        public DateOnly? AEND_DAT_E { get; set; }

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
        /// Gets or sets the value of "Angabe über Verbleib von altem Equiden-Pass".
        /// </summary>
        [Column("EQ_PA_VERB")]
        [Required]
        public int? EQ_PA_VERB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Seriennummer des Equidenpasses".
        /// </summary>
        [Column("EQ_PA_SNR")]
        public decimal? EQ_PA_SNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weitere Transponder".
        /// </summary>
        /// <remarks>
        /// Liste, ggf. mehere Komma getrennt
        /// </remarks>
        [Column("TR_WEITERE")]
        [Required]
        public string? TR_WEITERE { get; set; }

    }
}
