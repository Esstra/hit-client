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
    /// Flächen Prüfergebnis
    /// </summary>
    [Entity("ZF_ERGEB")]
    public class ZF_ERGEB
    {
        /// <summary>
        /// Gets or sets the value of "Flächenplausiergebnis Wert 1".
        /// </summary>
        /// <remarks>
        /// Ergebnisangabe 1
        /// </remarks>
        [Column("ZF_ERG_W1")]
        public string? ZF_ERG_W1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Feld-Schlag-ID Nummer".
        /// </summary>
        /// <remarks>
        /// Format noch nicht sicher (Vorschlag numerisch LONG 8stellig)
        /// </remarks>
        [Column("FS_ID_NR")]
        [Required]
        public Int64? FS_ID_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Flächenidentifikator".
        /// </summary>
        /// <remarks>
        /// einheitlicher Schlüssel zur Identifikation einer Fläche entsprechend dem System
        /// </remarks>
        [Column("FLIK")]
        [Required]
        public string? FLIK { get; set; }

        /// <summary>
        /// Gets or sets the value of "PlausiNr".
        /// </summary>
        /// <remarks>
        /// (seit 06.2004 5 statt 4stellig)
        /// </remarks>
        [Column("PLAUSINR")]
        [Required]
        public int? PLAUSINR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginn des Antragszeitraumes".
        /// </summary>
        /// <remarks>
        /// Datum des Beginns der Gültigkeit, z.Zt. Tag & Monat auf 1.1. Beschränkt
        /// </remarks>
        [Column("ANTDAT_VON")]
        [Required]
        public DateOnly? ANTDAT_VON { get; set; }

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
        /// Gets or sets the value of "Antragsstellungsland".
        /// </summary>
        [Column("ANTR_LAND")]
        [Required]
        public int? ANTR_LAND { get; set; }

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
        /// Gets the value of "Bewirtschaftungsland".
        /// </summary>
        [Column("BEWIR_LAND")]
        public int? BEWIR_LAND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Flächenplausiergebnis Wert 4".
        /// </summary>
        /// <remarks>
        /// Ergebnisangabe 4
        /// </remarks>
        [Column("ZF_ERG_W4")]
        public string? ZF_ERG_W4 { get; set; }

        /// <summary>
        /// Gets or sets the value of "VorgLfn".
        /// </summary>
        /// <remarks>
        /// innerhalb Vorgangsnr bzw. Betrieb, Tier oder Antrag
        /// </remarks>
        [Column("VORGLFN")]
        [Required]
        public int? VORGLFN { get; set; }

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
        /// Gets or sets the value of "Flächenplausiergebnis Wert 3".
        /// </summary>
        /// <remarks>
        /// Ergebnisangabe 3
        /// </remarks>
        [Column("ZF_ERG_W3")]
        public string? ZF_ERG_W3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Flächenplausiergebnis Wert 2".
        /// </summary>
        /// <remarks>
        /// Ergebnisangabe 2
        /// </remarks>
        [Column("ZF_ERG_W2")]
        public string? ZF_ERG_W2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Flächenplausiergebnis Wert 5".
        /// </summary>
        /// <remarks>
        /// Ergebnisangabe 5
        /// </remarks>
        [Column("ZF_ERG_W5")]
        public string? ZF_ERG_W5 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Flächenplausiergebnis Wert 6".
        /// </summary>
        /// <remarks>
        /// Ergebnisangabe 6
        /// </remarks>
        [Column("ZF_ERG_W6")]
        public string? ZF_ERG_W6 { get; set; }

        /// <summary>
        /// Gets the value of "primär zuständiges Land".
        /// </summary>
        /// <remarks>
        /// für Speicherung bzw. Bearbeitung zuständiges Land, Kompetenzbasis
        /// </remarks>
        [Column("ZUST_LAND")]
        public int? ZUST_LAND { get; set; }

    }
}
