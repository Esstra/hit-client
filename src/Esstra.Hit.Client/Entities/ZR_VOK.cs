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
    /// Zirkusregister Vorort Kontrolle
    /// </summary>
    [Entity("ZR_VOK")]
    public class ZR_VOK
    {
        /// <summary>
        /// Gets or sets the value of "Zirkus Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Registriernummer des Zirkusbetriebes
        /// </remarks>
        [Column("ZR_BNR15")]
        [Required]
        public decimal? ZR_BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum der Vorortkontrolle".
        /// </summary>
        [Column("ZR_VOK_DAT")]
        [Required]
        public DateOnly? ZR_VOK_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ort der Vorortkontrolle".
        /// </summary>
        [Column("ZR_VOK_ORT")]
        [Required]
        public string? ZR_VOK_ORT { get; set; }

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
        /// Gets or sets the value of "Kontrollbehörde".
        /// </summary>
        /// <remarks>
        /// Zuständige Behörde, die die Vor-Ort-Kontrolle durchführte
        /// </remarks>
        [Column("ZR_VOK_AMT")]
        public string? ZR_VOK_AMT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beanstandungen ja/nein".
        /// </summary>
        /// <remarks>
        /// Beanstandungen bei der Vor-Ort-Kontrolle festgestellt ja/nein
        /// </remarks>
        [Column("ZR_VOK_BEA")]
        public bool? ZR_VOK_BEA { get; set; }

    }
}
