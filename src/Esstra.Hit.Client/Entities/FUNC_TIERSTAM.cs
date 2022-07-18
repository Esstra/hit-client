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
    /// Tierstamm-Daten
    /// </summary>
    [Entity("FUNC_TIERSTAM")]
    public class FUNC_TIERSTAM
    {
        /// <summary>
        /// Gets or sets the value of "BSE-Untersuchung Pflicht/freiwillig bei Normalschlachtung zum angegebenen Datum".
        /// </summary>
        /// <remarks>
        /// Wäre die BSE-Untersuchung bei Normalschlachtung Pflicht oder freiwillig
        /// </remarks>
        [Column("PF_NORSCHL")]
        public int? PF_NORSCHL { get; set; }

        /// <summary>
        /// Gets or sets the value of "BSE-Untersuchung Pflicht/freiwillig bei Monitoring zum angegebenen Datum".
        /// </summary>
        /// <remarks>
        /// Wäre die BSE-Untersuchung bei Monitoring Pflicht oder freiwillig
        /// </remarks>
        [Column("PF_MONITOR")]
        public int? PF_MONITOR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geburtsbetrieb (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// , ggf. EU-Betrieb im Tierstamm
        /// </remarks>
        [Column("BNR15_GEX")]
        public string? BNR15_GEX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geburtsbetrieb".
        /// </summary>
        /// <remarks>
        /// Geburtsbetrieb bei Ersterfassungssatz
        /// </remarks>
        [Column("BNR15_GEB")]
        public decimal? BNR15_GEB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ende-Betrieb (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Endebetriebes im Tierende
        /// </remarks>
        [Column("BNR15_EBX")]
        public string? BNR15_EBX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anfangsdatum des Tieres".
        /// </summary>
        /// <remarks>
        /// Anfangsdatum im Tierstamm
        /// </remarks>
        [Column("DAT_ANF")]
        public DateOnly? DAT_ANF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bundesland Geburt".
        /// </summary>
        /// <remarks>
        /// Bundesland-Schlüssel
        /// </remarks>
        [Column("BLAND_GEB")]
        public int? BLAND_GEB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bundesland Geburt (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Bundesland-Schlüssel
        /// </remarks>
        [Column("BLAND_GEX")]
        public string? BLAND_GEX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ende-Betrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Endebetriebes im Tierende
        /// </remarks>
        [Column("BNR15_EB")]
        public decimal? BNR15_EB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Altersklasse zum angegebenen Datum".
        /// </summary>
        /// <remarks>
        /// Klasseneinteilung analog zu UNTS_AK
        /// </remarks>
        [Column("ERG_AK")]
        public int? ERG_AK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Altersklasse (erweitert) am Ereignisdatum".
        /// </summary>
        /// <remarks>
        /// Klasseneinteilung analog zu UNTS_AKX
        /// </remarks>
        [Column("ERG_AKX")]
        public int? ERG_AKX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Alter am Ereignisdatum".
        /// </summary>
        /// <remarks>
        /// Ereignisdatum in Monate.Tage
        /// </remarks>
        [Column("ERG_ALTER")]
        public decimal? ERG_ALTER { get; set; }

        /// <summary>
        /// Gets or sets the value of "Mutter".
        /// </summary>
        /// <remarks>
        /// Ohrmarkennummer Muttertier
        /// </remarks>
        [Column("LOM_MUT")]
        public decimal? LOM_MUT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohrmarke Mutter".
        /// </summary>
        /// <remarks>
        /// Ohrmarke Muttertier aufbereitet (DE..) oder alte alphanumerische Marke
        /// </remarks>
        [Column("LOM_MUTX")]
        public string? LOM_MUTX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohrmarke Tier (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// nur in Funktionen, wenn der Benutzer keine Möglichkeit hat ALPHALOM selber aufzurufen)
        /// </remarks>
        [Column("LOM_X")]
        public string? LOM_X { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geburtsstaat (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Staat für Ausgabe i.d.F 040,Österreich
        /// </remarks>
        [Column("LAND_GEX")]
        public string? LAND_GEX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geburtsstaat".
        /// </summary>
        /// <remarks>
        /// Geburtsstaat
        /// </remarks>
        [Column("LAND_GEB")]
        public int? LAND_GEB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ursprungsstaat".
        /// </summary>
        /// <remarks>
        /// Staat aus dem das Tier direkt kommt
        /// </remarks>
        [Column("LAND_URS")]
        public int? LAND_URS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geschlecht Rind(aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Geschlecht Rind für Ausgabe i.d.F  M
        /// </remarks>
        [Column("GESCHL_X")]
        public string? GESCHL_X { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ursprungsstaat (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Staat für Ausgabe i.d.F 040,Österreich
        /// </remarks>
        [Column("LAND_URX")]
        public string? LAND_URX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geschlecht".
        /// </summary>
        /// <remarks>
        /// Geschlecht Rind
        /// </remarks>
        [Column("GESCHL_R")]
        public int? GESCHL_R { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohrmarke".
        /// </summary>
        /// <remarks>
        /// IDENTIFICATION NUMBER
        /// </remarks>
        [Column("LOM")]
        public decimal? LOM { get; set; }

        /// <summary>
        /// Gets or sets the value of "alte Alfa-Ohrmarke".
        /// </summary>
        [Column("LOM_A")]
        public string? LOM_A { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geburtsdatum".
        /// </summary>
        /// <remarks>
        /// Geburtsdatum Rind
        /// </remarks>
        [Column("GEB_DATR")]
        public DateOnly? GEB_DATR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ereignisdatum".
        /// </summary>
        /// <remarks>
        /// Ereignisdatum der jeweiligen Meldung (bei Ersterf. 26.9.1999)
        /// </remarks>
        [Column("ERG_DAT")]
        public DateOnly? ERG_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Rasse".
        /// </summary>
        /// <remarks>
        /// Rasse laut ADR-Schlüssel
        /// </remarks>
        [Column("RASSE")]
        public int? RASSE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Rasse (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Rasse für Ausgabe i.d.F  1,RBT
        /// </remarks>
        [Column("RASSE_X")]
        public string? RASSE_X { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tier-Anfang".
        /// </summary>
        /// <remarks>
        /// Tier-Anfang durch Geburt, Impmark ...
        /// </remarks>
        [Column("TIER_ANF")]
        public int? TIER_ANF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tier-Anfang (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Tier-Anfang  i.d.F XX
        /// </remarks>
        [Column("TIER_ANFX")]
        public string? TIER_ANFX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Erstkalbedatum".
        /// </summary>
        /// <remarks>
        /// Datum der ersten Kalbung des Muttertieres
        /// </remarks>
        [Column("EKALBDAT")]
        public DateOnly? EKALBDAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Kälber".
        /// </summary>
        /// <remarks>
        /// Anzahl Kälber des Muttertieres
        /// </remarks>
        [Column("KALBANZ")]
        public int? KALBANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kalbungsstatus".
        /// </summary>
        /// <remarks>
        /// ist eine Kalbung (über Geburtsmeldung) bekannt
        /// </remarks>
        [Column("KALBSTAT")]
        public int? KALBSTAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Kalbungen".
        /// </summary>
        /// <remarks>
        /// Anzahl Kalbungen des Muttertieres (Zwillinge sind eine Kalbung)
        /// </remarks>
        [Column("KALBUNGANZ")]
        public int? KALBUNGANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Letztkalbedatum".
        /// </summary>
        /// <remarks>
        /// Datum der letzten, also jüngsten Kalbung des Muttertieres
        /// </remarks>
        [Column("LKALBDAT")]
        public DateOnly? LKALBDAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ursprungsstaat der Mutter".
        /// </summary>
        /// <remarks>
        /// Herkunft, Staat aus dem die Mutter des Tieres direkt kommt
        /// </remarks>
        [Column("LAND_MUT")]
        public int? LAND_MUT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ursprungsstaat (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Staat für Ausgabe i.d.F 040,Österreich
        /// </remarks>
        [Column("LAND_MUX")]
        public string? LAND_MUX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Embryotransfer".
        /// </summary>
        /// <remarks>
        /// Kalb aus Embryotransfer 0/1
        /// </remarks>
        [Column("ET_KALB")]
        public int? ET_KALB { get; set; }

    }
}
