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
    /// Untersuchungsauftrag - Einzeltier
    /// </summary>
    [Entity("UNTAUF_E")]
    public class UNTAUF_E
    {
        /// <summary>
        /// Gets or sets the value of "Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Registriernummer für Betrieb, Langform mit B.Land und Staat
        /// </remarks>
        [Column("BNR15")]
        public decimal? BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "PID-Betrieb, Proben-Identifikation Ausgabebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Proben-ID-Bereich verwaltet (ursprünglich BSE, dann universell)
        /// </remarks>
        [Column("BSEPID_BNR")]
        public decimal? BSEPID_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "PID-Probe, Proben-Identifikation Sub-Part".
        /// </summary>
        /// <remarks>
        /// spezifische eindeutige ID innerhalb des Systems einer Ausgabestelle (urspr. BSE, dann universell)
        /// </remarks>
        [Column("BSEPID_SUB")]
        public string? BSEPID_SUB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohrmarke".
        /// </summary>
        /// <remarks>
        /// IDENTIFICATION NUMBER
        /// </remarks>
        [Column("LOM")]
        public decimal? LOM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Laufende Nummer des Auftrags für den Auftraggeber".
        /// </summary>
        /// <remarks>
        /// Eindeutige laufende Nummer des Auftrags für den Auftraggeber
        /// </remarks>
        [Column("UNTAUF_ANR")]
        [Required]
        public Int64? UNTAUF_ANR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Auftraggeber".
        /// </summary>
        /// <remarks>
        /// Auftraggeber-Betriebsnr. für Untersuchungsauftrag, Halter, Tierarzt, Auktionator oder Veterinär
        /// </remarks>
        [Column("UNTAUF_BNR")]
        [Required]
        public decimal? UNTAUF_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Proben-Nummer, Position innerhalb des Auftrags".
        /// </summary>
        /// <remarks>
        /// Eindeutige laufende Nummer der Probe oder Position innerhalb eines Auftrags
        /// </remarks>
        [Column("UNTAUF_PNR")]
        [Required]
        public Int64? UNTAUF_PNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsalter".
        /// </summary>
        /// <remarks>
        /// Alter bei Probenahme in Monate.Tage
        /// </remarks>
        [Column("UNTS_ALTER")]
        public decimal? UNTS_ALTER { get; set; }

        /// <summary>
        /// Gets or sets the value of "Probennahmedatum".
        /// </summary>
        /// <remarks>
        /// Datum der Entnahme der Probe beim Tier
        /// </remarks>
        [Column("UNTS_NDAT")]
        [Required]
        public DateOnly? UNTS_NDAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "BVD-Tierstatus, mit Impfinformation".
        /// </summary>
        /// <remarks>
        /// BVD-Gesamtergebnis als Folge der einzelnen Untersuchungsergebnisse, berücksichtigt Impfungen
        /// </remarks>
        [Column("BVD_EMI")]
        public int? BVD_EMI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Leukose-Gesamtergebnis".
        /// </summary>
        /// <remarks>
        /// Leukose-Gesamtergebnis als Folge der einzelnen Untersuchungsergebnisse
        /// </remarks>
        [Column("LEU_ERG")]
        public int? LEU_ERG { get; set; }

        /// <summary>
        /// Gets or sets the value of "BVD-Impfinformation".
        /// </summary>
        [Column("BVD_IMP")]
        public int? BVD_IMP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Brucellose-Gesamtergebnis".
        /// </summary>
        /// <remarks>
        /// Brucellose-Gesamtergebnis als Folge der einzelnen Untersuchungsergebnisse
        /// </remarks>
        [Column("BRU_ERG")]
        public int? BRU_ERG { get; set; }

        /// <summary>
        /// Gets or sets the value of "BTV-8-Impfinformation".
        /// </summary>
        [Column("BTV_IMP")]
        public int? BTV_IMP { get; set; }

        /// <summary>
        /// Gets or sets the value of "BTV-Gesamtergebnis, mit Impfinformation".
        /// </summary>
        /// <remarks>
        /// BTV-Gesamtergebnis als Folge der einzelnen Untersuchungsergebnisse
        /// </remarks>
        [Column("BTV_EMI")]
        public int? BTV_EMI { get; set; }

        /// <summary>
        /// Gets or sets the value of "BHV1-Tierstatus, mit Impfinformation".
        /// </summary>
        /// <remarks>
        /// BHV1-Gesamtergebnis als Folge der einzelnen Untersuchungsergebnisse, berücksichtigt Impfungen
        /// </remarks>
        [Column("BHV1_EMI")]
        public int? BHV1_EMI { get; set; }

        /// <summary>
        /// Gets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "BHV1-Impfinformation".
        /// </summary>
        [Column("BHV1_IMP")]
        public int? BHV1_IMP { get; set; }

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
        /// Gets or sets the value of "Untersuchungsauftrag BHV1".
        /// </summary>
        [Column("UAUF_BHV")]
        public int? UAUF_BHV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsauftrag Brucellose".
        /// </summary>
        [Column("UAUF_BRU")]
        public int? UAUF_BRU { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsauftrag BTV".
        /// </summary>
        [Column("UAUF_BTV")]
        public int? UAUF_BTV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsauftrag BVD".
        /// </summary>
        [Column("UAUF_BVD")]
        public int? UAUF_BVD { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsauftrag Leukose".
        /// </summary>
        [Column("UAUF_LEU")]
        public int? UAUF_LEU { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsauftrag Paratuberkulose".
        /// </summary>
        [Column("UAUF_MAP")]
        public int? UAUF_MAP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsgrund, im Untersuchungsauftrag".
        /// </summary>
        [Column("UNTS_GRUND")]
        public int? UNTS_GRUND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsmaterial, im Untersuchungsauftrag".
        /// </summary>
        [Column("UNTS_MAT")]
        public int? UNTS_MAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tierart, im Untersuchungsauftrag".
        /// </summary>
        [Column("UNTS_TIERA")]
        public int? UNTS_TIERA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bemerkung zur Auftragsposition".
        /// </summary>
        [Column("UNTS_BEMY")]
        [Required]
        public string? UNTS_BEMY { get; set; }

        /// <summary>
        /// Gets or sets the value of "Sonstige Tierart".
        /// </summary>
        /// <remarks>
        /// Freies Eingabefeld für sonstige Tierart
        /// </remarks>
        [Column("SON_TIERA")]
        public string? SON_TIERA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsauftrag AI (Aviäre Influenza)".
        /// </summary>
        [Column("UAUF_AI")]
        public int? UAUF_AI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsauftrag ASP".
        /// </summary>
        [Column("UAUF_ASP")]
        public int? UAUF_ASP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsauftrag MKS".
        /// </summary>
        [Column("UAUF_MKS")]
        public int? UAUF_MKS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsauftrag Aujeszky".
        /// </summary>
        [Column("UAUF_AK")]
        public int? UAUF_AK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsauftrag KSP".
        /// </summary>
        [Column("UAUF_KSP")]
        public int? UAUF_KSP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsauftrag sonstige Tierseuche".
        /// </summary>
        [Column("UAUF_SON")]
        public int? UAUF_SON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsauftrag sonstige Tierseuche, Textauswahl".
        /// </summary>
        [Column("UAUF_SONT")]
        public int? UAUF_SONT { get; set; }

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
        /// Gets or sets the value of "Untersuchungsauftrag Aborterreger".
        /// </summary>
        [Column("UAUF_ABO")]
        public int? UAUF_ABO { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsauftrag Chlamydien".
        /// </summary>
        [Column("UAUF_CHL")]
        public int? UAUF_CHL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsauftrag Neospora".
        /// </summary>
        [Column("UAUF_NEO")]
        public int? UAUF_NEO { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsauftrag Q-Fieber".
        /// </summary>
        [Column("UAUF_QFI")]
        public int? UAUF_QFI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsauftrag Schmallenberg".
        /// </summary>
        [Column("UAUF_SBV")]
        public int? UAUF_SBV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsauftrag Infektiöse Anämie".
        /// </summary>
        [Column("UAUF_IA")]
        public int? UAUF_IA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchungsauftrag Tuberkulose".
        /// </summary>
        [Column("UAUF_TBC")]
        public int? UAUF_TBC { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchung Ansteckende Blutarmutder Lachse".
        /// </summary>
        [Column("UAUF_ABL")]
        public int? UAUF_ABL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchung Amerikanische Faulbrut".
        /// </summary>
        [Column("UAUF_AF")]
        public int? UAUF_AF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchung Afrikanische Pferdepest".
        /// </summary>
        [Column("UAUF_AP")]
        public int? UAUF_AP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchung Befall mit dem kleinen Bienenbeutenkäfer".
        /// </summary>
        [Column("UAUF_BKL")]
        public int? UAUF_BKL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchung Befall mit der Tropilaelaps-Milbe".
        /// </summary>
        [Column("UAUF_BTM")]
        public int? UAUF_BTM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchung Blauzungenkrankheit".
        /// </summary>
        [Column("UAUF_BZK")]
        public int? UAUF_BZK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchung Infektiöse Hämatopoetische Nekroseder Salmoniden".
        /// </summary>
        [Column("UAUF_IHN")]
        public int? UAUF_IHN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchung Koi Herpesvirus-Infektion der Karpfen".
        /// </summary>
        [Column("UAUF_KHK")]
        public int? UAUF_KHK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchung Newcastle-Krankheit".
        /// </summary>
        [Column("UAUF_NKD")]
        public int? UAUF_NKD { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchung Stomatitisvesicularis".
        /// </summary>
        [Column("UAUF_STV")]
        public int? UAUF_STV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchung Virale Hämorrhagische Septikämie der Salmoniden".
        /// </summary>
        [Column("UAUF_VHS")]
        public int? UAUF_VHS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchung Vesikuläre Schweinekrankheit".
        /// </summary>
        [Column("UAUF_VSK")]
        public int? UAUF_VSK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bemerkung, im Untersuchungsauftrag ".
        /// </summary>
        [Column("UNTS_BEMER")]
        [Required]
        public string? UNTS_BEMER { get; set; }

        /// <summary>
        /// Gets or sets the value of "Genehmigung, im Untersuchungsauftrag ".
        /// </summary>
        [Column("UNTS_GENM")]
        public bool? UNTS_GENM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nutzrichtung, im Untersuchungsauftrag ".
        /// </summary>
        [Column("UNTS_NUTZR")]
        public int? UNTS_NUTZR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zustand, im Untersuchungsauftrag ".
        /// </summary>
        [Column("UNTS_ZUST")]
        public int? UNTS_ZUST { get; set; }

        /// <summary>
        /// Gets or sets the value of "Paratuberkulose-Gesamtergebnis".
        /// </summary>
        /// <remarks>
        /// Gesamtergebnis als Folge der einzelnen Untersuchungsergebnisse
        /// </remarks>
        [Column("PTB_ERG")]
        public int? PTB_ERG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchung Salmonellose".
        /// </summary>
        [Column("UAUF_SAL")]
        public int? UAUF_SAL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchung Influenza".
        /// </summary>
        [Column("UAUF_INF")]
        public int? UAUF_INF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchung CAE".
        /// </summary>
        [Column("UAUF_CAE")]
        public int? UAUF_CAE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Untersuchung MAV".
        /// </summary>
        [Column("UAUF_MAV")]
        public int? UAUF_MAV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fieberhafte Virusinfektion".
        /// </summary>
        [Column("UAUF_FHVI")]
        public int? UAUF_FHVI { get; set; }

    }
}
