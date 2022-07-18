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
    /// Data-Dictionary View MELDUNGEN inner join MELD_ELE inner join ELEMENTE
    /// </summary>
    [Entity("D_MELD_E_E")]
    public class D_MELD_E_E
    {
        /// <summary>
        /// Gets or sets the value of "Entity".
        /// </summary>
        [Column("ENTITY")]
        public string? ENTITY { get; set; }

        /// <summary>
        /// Gets or sets the value of "DDE".
        /// </summary>
        [Column("DDE")]
        public string? DDE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Entityname".
        /// </summary>
        [Column("ENTITYNAME")]
        public string? ENTITYNAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Typ der Entität".
        /// </summary>
        /// <remarks>
        /// Gruppierung bez. Tier, Betrieb, Prämie ...
        /// </remarks>
        [Column("TYP")]
        public string? TYP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Feldname mit BNR".
        /// </summary>
        /// <remarks>
        /// Names des Meldungs-Elements mit der BNR für Kompetenz-Prüfung
        /// </remarks>
        [Column("FELDBNR")]
        public string? FELDBNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "FeldNamen TS-Von, Kennzeichen für technnischs Historie (für aktuell, RS/Z und Delta)".
        /// </summary>
        /// <remarks>
        /// Meldungselemente mit Begin-Timestamp (hier technisch), mittels Komma getrennt
        /// </remarks>
        [Column("FELDVON")]
        public string? FELDVON { get; set; }

        /// <summary>
        /// Gets or sets the value of "FeldNamen TS-Bis, Kennzeichen für technnischs Historie (für aktuell, RS/Z und Delta)".
        /// </summary>
        /// <remarks>
        /// Meldungselemente mit Ende-Timestamp (hier technisch), mittels Komma getrennt
        /// </remarks>
        [Column("FELDBIS")]
        public string? FELDBIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "FeldNameLom".
        /// </summary>
        /// <remarks>
        /// Names des Meldungs-Elements mit der LOM für Vorgangsabfrage
        /// </remarks>
        [Column("FELDLOM")]
        public string? FELDLOM { get; set; }

        /// <summary>
        /// Gets or sets the value of "FeldNameDat".
        /// </summary>
        /// <remarks>
        /// Names des Meldungs-Elements mit dem Ereignisdatum
        /// </remarks>
        [Column("FELDDAT")]
        public string? FELDDAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "FeldNamen TS-Von, Kennzeichen für fachliche Historie (RS/F)".
        /// </summary>
        /// <remarks>
        /// Meldungselemente mit Begin-Timestamp (hier fachlich), mittels Komma getrennt
        /// </remarks>
        [Column("FELDVON2")]
        public string? FELDVON2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "FeldNamen TS-Bis, Kennzeichen für fachliche Historie (RS/F)".
        /// </summary>
        /// <remarks>
        /// Meldungselemente mit Ende-Timestamp (hier fachlich), mittels Komma getrennt
        /// </remarks>
        [Column("FELDBIS2")]
        public string? FELDBIS2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Feldname Prämien-Kompetenz".
        /// </summary>
        /// <remarks>
        /// auf welche Spalte bei Kompetenz-Bereich P, Q (für Prämien/ZID) geprüft wird
        /// </remarks>
        [Column("FELDPKOMP")]
        public string? FELDPKOMP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kennzeichen on HIT-Vollmacht für die Meldung gilt".
        /// </summary>
        [Column("VM_HIT")]
        public bool? VM_HIT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kennzeichen on ZID-Vollmacht für die Meldung gilt".
        /// </summary>
        [Column("VM_ZID")]
        public bool? VM_ZID { get; set; }

        /// <summary>
        /// Gets or sets the value of "Feldname".
        /// </summary>
        [Column("FELDNAME")]
        public string? FELDNAME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Feldnr".
        /// </summary>
        [Column("FELDNR")]
        public int? FELDNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Required".
        /// </summary>
        [Column("REQUIRED")]
        public string? REQUIRED { get; set; }

        /// <summary>
        /// Gets or sets the value of "Prompt".
        /// </summary>
        [Column("PROMPT")]
        public string? PROMPT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bemerkung".
        /// </summary>
        [Column("BEMERKUNG")]
        public string? BEMERKUNG { get; set; }

        /// <summary>
        /// Gets or sets the value of "DDI".
        /// </summary>
        [Column("DDI")]
        public string? DDI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Feldbez".
        /// </summary>
        [Column("FELDBEZ")]
        public string? FELDBEZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Definition".
        /// </summary>
        /// <remarks>
        /// ausführliche Definition des Feldes
        /// </remarks>
        [Column("DEFINITION")]
        public string? DEFINITION { get; set; }

        /// <summary>
        /// Gets or sets the value of "Format".
        /// </summary>
        [Column("FORMAT")]
        public string? FORMAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Laenge".
        /// </summary>
        [Column("LAENGE")]
        public int? LAENGE { get; set; }

        /// <summary>
        /// Gets or sets the value of "NK".
        /// </summary>
        [Column("NK")]
        public int? NK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Min".
        /// </summary>
        [Column("MIN")]
        public string? MIN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Max".
        /// </summary>
        [Column("MAX")]
        public string? MAX { get; set; }

        /// <summary>
        /// Gets or sets the value of "Codeset".
        /// </summary>
        /// <remarks>
        /// Key des Codesets
        /// </remarks>
        [Column("CODESET")]
        public string? CODESET { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachlich gültig bis (1. Entity in View)".
        /// </summary>
        /// <remarks>
        /// fachlich gültig bis oder aktuell (31.12.2100)
        /// </remarks>
        [Column("FACH_BIS_1")]
        public DateTime? FACH_BIS_1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachlich gültig bis (2. Entity in View)".
        /// </summary>
        /// <remarks>
        /// fachlich gültig bis oder aktuell (31.12.2100)
        /// </remarks>
        [Column("FACH_BIS_2")]
        public DateTime? FACH_BIS_2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachlich gültig bis (3. Entity in View)".
        /// </summary>
        /// <remarks>
        /// fachlich gültig bis oder aktuell (31.12.2100)
        /// </remarks>
        [Column("FACH_BIS_3")]
        public DateTime? FACH_BIS_3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachlich gültig von (1. Entity in View)".
        /// </summary>
        /// <remarks>
        /// Timestamp ab wann der Satz fachlich gilt
        /// </remarks>
        [Column("FACH_VON_1")]
        public DateTime? FACH_VON_1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachlich gültig von (2. Entity in View)".
        /// </summary>
        /// <remarks>
        /// Timestamp ab wann der Satz fachlich gilt
        /// </remarks>
        [Column("FACH_VON_2")]
        public DateTime? FACH_VON_2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fachlich gültig von (3. Entity in View)".
        /// </summary>
        /// <remarks>
        /// Timestamp ab wann der Satz fachlich gilt
        /// </remarks>
        [Column("FACH_VON_3")]
        public DateTime? FACH_VON_3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "storniert, 1.Zuordnung".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information im Teil 1 technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS_1")]
        public DateTime? SYS_BIS_1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "storniert, 2.Zuordnung".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information im Teil 2 technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS_2")]
        public DateTime? SYS_BIS_2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "storniert, 3.Zuordnung".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information im Teil 3 technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS_3")]
        public DateTime? SYS_BIS_3 { get; set; }

        /// <summary>
        /// Gets or sets the value of "gespeichert, 1.Zuordnung".
        /// </summary>
        [Column("SYS_VON_1")]
        public DateTime? SYS_VON_1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "gespeichert, 2.Zuordnung".
        /// </summary>
        [Column("SYS_VON_2")]
        public DateTime? SYS_VON_2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "gespeichert, 3.Zuordnung".
        /// </summary>
        [Column("SYS_VON_3")]
        public DateTime? SYS_VON_3 { get; set; }

    }
}
