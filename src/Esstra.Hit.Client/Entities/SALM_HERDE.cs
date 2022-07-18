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
    /// Salmonellen Herdendefinition
    /// </summary>
    [Entity("SALM_HERDE")]
    public class SALM_HERDE
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
        /// Gets or sets the value of "Globally Unique Identifier".
        /// </summary>
        /// <remarks>
        /// Format xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx (lower case)
        /// </remarks>
        [Column("GUID")]
        public string? GUID { get; set; }

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
        /// Gets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

        /// <summary>
        /// Gets the value of "Meldeweg".
        /// </summary>
        /// <remarks>
        /// Meldeweg (Post,IVR,IN...)
        /// </remarks>
        [Column("MELD_WG")]
        public int? MELD_WG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nummer Betriebsabteilung (Herde)".
        /// </summary>
        [Column("SA_BANR")]
        [Required]
        public Int64? SA_BANR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Endezeitpunkt".
        /// </summary>
        /// <remarks>
        /// Endes der fachlichen Gültigkeit (identisch zu nächstem Beginn, oder 31.12.2100 wenn aktuell)
        /// </remarks>
        [Column("SA_BA_BIS")]
        [Required]
        public DateTime? SA_BA_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginnzeitpunkt".
        /// </summary>
        /// <remarks>
        /// Beginns der fachlichen Gültigkeit
        /// </remarks>
        [Column("SA_BA_VON")]
        [Required]
        public DateTime? SA_BA_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nummer der Stalleinheit".
        /// </summary>
        [Column("SA_STNR")]
        [Required]
        public Int64? SA_STNR { get; set; }

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
        /// Gets the value of "Satzstatus".
        /// </summary>
        /// <remarks>
        /// Systemstatus des Satzes
        /// </remarks>
        [Column("SYS_STAT")]
        public int? SYS_STAT { get; set; }

        /// <summary>
        /// Gets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Erster Tag des BA-Zeitraumes".
        /// </summary>
        /// <remarks>
        /// abgeleitet aus ST_BA_VON, i.d.R. das selbe Datum
        /// </remarks>
        [Column("SA_BA_TGE")]
        public DateOnly? SA_BA_TGE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Letzter Tag der Gültigkeit des BA-Zeitraumes".
        /// </summary>
        /// <remarks>
        /// abgeleitet aus ST_BA_BIS, i.d.R. das Datum des Vortages (der letzte, komplett enthaltene Tag)
        /// </remarks>
        [Column("SA_BA_TGL")]
        public DateOnly? SA_BA_TGL { get; set; }

    }
}
