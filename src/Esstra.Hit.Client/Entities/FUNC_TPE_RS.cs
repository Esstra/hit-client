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
    /// Tierpass/Ersatzpapier Rückseite
    /// </summary>
    [Entity("FUNC_TPE_RS")]
    public class FUNC_TPE_RS
    {
        /// <summary>
        /// Gets or sets the value of "Schwere".
        /// </summary>
        [Column("SCHWERE")]
        public int? SCHWERE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Strasse Nr".
        /// </summary>
        /// <remarks>
        /// Straße und Hausnummer
        /// </remarks>
        [Column("STR_NR")]
        public string? STR_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tier-Eingang".
        /// </summary>
        /// <remarks>
        /// Tier-Eingang durch Geburt, Impmark, Zugang ... (analog TIER_ANF + Zugang)
        /// </remarks>
        [Column("TIER_EIN")]
        public int? TIER_EIN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tier-Eingang (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Tier-Eingang i.d.F XX
        /// </remarks>
        [Column("TIER_EINX")]
        public string? TIER_EINX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tier-Ausgang Haltung".
        /// </summary>
        /// <remarks>
        /// Haltungsende durch Abgang, Ausfuhr, Schlachtung oder Tod (ähnlich TIER_AUS, TOD undif)
        /// </remarks>
        [Column("TIER_HAUS")]
        public int? TIER_HAUS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tier-Ausgang Haltung (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Haltungsende durch Abgang, Ausfuhr, Schlachtung oder Tod (ähnlich TIER_AUS, TOD undif)
        /// </remarks>
        [Column("TIER_HAUSX")]
        public string? TIER_HAUSX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Registriernummer für Betrieb, Langform mit B.Land und Staat
        /// </remarks>
        [Column("BNR15")]
        public decimal? BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// Betriebsschlüssel für Ausgabe i.d.F. ll rkk gggg nnnn
        /// </remarks>
        [Column("BNR15_X")]
        public string? BNR15_X { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ausgangsdatum".
        /// </summary>
        /// <remarks>
        /// Ausgangsdatum für Bestandsregister u-ä.
        /// </remarks>
        [Column("DAT_AUS")]
        public DateOnly? DAT_AUS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Eingangsdatum".
        /// </summary>
        /// <remarks>
        /// Eingangsdatum für Bestandsregister u-ä.
        /// </remarks>
        [Column("DAT_EIN")]
        public DateOnly? DAT_EIN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fehlertext".
        /// </summary>
        [Column("FEHLERTEXT")]
        public string? FEHLERTEXT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohrmarke".
        /// </summary>
        /// <remarks>
        /// IDENTIFICATION NUMBER
        /// </remarks>
        [Column("LOM")]
        public decimal? LOM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohrmarke Tier (aufbereitet)".
        /// </summary>
        /// <remarks>
        /// nur in Funktionen, wenn der Benutzer keine Möglichkeit hat ALPHALOM selber aufzurufen)
        /// </remarks>
        [Column("LOM_X")]
        public string? LOM_X { get; set; }

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
        /// Gets or sets the value of "PlausiNr".
        /// </summary>
        /// <remarks>
        /// (seit 06.2004 5 statt 4stellig)
        /// </remarks>
        [Column("PLAUSINR")]
        public int? PLAUSINR { get; set; }

    }
}
