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
    /// TSN Untersuchungsauftrag
    /// </summary>
    [Entity("TSN_UAUF")]
    public class TSN_UAUF
    {
        /// <summary>
        /// Gets or sets the value of "Rachentupfer".
        /// </summary>
        /// <remarks>
        /// Probenmaterial Rachentupfer laut TSN für HIT-Untersuchungsantrag
        /// </remarks>
        [Column("TSN_M03_RA")]
        [Required]
        public bool? TSN_M03_RA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Blut (Serum)".
        /// </summary>
        /// <remarks>
        /// Probenmaterial Blut laut TSN für HIT-Untersuchungsantrag
        /// </remarks>
        [Column("TSN_M02_BS")]
        [Required]
        public bool? TSN_M02_BS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tierseuche, laut TSN".
        /// </summary>
        [Column("TSN_SEUCHE")]
        [Required]
        public int? TSN_SEUCHE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsgrund, laut TSN".
        /// </summary>
        [Column("TSN_UN_GRN")]
        [Required]
        public int? TSN_UN_GRN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Sperrgrund, laut TSN".
        /// </summary>
        /// <remarks>
        /// Sperrgrund / Restriktionszonen, laut TSN
        /// </remarks>
        [Column("TSN_SP_GRN")]
        [Required]
        public int? TSN_SP_GRN { get; set; }

        /// <summary>
        /// Gets or sets the value of "TSN Seuchenobjekt-Nummer".
        /// </summary>
        /// <remarks>
        /// TSN Seuchenobjekt-Nummer
        /// </remarks>
        [Column("TSN_SO_NR")]
        [Required]
        public string? TSN_SO_NR { get; set; }

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
        /// Gets or sets the value of "Rinder gesamt, laut TSN".
        /// </summary>
        /// <remarks>
        /// Bestandsumfang Rinder aus TSN
        /// </remarks>
        [Column("TSN_RI_ANZ")]
        public int? TSN_RI_ANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Rinder Stichprobe, laut TSN".
        /// </summary>
        /// <remarks>
        /// Stichprobenumfang Rinder aus TSN
        /// </remarks>
        [Column("TSN_RI_STI")]
        public Int64? TSN_RI_STI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schweine gesamt, laut TSN".
        /// </summary>
        /// <remarks>
        /// Bestandsumfang Schweine aus TSN
        /// </remarks>
        [Column("TSN_SW_ANZ")]
        public Int64? TSN_SW_ANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schweine Stichprobe, laut TSN".
        /// </summary>
        /// <remarks>
        /// Stichprobenumfang Schweine aus TSN
        /// </remarks>
        [Column("TSN_SW_STI")]
        public Int64? TSN_SW_STI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schafe gesamt, laut TSN".
        /// </summary>
        /// <remarks>
        /// Bestandsumfang Schafe aus TSN
        /// </remarks>
        [Column("TSN_SF_ANZ")]
        public Int64? TSN_SF_ANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schafe Stichprobe, laut TSN".
        /// </summary>
        /// <remarks>
        /// Stichprobenumfang Schafe aus TSN
        /// </remarks>
        [Column("TSN_SF_STI")]
        public Int64? TSN_SF_STI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ziege gesamt, laut TSN".
        /// </summary>
        /// <remarks>
        /// Bestandsumfang Ziegen aus TSN
        /// </remarks>
        [Column("TSN_ZI_ANZ")]
        public Int64? TSN_ZI_ANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ziege Stichprobe, laut TSN".
        /// </summary>
        /// <remarks>
        /// Stichprobenumfang Ziegen aus TSN
        /// </remarks>
        [Column("TSN_ZI_STI")]
        public Int64? TSN_ZI_STI { get; set; }

        /// <summary>
        /// Gets or sets the value of "sonst. Geflügel gesamt, laut TSN".
        /// </summary>
        /// <remarks>
        /// Bestandsumfang sonst. Geflügel aus TSN
        /// </remarks>
        [Column("TSN_GF_ANZ")]
        public Int64? TSN_GF_ANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "sonst. Geflügel Stichprobe, laut TSN".
        /// </summary>
        /// <remarks>
        /// Stichprobenumfang sonst. Geflügel aus TSN
        /// </remarks>
        [Column("TSN_GF_STI")]
        public Int64? TSN_GF_STI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Methode Ag, laut TSN".
        /// </summary>
        /// <remarks>
        /// Untersuchungsmethode Antikörper laut TSN
        /// </remarks>
        [Column("TSN_U01_AG")]
        [Required]
        public bool? TSN_U01_AG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Methode AK, laut TSN".
        /// </summary>
        /// <remarks>
        /// Untersuchungsmethode Antigen laut TSN
        /// </remarks>
        [Column("TSN_U02_AK")]
        [Required]
        public bool? TSN_U02_AK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Blut (EDTA)".
        /// </summary>
        /// <remarks>
        /// Probenmaterial Blut laut TSN für HIT-Untersuchungsantrag
        /// </remarks>
        [Column("TSN_M01_BE")]
        [Required]
        public bool? TSN_M01_BE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nasentupfer".
        /// </summary>
        /// <remarks>
        /// Probenmaterial Nasentupfer laut TSN für HIT-Untersuchungsantrag
        /// </remarks>
        [Column("TSN_M04_NA")]
        [Required]
        public bool? TSN_M04_NA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Speichelprobe".
        /// </summary>
        /// <remarks>
        /// Probenmaterial Speichelprobe laut TSN für HIT-Untersuchungsantrag
        /// </remarks>
        [Column("TSN_M05_SP")]
        [Required]
        public bool? TSN_M05_SP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Aphtenprobe".
        /// </summary>
        /// <remarks>
        /// Probenmaterial Aphtenprobe laut TSN für HIT-Untersuchungsantrag
        /// </remarks>
        [Column("TSN_M06_AP")]
        [Required]
        public bool? TSN_M06_AP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Kloakentupfer/Kot/Sammelkotprobe".
        /// </summary>
        /// <remarks>
        /// Probenmaterial Kloakentupfer/Kot/Sammelkotprobe laut TSN für HIT-Untersuchungsantrag
        /// </remarks>
        [Column("TSN_M07_KL")]
        [Required]
        public bool? TSN_M07_KL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Organprobe/Gewebe/Tierkörpe".
        /// </summary>
        /// <remarks>
        /// Probenmaterial Organprobe/Gewebe/Tierkörpe laut TSN für HIT-Untersuchungsantrag
        /// </remarks>
        [Column("TSN_M08_OR")]
        [Required]
        public bool? TSN_M08_OR { get; set; }

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
        /// Gets the value of "Satzstatus".
        /// </summary>
        /// <remarks>
        /// Systemstatus des Satzes
        /// </remarks>
        [Column("SYS_STAT")]
        public int? SYS_STAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hühner gesamt, laut TSN".
        /// </summary>
        /// <remarks>
        /// Bestandsumfang Hühner aus TSN
        /// </remarks>
        [Column("TSN_HU_ANZ")]
        public Int64? TSN_HU_ANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hühner Stichprobe, laut TSN".
        /// </summary>
        /// <remarks>
        /// Stichprobenumfang Hühner aus TSN
        /// </remarks>
        [Column("TSN_HU_STI")]
        public Int64? TSN_HU_STI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Puten gesamt, laut TSN".
        /// </summary>
        /// <remarks>
        /// Bestandsumfang Puten aus TSN
        /// </remarks>
        [Column("TSN_PU_ANZ")]
        public Int64? TSN_PU_ANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Puten Stichprobe, laut TSN".
        /// </summary>
        /// <remarks>
        /// Stichprobenumfang Puten aus TSN
        /// </remarks>
        [Column("TSN_PU_STI")]
        public Int64? TSN_PU_STI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gänse gesamt, laut TSN".
        /// </summary>
        /// <remarks>
        /// Bestandsumfang Gänse aus TSN
        /// </remarks>
        [Column("TSN_GA_ANZ")]
        public Int64? TSN_GA_ANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gänse Stichprobe, laut TSN".
        /// </summary>
        /// <remarks>
        /// Stichprobenumfang Gänse aus TSN
        /// </remarks>
        [Column("TSN_GA_STI")]
        public Int64? TSN_GA_STI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Enten gesamt, laut TSN".
        /// </summary>
        /// <remarks>
        /// Bestandsumfang Enten aus TSN
        /// </remarks>
        [Column("TSN_EN_ANZ")]
        public Int64? TSN_EN_ANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Enten Stichprobe, laut TSN".
        /// </summary>
        /// <remarks>
        /// Stichprobenumfang Enten aus TSN
        /// </remarks>
        [Column("TSN_EN_STI")]
        public Int64? TSN_EN_STI { get; set; }

        /// <summary>
        /// Gets or sets the value of "TSN-Probennehmer".
        /// </summary>
        /// <remarks>
        /// Nr. des Teams aus der TSN-Auftragsnummer
        /// </remarks>
        [Column("TSN_AUFPN")]
        public string? TSN_AUFPN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bienen gesamt, laut TSN".
        /// </summary>
        /// <remarks>
        /// Bestandsumfang Bienen aus TSN
        /// </remarks>
        [Column("TSN_BI_ANZ")]
        public Int64? TSN_BI_ANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Einhufer gesamt, laut TSN".
        /// </summary>
        /// <remarks>
        /// Bestandsumfang Einhufer aus TSN
        /// </remarks>
        [Column("TSN_EH_ANZ")]
        public Int64? TSN_EH_ANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fische gesamt, laut TSN".
        /// </summary>
        /// <remarks>
        /// Bestandsumfang Fische aus TSN
        /// </remarks>
        [Column("TSN_FI_ANZ")]
        public Int64? TSN_FI_ANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Futterkranz/Wabe /Käferfalle/Brut".
        /// </summary>
        /// <remarks>
        /// Probenmaterial Futterkranz/Wabe/Käferfalle/Brut laut TSN für HIT-Untersuchungsantrag
        /// </remarks>
        [Column("TSN_M09_FU")]
        [Required]
        public bool? TSN_M09_FU { get; set; }

        /// <summary>
        /// Gets or sets the value of "Methode Erregerisolierung, laut TSN".
        /// </summary>
        /// <remarks>
        /// Untersuchungsmethode Erregerisolierung laut TSN
        /// </remarks>
        [Column("TSN_U03_EI")]
        [Required]
        public bool? TSN_U03_EI { get; set; }

        /// <summary>
        /// Gets or sets the value of "TSN-Auftragsnummer".
        /// </summary>
        /// <remarks>
        /// TSN interne Auftragsnummer
        /// </remarks>
        [Column("TSN_AUFNR")]
        [Required]
        public string? TSN_AUFNR { get; set; }

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
