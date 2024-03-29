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
    /// Zahlungsansprüche V2, Eigentum oder Besitz (Sicht für Register)
    /// </summary>
    [Entity("ZB_EIG_BES")]
    public class ZB_EIG_BES
    {
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
        /// Gets or sets the value of "Ende der Gültigkeit von Eigentum oder Pacht".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem es nicht mehr gültig ist, damit ggf. identisch mit nächstem Beginn
        /// </remarks>
        [Column("ZB_EB_BIS")]
        [Required]
        public DateTime? ZB_EB_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer des Eigentümers oder Pächters".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Person bzw. InVeKoS / Unternehmen
        /// </remarks>
        [Column("ZB_EB_BNR")]
        [Required]
        public decimal? ZB_EB_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginn der Gültigkeit von Eigentum oder Pacht".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem Eigentum oder Pacht gültig ist
        /// </remarks>
        [Column("ZB_EB_VON")]
        [Required]
        public DateTime? ZB_EB_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ist Satz aus Eigentum".
        /// </summary>
        /// <remarks>
        /// wenn eigentum dann wahr 1 , sonst falsch 0 Pacht
        /// </remarks>
        [Column("ZB_EIG_BES")]
        [Required]
        [JsonPropertyName("ZB_EIG_BES")]
        public bool? _ZB_EIG_BES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlungsanspruchs-Land".
        /// </summary>
        /// <remarks>
        /// Land das den ZA ausgegeben hat. Dient mit Serie und Nr zur Identifikation.
        /// </remarks>
        [Column("ZB_LAND")]
        [Required]
        public int? ZB_LAND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Obergrenze des Intervalls".
        /// </summary>
        /// <remarks>
        /// Intervallobergrenze innerhalb der Serie als 2. Teil der Identifikation eines Intervalls
        /// </remarks>
        [Column("ZB_NR_BIS")]
        [Required]
        public Int64? ZB_NR_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Untergrenze des Intervalls".
        /// </summary>
        /// <remarks>
        /// Intervalluntergrenze innerhalb der Serie als 2. Teil der Identifikation eines Intervalls
        /// </remarks>
        [Column("ZB_NR_VON")]
        [Required]
        public Int64? ZB_NR_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Serie".
        /// </summary>
        /// <remarks>
        /// Seriennummer des Zahlungsanspruchs als 1. Teil der Identifikation
        /// </remarks>
        [Column("ZB_SERIE")]
        [Required]
        public Int64? ZB_SERIE { get; set; }

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
