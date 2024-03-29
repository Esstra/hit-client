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
    /// Vor-Ort-Kontrolle nach VVVO und 820/97
    /// </summary>
    [Entity("VOK_VV")]
    public class VOK_VV
    {
        /// <summary>
        /// Gets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

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
        /// Gets or sets the value of "Bemerkung".
        /// </summary>
        [Column("BEMERKUNG")]
        [Required]
        public string? BEMERKUNG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Im HIT".
        /// </summary>
        /// <remarks>
        /// Anzahl Tiere laut HIT
        /// </remarks>
        [Column("VOK_HIT")]
        public int? VOK_HIT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Rinder in HIT, n. im Bestand, innerhalb Meldefrist".
        /// </summary>
        /// <remarks>
        /// Anzahl Rinder in HIT, die nicht im Bestand vorhanden sind, Meldefrist noch nicht überschritten
        /// </remarks>
        [Column("VOK_HIT_NF")]
        public int? VOK_HIT_NF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohrmarkenproblem, CC konform".
        /// </summary>
        /// <remarks>
        /// Anzahl Tiere mit einer, ohne oder unzulässigen Ohrmarke, davon nicht sanktionsrelevant
        /// </remarks>
        [Column("VOK_LOM1K")]
        public int? VOK_LOM1K { get; set; }

        /// <summary>
        /// Gets the value of "Cluster-Spalte".
        /// </summary>
        /// <remarks>
        /// Systemintern
        /// </remarks>
        [Column("SYS_CLUST")]
        public int? SYS_CLUST { get; set; }

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
        /// Gets or sets the value of "sofort behoben".
        /// </summary>
        /// <remarks>
        /// Mängel sofort behoben
        /// </remarks>
        [Column("VOK_BEH")]
        public int? VOK_BEH { get; set; }

        /// <summary>
        /// Gets the value of "Meldeweg".
        /// </summary>
        /// <remarks>
        /// Meldeweg (Post,IVR,IN...)
        /// </remarks>
        [Column("MELD_WG")]
        public int? MELD_WG { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Ankündigung".
        /// </summary>
        /// <remarks>
        /// Art der Ankündigung bei Vor-Ort-Kontrolle
        /// </remarks>
        [Column("VOK_ANKD")]
        [Required]
        public int? VOK_ANKD { get; set; }

        /// <summary>
        /// Gets the value of "Meldedatum".
        /// </summary>
        /// <remarks>
        /// Datum des Meldeeingang
        /// </remarks>
        [Column("MELD_DAT")]
        public DateOnly? MELD_DAT { get; set; }

        /// <summary>
        /// Gets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Datum".
        /// </summary>
        /// <remarks>
        /// Datum der Vor-Ort-Kontrolle
        /// </remarks>
        [Column("VOK_DAT")]
        [Required]
        public DateOnly? VOK_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Jahr der Risikoanalyse (Kontrolljahr)".
        /// </summary>
        /// <remarks>
        /// Jahresangabe, vierstellig
        /// </remarks>
        [Column("RIS_JAHR")]
        [Required]
        public int? RIS_JAHR { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Grund".
        /// </summary>
        /// <remarks>
        /// Grund für Vor-Ort-Kontrolle
        /// </remarks>
        [Column("VOK_GRND")]
        [Required]
        public int? VOK_GRND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vorgefunden".
        /// </summary>
        /// <remarks>
        /// Anzahl Rinder insgesamt / vorgefunden
        /// </remarks>
        [Column("VOK_GEFU")]
        public int? VOK_GEFU { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK durchgeführt oder nicht".
        /// </summary>
        /// <remarks>
        /// VOK durchgeführt oder Grund wenn nicht
        /// </remarks>
        [Column("VOK_DURCH")]
        [Required]
        public int? VOK_DURCH { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK gestattet".
        /// </summary>
        /// <remarks>
        /// Wurde Vor-Ort-Kontrolle gestattet
        /// </remarks>
        [Column("VOK_GEST")]
        [Required]
        public int? VOK_GEST { get; set; }

        /// <summary>
        /// Gets or sets the value of "innerhalb Frist behoben".
        /// </summary>
        /// <remarks>
        /// Mängel innerhalb Frist behoben
        /// </remarks>
        [Column("VOK_FRBEH")]
        public int? VOK_FRBEH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Maßgeblicher Bestand".
        /// </summary>
        /// <remarks>
        /// Anzahl Rinder vorgefunden abzüglich eigene Nachzucht ohne OM
        /// </remarks>
        [Column("VOK_MBE")]
        public int? VOK_MBE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Rinder nicht in HIT, Meldefrist überschritten".
        /// </summary>
        /// <remarks>
        /// Anzahl Rinder, die nicht in HIT geführt sind, Meldefrist überschritten
        /// </remarks>
        [Column("VOK_NOH_FU")]
        public int? VOK_NOH_FU { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohne LOM, eigene Nachzucht".
        /// </summary>
        /// <remarks>
        /// Tiere ohne Ohrmarke kleiner 7 Tage alt, eigene Nachzucht ohne Kennzeichnung
        /// </remarks>
        [Column("VOK_LT7")]
        public int? VOK_LT7 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohrmarkeproblem, nicht sanktionsrelevant  nach 2419/200".
        /// </summary>
        /// <remarks>
        /// Anzahl Tiere mit einer, ohne oder unzulässigen Ohrmarke, davon nicht sanktionsrelevant
        /// </remarks>
        [Column("VOK_LOMSA")]
        public int? VOK_LOMSA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Rinder nicht in HIT aufgrund Fehler Dritter".
        /// </summary>
        /// <remarks>
        /// Anzahl Rinder, die aufgrund Fehler Dritter nicht in HIT geführt sind
        /// </remarks>
        [Column("VOK_NOH_FD")]
        public int? VOK_NOH_FD { get; set; }

        /// <summary>
        /// Gets or sets the value of "Mit Mängel".
        /// </summary>
        /// <remarks>
        /// Anzahl Tiere mit festgestellten Mängel
        /// </remarks>
        [Column("VOK_MANG")]
        public int? VOK_MANG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Mit nur einer Ohrmarke".
        /// </summary>
        /// <remarks>
        /// Anzahl Tiere mit einer Ohrmarke
        /// </remarks>
        [Column("VOK_LOM1")]
        public int? VOK_LOM1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Rinder in HIT, n. im Bestand, Meldefrist überschritten".
        /// </summary>
        /// <remarks>
        /// Anzahl Rinder in HIT, die nicht im Bestand vorhanden sind, Meldefrist überschritten
        /// </remarks>
        [Column("VOK_HIT_FU")]
        public int? VOK_HIT_FU { get; set; }

        /// <summary>
        /// Gets or sets the value of "Im Betrieb vorhandene Pässe/Begleitpapiere".
        /// </summary>
        /// <remarks>
        /// Anzahl im Betrieb vorhandene Pässe/Begleitpapiere
        /// </remarks>
        [Column("VOK_PAP")]
        public int? VOK_PAP { get; set; }

        /// <summary>
        /// Gets or sets the value of "bestellte Rinderpässe".
        /// </summary>
        /// <remarks>
        /// bestellte Rinderpässe
        /// </remarks>
        [Column("VOK_PAPBST")]
        public int? VOK_PAPBST { get; set; }

        /// <summary>
        /// Gets or sets the value of "Pässe/Begleitp. nicht vollständig u. fehlerfrei geführt".
        /// </summary>
        /// <remarks>
        /// Gibt es Hinweise, dass Pässe/Begleitpapiere nicht vollständig und fehlerfrei geführt sind.
        /// </remarks>
        [Column("VOK_PAPHW")]
        public int? VOK_PAPHW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nicht vorhandene Rinder".
        /// </summary>
        /// <remarks>
        /// Anzahl geführte aber nicht vorhandene Rinder
        /// </remarks>
        [Column("VOK_NOVORH")]
        public int? VOK_NOVORH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nicht im Bestandsregister".
        /// </summary>
        /// <remarks>
        /// Anzahl nicht im Bestandsregister geführte Rinder
        /// </remarks>
        [Column("VOK_NOREG")]
        public int? VOK_NOREG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tiere ohne Papiere (Sanktion)".
        /// </summary>
        /// <remarks>
        /// Anzahl Tiere ohne Papiere, sanktionsrelevant
        /// </remarks>
        [Column("VOK_NOPAPS")]
        public int? VOK_NOPAPS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tiere ohne Papiere".
        /// </summary>
        /// <remarks>
        /// Anzahl Tiere ohne Papiere
        /// </remarks>
        [Column("VOK_NOPAP")]
        public int? VOK_NOPAP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohne LOM (Sanktion)".
        /// </summary>
        /// <remarks>
        /// Anzahl vorgefundener Tiere ohne Ohrmarke, sanktionsrelevant
        /// </remarks>
        [Column("VOK_NOLOMS")]
        public int? VOK_NOLOMS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohne LOM".
        /// </summary>
        /// <remarks>
        /// Anzahl vorgefundener Tiere ohne Ohrmarke
        /// </remarks>
        [Column("VOK_NOLOM")]
        public int? VOK_NOLOM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ohne oder mit unzulässiger Ohrmarke".
        /// </summary>
        /// <remarks>
        /// Anzahl Tiere ohne oder mit unzulässiger Ohrmarke
        /// </remarks>
        [Column("VOK_NOKLOM")]
        public int? VOK_NOKLOM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Rinder nicht in HIT, Meldefrist noch nicht abgelaufen".
        /// </summary>
        /// <remarks>
        /// Anzahl Rinder, die aufgrund nicht abgelaufener Meldefrist nicht in HIT geführt sind
        /// </remarks>
        [Column("VOK_NOH_NF")]
        public int? VOK_NOH_NF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Register aktuell und vollständig".
        /// </summary>
        /// <remarks>
        /// Bestandsregister ist aktuell und vollständig geführt
        /// </remarks>
        [Column("VOK_REGA")]
        public int? VOK_REGA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiterleitung an Vet-Amt".
        /// </summary>
        /// <remarks>
        /// Sanktionsrelevante Mängel zur Weiterleitung an Vet-Amt
        /// </remarks>
        [Column("VOK_VETAMT")]
        public int? VOK_VETAMT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Register elektronisch, handgeführt".
        /// </summary>
        /// <remarks>
        /// Bestandsregister wird elektronisch oder per Hand geführt
        /// </remarks>
        [Column("VOK_REGE")]
        public int? VOK_REGE { get; set; }

        /// <summary>
        /// Gets or sets the value of "In Stichprobe".
        /// </summary>
        /// <remarks>
        /// Anzahl Tiere in Stichprobe
        /// </remarks>
        [Column("VOK_SPROB")]
        public int? VOK_SPROB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Im Bestandsregister".
        /// </summary>
        /// <remarks>
        /// Anzahl Tiere im vorliegenden Register
        /// </remarks>
        [Column("VOK_REG")]
        public int? VOK_REG { get; set; }

        /// <summary>
        /// Gets or sets the value of "nicht zurück gesandte Pässe/Begleitpapiere".
        /// </summary>
        /// <remarks>
        /// Pass/Begleitpapiere, die nicht mehr vorhandenen Rindern zuzuordnen sind
        /// </remarks>
        [Column("VOK_PAPNOR")]
        public int? VOK_PAPNOR { get; set; }

        /// <summary>
        /// Gets or sets the value of "VOK Prüfer".
        /// </summary>
        /// <remarks>
        /// Prüfende Person (Mitbenutzeridentifikation)
        /// </remarks>
        [Column("VOK_PERS")]
        [Required]
        public string? VOK_PERS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Nicht zurück gesandter Papiere".
        /// </summary>
        /// <remarks>
        /// Anzahl nicht zurück gesandter Papiere
        /// </remarks>
        [Column("VOK_NOPAPZ")]
        public int? VOK_NOPAPZ { get; set; }

    }
}
