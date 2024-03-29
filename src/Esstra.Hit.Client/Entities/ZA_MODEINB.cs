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
    /// einbehaltene Modulationsbeträge
    /// </summary>
    [Entity("ZA_MODEINB")]
    public class ZA_MODEINB
    {
        /// <summary>
        /// Gets or sets the value of "Modulationsmaßnahme".
        /// </summary>
        [Column("ZA_MO_MASN")]
        [Required]
        public int? ZA_MO_MASN { get; set; }

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
        /// Gets or sets the value of "Modulationsbetrag".
        /// </summary>
        /// <remarks>
        /// Betrag der bei Zahlung einbehalten wurde
        /// </remarks>
        [Column("ZA_MO_BETR")]
        [Required]
        public decimal? ZA_MO_BETR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Jahr in dem Modulationsbetrag einbehalten wurde".
        /// </summary>
        /// <remarks>
        /// Jahresangabe, vierstellig
        /// </remarks>
        [Column("ZA_MO_JAHR")]
        [Required]
        public int? ZA_MO_JAHR { get; set; }

        /// <summary>
        /// Gets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

        /// <summary>
        /// Gets the value of "Stornobetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung storniert hat
        /// </remarks>
        [Column("STRN_BNR")]
        public decimal? STRN_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer bei der Modulationsbetrag einbehalten wurde".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Person bzw. InVeKoS / Unternehmen
        /// </remarks>
        [Column("ZA_MO_BNR")]
        [Required]
        public decimal? ZA_MO_BNR { get; set; }

        /// <summary>
        /// Gets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

        /// <summary>
        /// Gets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Auszahlungsbetrag, vor Modulation".
        /// </summary>
        /// <remarks>
        /// Zahlungsbetrag von dem Modulation einbehalten wurde
        /// </remarks>
        [Column("ZA_MO_AUSZ")]
        public decimal? ZA_MO_AUSZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bescheiddatum".
        /// </summary>
        [Column("ZA_MO_BDAT")]
        public DateOnly? ZA_MO_BDAT { get; set; }

    }
}
