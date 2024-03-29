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
    /// Zahlungsansprüche, Pacht
    /// </summary>
    [Entity("ZA_PACHT")]
    public class ZA_PACHT
    {
        /// <summary>
        /// Gets the value of "Stornobetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung storniert hat
        /// </remarks>
        [Column("STRN_BNR")]
        public decimal? STRN_BNR { get; set; }

        /// <summary>
        /// Gets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlungsanspruchs-Land".
        /// </summary>
        /// <remarks>
        /// Land das den ZA ausgegeben hat. Dient mit Serie und Nr zur Identifikation.
        /// </remarks>
        [Column("ZA_LAND")]
        [Required]
        public int? ZA_LAND { get; set; }

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
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Obergrenze des Intervalls".
        /// </summary>
        /// <remarks>
        /// Intervallobergrenze innerhalb der Serie als 2. Teil der Identifikation eines Intervalls
        /// </remarks>
        [Column("ZA_NR_BIS")]
        [Required]
        public Int64? ZA_NR_BIS { get; set; }

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
        /// Gets the value of "Stornomitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung storniert hat
        /// </remarks>
        [Column("STRN_MBN")]
        public int? STRN_MBN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ende der Gültigkeit der Pacht".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem die Pacht nicht mehr gültig ist, damit ggf. identisch mit nächstem Beginn
        /// </remarks>
        [Column("ZA_PA_BIS")]
        [Required]
        public DateTime? ZA_PA_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Verpächter Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Person bzw. InVeKoS / Unternehmen
        /// </remarks>
        [Column("ZA_VP_BNR")]
        [Required]
        public decimal? ZA_VP_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginn der Gültigkeit der Pacht".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem die Pacht gültig ist
        /// </remarks>
        [Column("ZA_PA_VON")]
        [Required]
        public DateTime? ZA_PA_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Untergrenze des Intervalls".
        /// </summary>
        /// <remarks>
        /// Intervalluntergrenze innerhalb der Serie als 2. Teil der Identifikation eines Intervalls
        /// </remarks>
        [Column("ZA_NR_VON")]
        [Required]
        public Int64? ZA_NR_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Pachtart (mit oder ohne Fläche)".
        /// </summary>
        [Column("ZA_PA_ART")]
        [Required]
        public int? ZA_PA_ART { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Serie".
        /// </summary>
        /// <remarks>
        /// Seriennummer des Zahlungsanspruchs als 1. Teil der Identifikation
        /// </remarks>
        [Column("ZA_SERIE")]
        [Required]
        public Int64? ZA_SERIE { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Pächter Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Person bzw. InVeKoS / Unternehmen
        /// </remarks>
        [Column("ZA_PA_BNR")]
        [Required]
        public decimal? ZA_PA_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchsintervall, externe Darstellung".
        /// </summary>
        /// <remarks>
        /// zur Vereinfachten Anlieferung von Land, Serie und Nr-Von und Bis
        /// </remarks>
        [Column("ZA_IV_EXT")]
        public string? ZA_IV_EXT { get; set; }

    }
}
