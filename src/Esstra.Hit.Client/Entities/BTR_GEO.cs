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
    /// Geodaten zum Betrieb
    /// </summary>
    [Entity("BTR_GEO")]
    public class BTR_GEO
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
        /// Gets or sets the value of "Endezeitpunkt Geodaten".
        /// </summary>
        /// <remarks>
        /// Endes der fachlichen Gültigkeit (identisch zu nächstem Beginn, oder 31.12.2100 wenn aktuell)
        /// </remarks>
        [Column("DGEO_BIS")]
        [Required]
        public DateTime? DGEO_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginnzeitpunkt Geodaten".
        /// </summary>
        /// <remarks>
        /// Beginns der fachlichen Gültigkeit
        /// </remarks>
        [Column("DGEO_VON")]
        [Required]
        public DateTime? DGEO_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "GPS Geokoordinate X-Wert".
        /// </summary>
        /// <remarks>
        /// positiv Ost-Wert (E), negativ West-Wert (W), in Grad mit Dezimalstellen (nicht Minuten, Sekunden)
        /// </remarks>
        [Column("GEO_GPS_X")]
        [Required]
        public decimal? GEO_GPS_X { get; set; }

        /// <summary>
        /// Gets or sets the value of "GPS Geokoordinate Y-Wert".
        /// </summary>
        /// <remarks>
        /// positiv Nord-Wert (N), negativ Süd-Wert (S), in Grad mit Dezimalstellen (nicht Minuten, Sekunden)
        /// </remarks>
        [Column("GEO_GPS_Y")]
        [Required]
        public decimal? GEO_GPS_Y { get; set; }

        /// <summary>
        /// Gets or sets the value of "UTM Geokoordinate Hochwert".
        /// </summary>
        /// <remarks>
        /// bezogen auf ETRS89, i.d.R. im natürlichen Streifen 32 oder 33
        /// </remarks>
        [Column("GEO_UTM_H")]
        [Required]
        public decimal? GEO_UTM_H { get; set; }

        /// <summary>
        /// Gets or sets the value of "UTM Geokoordinate Rechtswert".
        /// </summary>
        /// <remarks>
        /// bezogen auf ETRS89, i.d.R. im natürlichen Streifen 32 oder 33
        /// </remarks>
        [Column("GEO_UTM_R")]
        [Required]
        public decimal? GEO_UTM_R { get; set; }

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
        /// Gets or sets the value of "Globally Unique Identifier".
        /// </summary>
        /// <remarks>
        /// Format xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx (lower case)
        /// </remarks>
        [Column("GUID")]
        public string? GUID { get; set; }

    }
}
