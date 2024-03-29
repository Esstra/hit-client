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
    /// Vorangegangene Haltungen
    /// </summary>
    [Entity("FUNC_VORHALT")]
    public class FUNC_VORHALT
    {
        /// <summary>
        /// Gets or sets the value of "Bewegungsdatum".
        /// </summary>
        /// <remarks>
        /// Bewegungsdatum der jeweiligen Meldung (bei Ersterf. 26.09.1999)
        /// </remarks>
        [Column("BEW_DAT")]
        public DateOnly? BEW_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bewegungs-Art".
        /// </summary>
        /// <remarks>
        /// Numerische Kennzeichnung der Meldungsart
        /// </remarks>
        [Column("BEW_ART")]
        public int? BEW_ART { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohrmarke Tier (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// nur in Funktionen, wenn der Benutzer keine Möglichkeit hat ALPHALOM selber aufzurufen)
        /// </remarks>
        [Column("LOM_X")]
        public string? LOM_X { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohrmarke".
        /// </summary>
        /// <remarks>
        /// IDENTIFICATION NUMBER
        /// </remarks>
        [Column("LOM")]
        public decimal? LOM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Betriebsschlüssel für Ausgabe i.d.F. ll rkk gggg nnnn
        /// </remarks>
        [Column("BNR15_X")]
        public string? BNR15_X { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Registriernummer für Betrieb, Langform mit B.Land und Staat
        /// </remarks>
        [Column("BNR15")]
        public decimal? BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Alter (in Monaten und Tagen)".
        /// </summary>
        /// <remarks>
        /// Alter bei Abgang oder Zeitraumende
        /// </remarks>
        [Column("ALTER")]
        public decimal? ALTER { get; set; }

        /// <summary>
        /// Gets or sets the value of "Alter (als Text in Monaten und Tagen)".
        /// </summary>
        /// <remarks>
        /// Alter bei Abgang oder Zeitraumende i.d.F. x Mon. x Tg.
        /// </remarks>
        [Column("ALTERA")]
        public string? ALTERA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Alter (in Tagen)".
        /// </summary>
        /// <remarks>
        /// Alter bei Abgang oder Zeitraumende
        /// </remarks>
        [Column("ALTERT")]
        public Int64? ALTERT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Alter (in Monaten und Bruchteile von Monaten)".
        /// </summary>
        /// <remarks>
        /// Alter bei Abgang oder Zeitraumende mit Nachkommastellen (ein Tag sind 0.0322580645 Monate)
        /// </remarks>
        [Column("ALTERX")]
        public decimal? ALTERX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Haltungstage".
        /// </summary>
        [Column("LLF_HATT")]
        public Int64? LLF_HATT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzeigegrund".
        /// </summary>
        /// <remarks>
        /// Anzeigegrund bei Vorhaltung/Lebenslauf
        /// </remarks>
        [Column("ANZEI_GRND")]
        public int? ANZEI_GRND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzeigegrund (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Anzeigegrund bei Vorhaltung/Lebenslauf
        /// </remarks>
        [Column("ANZEI_GRNX")]
        public string? ANZEI_GRNX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bewegungsdatum, ggf. GE".
        /// </summary>
        /// <remarks>
        /// Bewegungsdatum der jeweiligen Meldung (bei Ersterf. Geburtsdatum)
        /// </remarks>
        [Column("BEWGE_DAT")]
        public DateOnly? BEWGE_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bewegungs-Art (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Kurzcode der Meldungsart
        /// </remarks>
        [Column("BEW_ARTX")]
        public string? BEW_ARTX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bewegungsart, mit differenzierten Todesarten".
        /// </summary>
        /// <remarks>
        /// Numerische Kennzeichnung der Meldungsart
        /// </remarks>
        [Column("BEW_ART_TD")]
        public int? BEW_ART_TD { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bewegungsart, mit differenzierten Todesarten (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Kurzcode der Meldungsart
        /// </remarks>
        [Column("BEW_ART_TX")]
        public string? BEW_ART_TX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bewegungs-Meldung".
        /// </summary>
        /// <remarks>
        /// Magic Name Meldungsart ABGANG ...
        /// </remarks>
        [Column("BEW_MELD")]
        public string? BEW_MELD { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fehlertext".
        /// </summary>
        [Column("FEHLERTEXT")]
        public string? FEHLERTEXT { get; set; }

        /// <summary>
        /// Gets or sets the value of "PlausiNr".
        /// </summary>
        /// <remarks>
        /// (seit 06.2004 5 statt 4stellig)
        /// </remarks>
        [Column("PLAUSINR")]
        public int? PLAUSINR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schwere".
        /// </summary>
        [Column("SCHWERE")]
        public int? SCHWERE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Satzstatus".
        /// </summary>
        /// <remarks>
        /// Systemstatus des Satzes
        /// </remarks>
        [Column("SYS_STAT")]
        public int? SYS_STAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name in Kurzform".
        /// </summary>
        /// <remarks>
        /// Name in Kurzform für Adressfenster
        /// </remarks>
        [Column("NAME")]
        public string? NAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name 2.Zeile".
        /// </summary>
        /// <remarks>
        /// 2.Namenszeile für Adressfenster
        /// </remarks>
        [Column("NAME2")]
        public string? NAME2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ort".
        /// </summary>
        /// <remarks>
        /// Ort
        /// </remarks>
        [Column("ORT")]
        public string? ORT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ortsteil".
        /// </summary>
        /// <remarks>
        /// Ortsteil wenn erforderlich
        /// </remarks>
        [Column("ORTSTEIL")]
        public string? ORTSTEIL { get; set; }

        /// <summary>
        /// Gets or sets the value of "PLZ".
        /// </summary>
        /// <remarks>
        /// Postleitzahl, ggf. internat. ohne Staat
        /// </remarks>
        [Column("PLZ")]
        public string? PLZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Strasse Nr".
        /// </summary>
        /// <remarks>
        /// Straße und Hausnummer
        /// </remarks>
        [Column("STR_NR")]
        public string? STR_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Adresse, gesamt aus STR_NR, PLZ, ORT, ORTSTEIL (je nach Rechtsform und Vorliegen)".
        /// </summary>
        [Column("ADDR_GES")]
        public string? ADDR_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nachbesitzer Betrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Nachbesitzers
        /// </remarks>
        [Column("BNR15_NB")]
        public decimal? BNR15_NB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer Nachbesitzer (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Betriebsschlüssel für Ausgabe i.d.F. ll rkk gggg nnnn
        /// </remarks>
        [Column("BNR15_NBX")]
        public string? BNR15_NBX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorbesitzer Betrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Vorbesitzers
        /// </remarks>
        [Column("BNR15_VB")]
        public decimal? BNR15_VB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer Vorbesitzer (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Betriebsschlüssel für Ausgabe i.d.F. ll rkk gggg nnnn
        /// </remarks>
        [Column("BNR15_VBX")]
        public string? BNR15_VBX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Name, gesamt aus Vorname, Nachname oder Firma (je nach Rechtsform und Vorliegen)".
        /// </summary>
        [Column("NAME_GES")]
        public string? NAME_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "BVD-Bestandsstaus HIT, für Abfrage Halter".
        /// </summary>
        [Column("BVDB_STAHH")]
        public int? BVDB_STAHH { get; set; }

    }
}
