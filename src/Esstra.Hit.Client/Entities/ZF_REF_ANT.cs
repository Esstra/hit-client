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
    /// Flächen Referenz verbunden mit Antragsdaten (Ergebnissicht für Referenzland)
    /// </summary>
    [Entity("ZF_REF_ANT")]
    public class ZF_REF_ANT
    {
        /// <summary>
        /// Gets or sets the value of "Antragsteller-Amt".
        /// </summary>
        /// <remarks>
        /// Registriernummer des zuständigen Amtes
        /// </remarks>
        [Column("AN_AMT_BNR")]
        public decimal? AN_AMT_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Antragsteller-Mitbenutzer".
        /// </summary>
        /// <remarks>
        /// Meldemitbenutzer des zuständigen Mitarbeiters
        /// </remarks>
        [Column("AN_AMT_MBN")]
        public int? AN_AMT_MBN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginn des Antragszeitraumes".
        /// </summary>
        /// <remarks>
        /// Datum des Beginns der Gültigkeit, z.Zt. Tag & Monat auf 1.1. Beschränkt
        /// </remarks>
        [Column("ANTDAT_VON")]
        public DateOnly? ANTDAT_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Information, je nach Typ der Antragsfläche".
        /// </summary>
        [Column("ANT_INF_CH")]
        public string? ANT_INF_CH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Information, je nach Typ der Antragsfläche".
        /// </summary>
        [Column("ANT_INF_NU")]
        public decimal? ANT_INF_NU { get; set; }

        /// <summary>
        /// Gets or sets the value of "Landschaftselemente, im Antrag angegeben".
        /// </summary>
        /// <remarks>
        /// irgendwelche, d.h. CC relevant oder sonstige ohne Unterscheidung
        /// </remarks>
        [Column("ANTR_LEVH")]
        public bool? ANTR_LEVH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Im Antrag angegebene Netto-LF, Landwirtschaftliche Nutzfläche".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("ANTR_LFN")]
        public decimal? ANTR_LFN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Im Antrag angegebene Brutto-LF, Landwirtschaftliche Nutzfläche (LE enthalten, Sperrfläche nicht)".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("ANTR_LFB")]
        public decimal? ANTR_LFB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Status des Antrags bezüglich Fehlernachprüfung".
        /// </summary>
        /// <remarks>
        /// mit Auswirkung auf weiteres Vorgehen Kollisionsprüfung
        /// </remarks>
        [Column("ANTR_STAT")]
        public int? ANTR_STAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bewirtschaftungsland".
        /// </summary>
        [Column("BEWIR_LAND")]
        public int? BEWIR_LAND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bodennutzungskategorie".
        /// </summary>
        [Column("BN_KAT")]
        public int? BN_KAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Registriernummer für Betrieb, Langform mit B.Land und Staat
        /// </remarks>
        [Column("BNR15")]
        public decimal? BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Im Antrag angegebene LE-Fläche, gesamt".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("ANTR_LE")]
        public decimal? ANTR_LE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Antragsstellungsland".
        /// </summary>
        [Column("ANTR_LAND")]
        public int? ANTR_LAND { get; set; }

        /// <summary>
        /// Gets or sets the value of "CC-relevante Landschaftselemente, im Antrag angegeben".
        /// </summary>
        [Column("ANTR_LECVH")]
        public bool? ANTR_LECVH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Im Antrag angegebene LE-Fläche, CC-relevant".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("ANTR_LEC")]
        public decimal? ANTR_LEC { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ende des Antragszeitraumes".
        /// </summary>
        /// <remarks>
        /// Datum des Endes der Gültigkeit, z.Zt. Tag & Monat auf 31.12. Beschränkt
        /// </remarks>
        [Column("ANTDAT_BIS")]
        public DateOnly? ANTDAT_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Laufende Satznummer innerhalb Antragsinformation".
        /// </summary>
        /// <remarks>
        /// Unterteilung unterhalb Feldstücks/Schlages-Identifikation zur Unterteilung der Nutz-Information
        /// </remarks>
        [Column("ANT_LFNR")]
        public int? ANT_LFNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Feld-Schlag-ID Nummer".
        /// </summary>
        /// <remarks>
        /// Format noch nicht sicher (Vorschlag numerisch LONG 8stellig)
        /// </remarks>
        [Column("FS_ID_NR")]
        public Int64? FS_ID_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fläche im benachteiligtes Gebiet".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("REF_BEN")]
        public decimal? REF_BEN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldemitbenutzer (View Teil A)".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN_A")]
        public int? MELD_MBN_A { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldebetrieb (View Teil A)".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR_A")]
        public decimal? MELD_BNR_A { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bewirtschafter-Amt".
        /// </summary>
        /// <remarks>
        /// Registriernummer des zuständigen Amtes
        /// </remarks>
        [Column("BW_AMT_BNR")]
        public decimal? BW_AMT_BNR { get; set; }

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
        /// Gets or sets the value of "Festgestellte Netto-LF, Landwirtschaftliche Nutzfläche".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("FEST_LFN")]
        public decimal? FEST_LFN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Festgestellte Brutto-LF, Landwirtschaftliche Nutzfläche (LE ist enthalten, Sperrfläche nicht)".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("FEST_LFB")]
        public decimal? FEST_LFB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Landschaftselemente, festgestellt".
        /// </summary>
        /// <remarks>
        /// irgendwelche, d.h. CC relevant oder sonstige ohne Unterscheidung
        /// </remarks>
        [Column("FEST_LEVH")]
        public bool? FEST_LEVH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Festgestellte LE-Fläche, CC-relevant".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("FEST_LEC")]
        public decimal? FEST_LEC { get; set; }

        /// <summary>
        /// Gets or sets the value of "CC-relevante Landschaftselemente, festgestellt".
        /// </summary>
        [Column("FEST_LECVH")]
        public bool? FEST_LECVH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Bewirtschafter-Mitbenutzer".
        /// </summary>
        /// <remarks>
        /// Meldemitbenutzer des zuständigen Mitarbeiters
        /// </remarks>
        [Column("BW_AMT_MBN")]
        public int? BW_AMT_MBN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Festgestellte LE-Fläche, gesamt".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("FEST_LE")]
        public decimal? FEST_LE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Hauptbodennutzung".
        /// </summary>
        /// <remarks>
        /// laut gemeinsamer Nutzungstabelle
        /// </remarks>
        [Column("HB_NUTZ")]
        public int? HB_NUTZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginn des Referenzzeitraumes".
        /// </summary>
        /// <remarks>
        /// Datum des Beginns der Gültigkeit, z.Zt. Tag & Monat auf 1.1. Beschränkt
        /// </remarks>
        [Column("REFDAT_VON")]
        public DateOnly? REFDAT_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ende des Referenzzeitraumes".
        /// </summary>
        /// <remarks>
        /// Datum des Endes der Gültigkeit, z.Zt. Tag & Monat auf 31.12. Beschränkt
        /// </remarks>
        [Column("REFDAT_BIS")]
        public DateOnly? REFDAT_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art des Referenzsystems".
        /// </summary>
        [Column("REF_SYSTEM")]
        public int? REF_SYSTEM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Status der Referenzfläche".
        /// </summary>
        /// <remarks>
        /// zur Abschätzung der Verlässlichkeit und Stabilität
        /// </remarks>
        [Column("REF_STATUS")]
        public int? REF_STATUS { get; set; }

        /// <summary>
        /// Gets or sets the value of "LE-Referenzfläche, CC relevant".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("REF_LEC")]
        public decimal? REF_LEC { get; set; }

        /// <summary>
        /// Gets or sets the value of "CC-relevante Landschaftselemente vorhanden".
        /// </summary>
        [Column("REF_LECVH")]
        public bool? REF_LECVH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Netto-Referenzfläche, landwirtschaftlich nutzbar, Netto LF (sicher ohne LE)".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("REF_LFN")]
        public decimal? REF_LFN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Landschaftselemente vorhanden".
        /// </summary>
        /// <remarks>
        /// irgendwelche, d.h. CC relevant oder sonstige ohne Unterscheidung
        /// </remarks>
        [Column("REF_LEVH")]
        public bool? REF_LEVH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Brutto-Referenzfläche, landwirtschaftlich nutzbar, Brutto LF (LE ist enthalten, Sperrfläche nicht)".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("REF_LFB")]
        public decimal? REF_LFB { get; set; }

        /// <summary>
        /// Gets or sets the value of "NL-Referenzfläche, nicht landwirtschaftlich nutzbare Fläche / Sperrflächen, z.B. Gebäude, Wald".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("REF_NL")]
        public decimal? REF_NL { get; set; }

        /// <summary>
        /// Gets or sets the value of "LVZ der Referenzfläche".
        /// </summary>
        [Column("REF_LVZ")]
        public decimal? REF_LVZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Stilllegungsfähige Fläche".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("REF_SLF")]
        public decimal? REF_SLF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Information, je nach Typ der Referenzfläche".
        /// </summary>
        [Column("REF_INF_CH")]
        public string? REF_INF_CH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fläche Dauergrünland".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("REF_DGL")]
        public decimal? REF_DGL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Information, je nach Typ der Referenzfläche".
        /// </summary>
        [Column("REF_INF_NU")]
        public decimal? REF_INF_NU { get; set; }

        /// <summary>
        /// Gets or sets the value of "LE-Referenzfläche, Landschaftselemente gesamt, innenliegenden LE (für entkoppelte Maßnahmen)".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("REF_LE")]
        public decimal? REF_LE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Sorteninformation, laut kontextabhängigem Sortenschlüssel".
        /// </summary>
        /// <remarks>
        /// bei Nutzung 75x - SORTE_75x
        /// </remarks>
        [Column("SORTE")]
        public int? SORTE { get; set; }

        /// <summary>
        /// Gets or sets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "gespeichert (Teil A)".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information im Teil A technisch gültig ist
        /// </remarks>
        [Column("SYS_VON_A")]
        public DateTime? SYS_VON_A { get; set; }

        /// <summary>
        /// Gets or sets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Satzstatus (View Teil A)".
        /// </summary>
        /// <remarks>
        /// Systemstatus des Satzes
        /// </remarks>
        [Column("SYS_STAT_A")]
        public int? SYS_STAT_A { get; set; }

        /// <summary>
        /// Gets or sets the value of "Satzstatus".
        /// </summary>
        /// <remarks>
        /// Systemstatus des Satzes
        /// </remarks>
        [Column("SYS_STAT")]
        public int? SYS_STAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Information, laut kontextabhängigem Codeset (von ZID festgelegt)".
        /// </summary>
        /// <remarks>
        /// bei Nutzung 75x - HOPFEN_EZG
        /// </remarks>
        [Column("SYS_CODE")]
        public int? SYS_CODE { get; set; }

        /// <summary>
        /// Gets or sets the value of "storniert (Teil A)".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information im Teil A technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS_A")]
        public DateTime? SYS_BIS_A { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer des Unternehmens im Heimatland".
        /// </summary>
        /// <remarks>
        /// Angabe der original Antragsteller-Registriernummer für AUM-Betriebe aus deren Land
        /// </remarks>
        [Column("BNR15_HOME")]
        public decimal? BNR15_HOME { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beantragte bzw. festgestellte stilllegungsfähige Fläche".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("DAVON_STL")]
        public decimal? DAVON_STL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Festgestellte Brutto-LF für beantragten Nutzcode".
        /// </summary>
        /// <remarks>
        /// Größe in ha (ab 2015 mit 4 Nachkommastellen, vorher 2)
        /// </remarks>
        [Column("FEST_LFBNC")]
        public decimal? FEST_LFBNC { get; set; }

        /// <summary>
        /// Gets or sets the value of "Agrarumweltmaßnahme liegt vor".
        /// </summary>
        [Column("IS_AUM")]
        [Required]
        public int? IS_AUM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Antragsfläche in Stilllegungsabgleich einbeziehen".
        /// </summary>
        [Column("IS_STL")]
        public int? IS_STL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art der ökologischen Vorrangfläche".
        /// </summary>
        [Column("ART_OEVF")]
        public int? ART_OEVF { get; set; }

    }
}
