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
    /// CC-Kontrolle Anlage 1 zu Anhang III und Vogelschutz
    /// </summary>
    [Entity("CC_AN_A3VO")]
    public class CC_AN_A3VO
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
        /// Gets or sets the value of "VOK Datum".
        /// </summary>
        /// <remarks>
        /// Datum der Vor-Ort-Kontrolle
        /// </remarks>
        [Column("VOK_DAT")]
        [Required]
        public DateOnly? VOK_DAT { get; set; }

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
        /// Gets or sets the value of "Schlagnummer".
        /// </summary>
        /// <remarks>
        /// Schlagnummer (aus Antragsdaten des Kontrolljahres)
        /// </remarks>
        [Column("AN_SCHL_NR")]
        [Required]
        public Int64? AN_SCHL_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "neue Schlagnummer".
        /// </summary>
        /// <remarks>
        /// neue Schlagnummer ((aus Antragsdaten des Kontrolljahres)
        /// </remarks>
        [Column("AN_SCHL_NW")]
        public Int64? AN_SCHL_NW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Karten-Nr.".
        /// </summary>
        /// <remarks>
        /// Karten-Nr.  (aus Antragsdaten des Kontrolljahres)
        /// </remarks>
        [Column("AN_KART_NR")]
        public Int64? AN_KART_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "FLIK".
        /// </summary>
        /// <remarks>
        /// FLIK  (aus Antragsdaten des Kontrolljahres)
        /// </remarks>
        [Column("AN_FLIK")]
        public string? AN_FLIK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schlaggröße".
        /// </summary>
        /// <remarks>
        /// Schlaggröße (aus Antragsdaten des Kontrolljahres)
        /// </remarks>
        [Column("AN_SCHL_GR")]
        public decimal? AN_SCHL_GR { get; set; }

        /// <summary>
        /// Gets or sets the value of "LE vorhanden".
        /// </summary>
        /// <remarks>
        /// Lanschaftselemente vorhanden (aus Antragsdaten des Kontrolljahres)
        /// </remarks>
        [Column("AN_LE_VOR")]
        public bool? AN_LE_VOR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nutzungscode".
        /// </summary>
        /// <remarks>
        /// Nutzungscode  (aus Antragsdaten des Kontrolljahres)
        /// </remarks>
        [Column("AN_NC_ANTR")]
        public int? AN_NC_ANTR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Erosionsgefährdungsstufe".
        /// </summary>
        /// <remarks>
        /// Erosionsgefährdungsstufe (Erosionsschutz)
        /// </remarks>
        [Column("AN_ERO_STU")]
        public int? AN_ERO_STU { get; set; }

        /// <summary>
        /// Gets or sets the value of "Aktueller Flächenzustand, bis 2013 Angabe Landwirt".
        /// </summary>
        /// <remarks>
        /// Angabe Landwirt zum Flächenzustand (Erosionsschutz)
        /// </remarks>
        [Column("AN_ANGAB_L")]
        public string? AN_ANGAB_L { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe bestätigt ja/nein".
        /// </summary>
        /// <remarks>
        /// Angabe bestätigt (Erosionsschutz)
        /// </remarks>
        [Column("AN_ANGA_BE")]
        public bool? AN_ANGA_BE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Verpflichtungen eingehalten ja/nein/nicht geprüft".
        /// </summary>
        /// <remarks>
        /// Verpflichtungen eingehalten (Erosionsschutz)
        /// </remarks>
        [Column("AN_VER_OK")]
        public int? AN_VER_OK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Antragsangaben bestätigt".
        /// </summary>
        /// <remarks>
        /// Antragsangaben bestätigt (Anbauverhältnis/organische Substanz)
        /// </remarks>
        [Column("AN_ANT_BE")]
        public bool? AN_ANT_BE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tatsächlich festgestellter Nutzungscode".
        /// </summary>
        /// <remarks>
        /// Tatsächlich festgestellter Nutzungscode (Anbauverhältnis/organische Substanz)
        /// </remarks>
        [Column("AN_NC_TAT")]
        public int? AN_NC_TAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Einhaltung der Schutzperiode ja/nein".
        /// </summary>
        /// <remarks>
        /// Einhaltung der Schutzperiode (aus der Erzeugung genommene Flächen)
        /// </remarks>
        [Column("AN_SCHZ_OK")]
        public bool? AN_SCHZ_OK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Begrünung auf Ackerland vorhanden ja/nein".
        /// </summary>
        /// <remarks>
        /// Begrünung auf Ackerland vorhanden (aus der Erzeugung genommene Flächen)
        /// </remarks>
        [Column("AN_AKL_GRU")]
        public bool? AN_AKL_GRU { get; set; }

        /// <summary>
        /// Gets or sets the value of "Pflegeverpflichtung eingehalten ja/nein".
        /// </summary>
        /// <remarks>
        /// Pflegeverpflichtung eingehalten (aus der Erzeugung genommene Flächen)
        /// </remarks>
        [Column("AN_PFL_EIN")]
        public int? AN_PFL_EIN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fläche mit LE ja/nein".
        /// </summary>
        /// <remarks>
        /// Fläche mit LE (Landschafselemente)
        /// </remarks>
        [Column("AN_LE_FLA")]
        public bool? AN_LE_FLA { get; set; }

        /// <summary>
        /// Gets or sets the value of "LE teilweise oder ganz beseitigt (Anzahl)".
        /// </summary>
        /// <remarks>
        /// Anzahl Landschaftselemente teilweise oder ganz beseitigt
        /// </remarks>
        [Column("AN_LE_BES")]
        public int? AN_LE_BES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bewässerung auf Betriebsflächen ja/nein".
        /// </summary>
        /// <remarks>
        /// Bewässeung auf Betriebsflächen ja/nein (Einhaltung von Genehmigungsverfahren bei Bewässerung)
        /// </remarks>
        [Column("AN_BEW_VOR")]
        public bool? AN_BEW_VOR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Genehmigung vorhanden ja/nein".
        /// </summary>
        /// <remarks>
        /// Genehmigung vorhanden ja/nein (Einhaltung von Genehmigungsverfahren bei Bewässerung)
        /// </remarks>
        [Column("AN_GEN_VOR")]
        public bool? AN_GEN_VOR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Dauergrünland in Schutzgebieten vorhanden ja/nein".
        /// </summary>
        /// <remarks>
        /// Dauergrünland in Schutzgebieten vorhanden (Schutz von Dauergrünland in gemäß DirektZahlVerpflV)
        /// </remarks>
        [Column("AN_DGL_VOR")]
        public bool? AN_DGL_VOR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Dauergrünland umgebrochen ja/nein".
        /// </summary>
        /// <remarks>
        /// DGL ohne Genehmigung umgebrochen bzw. mit Genehmigung umgebrochen ohne Auflagen einzuhalten j/n
        /// </remarks>
        [Column("AN_DGL_UM")]
        public bool? AN_DGL_UM { get; set; }

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
        /// Gets or sets the value of "Grund für Nichteinhaltung der Pflegeverpflichtung".
        /// </summary>
        [Column("AN_PFL_MAE")]
        public int? AN_PFL_MAE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Verbot der Ausbringung PSM beachtet".
        /// </summary>
        [Column("AN_BB_PSM")]
        public bool? AN_BB_PSM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Winterkulturen und Zwischenfrüchte erhalten".
        /// </summary>
        [Column("AN_BB_WK")]
        public bool? AN_BB_WK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zwischenfrüchte und Begrünungen erhalten".
        /// </summary>
        [Column("AN_BB_ZWF")]
        public bool? AN_BB_ZWF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schnittverbot beachtet".
        /// </summary>
        [Column("AN_LE_SCH")]
        public bool? AN_LE_SCH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Verbot des Abbrennens beachtet".
        /// </summary>
        [Column("AN_ST_ST")]
        public bool? AN_ST_ST { get; set; }

        /// <summary>
        /// Gets or sets the value of "Lagerung Festmist".
        /// </summary>
        [Column("AN_LA_FE")]
        public int? AN_LA_FE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Lagerung Silage".
        /// </summary>
        [Column("AN_LA_SI")]
        public int? AN_LA_SI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schutz von Flächen".
        /// </summary>
        [Column("AN_SCHZ_FL")]
        public int? AN_SCHZ_FL { get; set; }

    }
}