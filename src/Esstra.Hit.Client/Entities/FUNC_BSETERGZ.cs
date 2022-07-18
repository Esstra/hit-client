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
    /// Zusätzliche Daten zu BSE-Testergebnis
    /// </summary>
    [Entity("FUNC_BSETERGZ")]
    public class FUNC_BSETERGZ
    {
        /// <summary>
        /// Gets or sets the value of "Tierart im TSE-Test".
        /// </summary>
        [Column("TSE_T_ART")]
        public int? TSE_T_ART { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohrmarke für kleine Wiederkäuer nach VVVO im TSE-Test".
        /// </summary>
        /// <remarks>
        /// Individualkennzeichnung oder Bestandsmarke, je nach Tierart und Alter
        /// </remarks>
        [Column("TSE_LOM_IB")]
        public string? TSE_LOM_IB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Sonstiges Tier-Identitätskennzeichen im TSE-Test".
        /// </summary>
        /// <remarks>
        /// Ohrmarke oder eindeutige Kennzeichnung für Hirschartige, für Nichtrinder Stallnummer, TBA-Nummer..
        /// </remarks>
        [Column("TSE_IDENT")]
        public string? TSE_IDENT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer des letzter Halter des Tieres im TSE-Test".
        /// </summary>
        [Column("TSE_HALTER")]
        public decimal? TSE_HALTER { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name und Anschrift des letzten Halters des Tieres im TSE-Test".
        /// </summary>
        [Column("TSE_HA_ADR")]
        public string? TSE_HA_ADR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geschlecht des Tieres im TSE-Test".
        /// </summary>
        [Column("TSE_GESCHL")]
        public int? TSE_GESCHL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Alter in Monaten des Tieres im TSE-Test".
        /// </summary>
        [Column("TSE_ALTER")]
        public int? TSE_ALTER { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tieraltersklasse im TSE-Test".
        /// </summary>
        [Column("TSE_AK")]
        public int? TSE_AK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bemerkung".
        /// </summary>
        [Column("BEMERKUNG")]
        public string? BEMERKUNG { get; set; }

        /// <summary>
        /// Gets or sets the value of "SMS (1.Nummer) Bereitschaft LGL".
        /// </summary>
        /// <remarks>
        /// 1. Handynummer für SMS zur Benachrichtigung
        /// </remarks>
        [Column("BLGL_SMS1")]
        public string? BLGL_SMS1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fax (2.Nummer) Bereitschaft LGL".
        /// </summary>
        /// <remarks>
        /// 2. Fax-Anschluß zur Benachrichtigung
        /// </remarks>
        [Column("BLGL_FAX2")]
        public string? BLGL_FAX2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fax (1.Nummer) Bereitschaft LGL".
        /// </summary>
        /// <remarks>
        /// 1. Fax-Anschluß zur Benachrichtigung
        /// </remarks>
        [Column("BLGL_FAX1")]
        public string? BLGL_FAX1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnr Schlachtbetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnr Schlachtbetrieb oder letzter Betrieb
        /// </remarks>
        [Column("BNR15_FROM")]
        public decimal? BNR15_FROM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohrmarke Tier (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// nur in Funktionen, wenn der Benutzer keine Möglichkeit hat ALPHALOM selber aufzurufen)
        /// </remarks>
        [Column("LOM_X")]
        public string? LOM_X { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name des Schlachtbetriebes in Kurzform".
        /// </summary>
        /// <remarks>
        /// Name (haupsächlich für #BSETESTZ Ergebnisfunktion)
        /// </remarks>
        [Column("NAME_FROM")]
        public string? NAME_FROM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name des amtlichen Tierarztes in Kurzform".
        /// </summary>
        /// <remarks>
        /// Name (haupsächlich für #BSETESTZ Ergebnisfunktion)
        /// </remarks>
        [Column("NAME_TSLK")]
        public string? NAME_TSLK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name in Kurzform des amtlichen Tierarztes".
        /// </summary>
        /// <remarks>
        /// Name in Kurzform für Adressfenster aus Betriebsstammsatz
        /// </remarks>
        [Column("NAME1_TSLK")]
        public string? NAME1_TSLK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name 2.Zeile des amtlichen Tierarztes".
        /// </summary>
        /// <remarks>
        /// 2.Namenszeile für Adressfenster aus Betriebsstammsatz
        /// </remarks>
        [Column("NAME2_TSLK")]
        public string? NAME2_TSLK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ort des amtlichen Tierarztes".
        /// </summary>
        /// <remarks>
        /// Ort aus Betriebsstammsatz
        /// </remarks>
        [Column("ORT_TSLK")]
        public string? ORT_TSLK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ortsteil des amtlichen Tierarztes".
        /// </summary>
        /// <remarks>
        /// Ortsteil wenn erforderlich aus Betriebsstammsatz
        /// </remarks>
        [Column("ORTST_TSLK")]
        public string? ORTST_TSLK { get; set; }

        /// <summary>
        /// Gets or sets the value of "SMS (1.Nummer) Bereitschaft LGL".
        /// </summary>
        /// <remarks>
        /// 2. Handynummer für SMS zur Benachrichtigung
        /// </remarks>
        [Column("BLGL_SMS2")]
        public string? BLGL_SMS2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Telefon (1.Nummer) Bereitschaft LGL".
        /// </summary>
        /// <remarks>
        /// 2. Telefonnummer zur Benachrichtigung
        /// </remarks>
        [Column("BLGL_FON2")]
        public string? BLGL_FON2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Telefon (1.Nummer) Bereitschaft LGL".
        /// </summary>
        /// <remarks>
        /// 1. Telefonnummer zur Benachrichtigung
        /// </remarks>
        [Column("BLGL_FON1")]
        public string? BLGL_FON1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Telefon (1.Nummer) des zuständigen Tierarztes".
        /// </summary>
        /// <remarks>
        /// 2. Telefonnummer zur Benachrichtigung
        /// </remarks>
        [Column("TSLK_FON2")]
        public string? TSLK_FON2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "SMS (1.Nummer) des zuständigen Tierarztes".
        /// </summary>
        /// <remarks>
        /// 1. Handynummer für SMS zur Benachrichtigung
        /// </remarks>
        [Column("TSLK_SMS1")]
        public string? TSLK_SMS1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "SMS (1.Nummer) des zuständigen Tierarztes".
        /// </summary>
        /// <remarks>
        /// 2. Handynummer für SMS zur Benachrichtigung
        /// </remarks>
        [Column("TSLK_SMS2")]
        public string? TSLK_SMS2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "BSE-Altersklasse".
        /// </summary>
        /// <remarks>
        /// Altersklasse laut Schlüsseltabelle
        /// </remarks>
        [Column("UNTS_AK")]
        public int? UNTS_AK { get; set; }

        /// <summary>
        /// Gets or sets the value of "BSE-Altersklasse nach Halbjahren".
        /// </summary>
        [Column("UNTS_AKHJ")]
        public int? UNTS_AKHJ { get; set; }

        /// <summary>
        /// Gets or sets the value of "BSE-Altersklasse".
        /// </summary>
        /// <remarks>
        /// Altersklasse laut Schlüsseltabelle
        /// </remarks>
        [Column("UNTS_AKX")]
        public int? UNTS_AKX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungslabor".
        /// </summary>
        /// <remarks>
        /// Betriebsnr des Untersuchungslabor oder -anstalt
        /// </remarks>
        [Column("UNTS_BNR15")]
        public decimal? UNTS_BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Verantwortlicher für die Datensendung Schlacht-Test-Kopplung".
        /// </summary>
        /// <remarks>
        /// i.d.R. zuständiger amtlicher Tierarzt
        /// </remarks>
        [Column("BNR15_TSLK")]
        public decimal? BNR15_TSLK { get; set; }

        /// <summary>
        /// Gets or sets the value of "PID-Betrieb, Proben-Identifikation Ausgabebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Proben-ID-Bereich verwaltet (ursprünglich BSE, dann universell)
        /// </remarks>
        [Column("BSEPID_BNR")]
        public decimal? BSEPID_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "PID-Probe, Proben-Identifikation Sub-Part".
        /// </summary>
        /// <remarks>
        /// spezifische eindeutige ID innerhalb des Systems einer Ausgabestelle (urspr. BSE, dann universell)
        /// </remarks>
        [Column("BSEPID_SUB")]
        public string? BSEPID_SUB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Laufende Nummer innerhalb der Charge".
        /// </summary>
        /// <remarks>
        /// Laufende Nummer der Schlachtungen in der Charge
        /// </remarks>
        [Column("CHARGE_LFN")]
        public int? CHARGE_LFN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Chargen-Nummer der Schlachtung".
        /// </summary>
        /// <remarks>
        /// Kennzeichnung der Schlacht-Charge
        /// </remarks>
        [Column("CHARGE_NR")]
        public string? CHARGE_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Chargen-Umfang".
        /// </summary>
        /// <remarks>
        /// Anzahl Schlachtungen in der Charge
        /// </remarks>
        [Column("CHARGE_UMF")]
        public int? CHARGE_UMF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Todesalter".
        /// </summary>
        /// <remarks>
        /// Alter bei Tod/Schlachtung in Monate.Tage
        /// </remarks>
        [Column("END_ALTER")]
        public decimal? END_ALTER { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geburtsdatum".
        /// </summary>
        /// <remarks>
        /// Geburtsdatum Rind
        /// </remarks>
        [Column("GEB_DATR")]
        public DateOnly? GEB_DATR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohrmarke".
        /// </summary>
        /// <remarks>
        /// IDENTIFICATION NUMBER
        /// </remarks>
        [Column("LOM")]
        public decimal? LOM { get; set; }

        /// <summary>
        /// Gets or sets the value of "PlausiNr".
        /// </summary>
        /// <remarks>
        /// (seit 06.2004 5 statt 4stellig)
        /// </remarks>
        [Column("PLAUSINR")]
        public int? PLAUSINR { get; set; }

        /// <summary>
        /// Gets or sets the value of "PLZ des amtlichen Tierarztes".
        /// </summary>
        /// <remarks>
        /// Postleitzahl, ggf. internat. ohne Staat aus Betriebsstammsatz
        /// </remarks>
        [Column("PLZ_TSLK")]
        public string? PLZ_TSLK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schlachtdatum".
        /// </summary>
        [Column("SCHL_DAT")]
        public DateOnly? SCHL_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schlachtnummer".
        /// </summary>
        /// <remarks>
        /// Schlachtnr. des Schlachtbetriebes
        /// </remarks>
        [Column("SCHL_NR")]
        public decimal? SCHL_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fax (2.Nummer) des zuständigen Tierarztes".
        /// </summary>
        /// <remarks>
        /// 2. Fax-Anschluß zur Benachrichtigung
        /// </remarks>
        [Column("TSLK_FAX2")]
        public string? TSLK_FAX2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schwere".
        /// </summary>
        [Column("SCHWERE")]
        public int? SCHWERE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Strasse Nr des amtlichen Tierarztes".
        /// </summary>
        /// <remarks>
        /// Straße und Hausnummer aus Betriebsstammsatz
        /// </remarks>
        [Column("STRNR_TSLK")]
        public string? STRNR_TSLK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fax (1.Nummer) des zuständigen Tierarztes".
        /// </summary>
        /// <remarks>
        /// 1. Fax-Anschluß zur Benachrichtigung
        /// </remarks>
        [Column("TSLK_FAX1")]
        public string? TSLK_FAX1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Telefon (1.Nummer) des zuständigen Tierarztes".
        /// </summary>
        /// <remarks>
        /// 1. Telefonnummer zur Benachrichtigung
        /// </remarks>
        [Column("TSLK_FON1")]
        public string? TSLK_FON1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "BSE-Untersuchungsergebnis (nach Bewertung LGL)".
        /// </summary>
        /// <remarks>
        /// Ergebnis der BSE-Untersuchung nach automatischer oder manueller Berwertung durch LGL
        /// </remarks>
        [Column("UNTS_ERGL")]
        public int? UNTS_ERGL { get; set; }

        /// <summary>
        /// Gets or sets the value of "BSE-Untersuchung Pflicht/freiwillig".
        /// </summary>
        /// <remarks>
        /// War die BSE-Untersuchung Pflicht oder freiwillig
        /// </remarks>
        [Column("UNTS_PF_FR")]
        public int? UNTS_PF_FR { get; set; }

    }
}