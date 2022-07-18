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
    /// EPI-Ergebnis epidemiologische Ermittlungen (dynamische und statische Werte)
    /// </summary>
    [Entity("EPI_ERGEB")]
    public class EPI_ERGEB
    {
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
        /// Gets or sets the value of "Laufende Nummer des Auftrags für das Seuchenobjekt".
        /// </summary>
        [Column("EPI_AUF_NR")]
        [Required]
        public int? EPI_AUF_NR { get; set; }

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
        /// Gets or sets the value of "Status des Betriebs".
        /// </summary>
        /// <remarks>
        /// Status des Betriebs (Ausbruchsbetrieb, Kontaktbetrieb,...)
        /// </remarks>
        [Column("EPI_STATUS")]
        [Required]
        public int? EPI_STATUS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ebene/Stufe des ermittelten Betriebs bei Rückwärts-Betrachtung".
        /// </summary>
        /// <remarks>
        /// Ebene/Stufe des ermittelten Betriebs (Rückwärts-Betrachtung aus Sicht des Ausgangsbetriebs
        /// </remarks>
        [Column("EPI_EBEN_B")]
        public int? EPI_EBEN_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ebene/Stufe des ermittelten Betriebs bei Vorwärts-Betrachtung".
        /// </summary>
        /// <remarks>
        /// Ebene/Stufe des ermittelten Betriebs (Vorwärts-Betrachtung aus Sicht des Ausgangsbetriebs
        /// </remarks>
        [Column("EPI_EBEN_F")]
        public int? EPI_EBEN_F { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für April, Rinder".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("RI_KON_APR")]
        public Int64? RI_KON_APR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum des ersten Kontakts bei Rückwärts-Betrachtung".
        /// </summary>
        [Column("EPI_DAT_B")]
        public DateOnly? EPI_DAT_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "Datum des ersten Kontakts bei Vorwärts-Betrachtung".
        /// </summary>
        [Column("EPI_DAT_F")]
        public DateOnly? EPI_DAT_F { get; set; }

        /// <summary>
        /// Gets or sets the value of "Dynamisches Maß, für Ermittlungszeitraum (Rückwärts)".
        /// </summary>
        /// <remarks>
        /// dyn. Wert im Seuchenfall für Ausbruchs- und Kontaktbetriebe als Grad der Vernetzung der Betriebe
        /// </remarks>
        [Column("EPI_GEW_B")]
        public Int64? EPI_GEW_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "Dynamisches Maß, für Ermittlungszeitraum (Vorwärts)".
        /// </summary>
        /// <remarks>
        /// dyn. Wert im Seuchenfall für Ausbruchs- und Kontaktbetriebe als Grad der Vernetzung der Betriebe
        /// </remarks>
        [Column("EPI_GEW_F")]
        public Int64? EPI_GEW_F { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für April, Gemischtbetrieb".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("GE_KON_APR")]
        public Int64? GE_KON_APR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für August, Gemischtbetrieb".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("GE_KON_AUG")]
        public Int64? GE_KON_AUG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Dezember, Gemischtbetrieb".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("GE_KON_DEZ")]
        public Int64? GE_KON_DEZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Jahresdurchschnitt der statischen Wochenwerte, Gemischtbetrieb".
        /// </summary>
        /// <remarks>
        /// Handelskontakte, unabhängig von Seuchen-Startbetrieben, gleitender Durchschnitt aus 52 Wochen
        /// </remarks>
        [Column("GE_KON_DUR")]
        public Int64? GE_KON_DUR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Februar,Gemischtbetrieb".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("GE_KON_FEB")]
        public Int64? GE_KON_FEB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Januar, Gemischtbetrieb".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("GE_KON_JAN")]
        public Int64? GE_KON_JAN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Juli, Gemischtbetrieb".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("GE_KON_JUL")]
        public Int64? GE_KON_JUL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Juni, Gemischtbetrieb".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("GE_KON_JUN")]
        public Int64? GE_KON_JUN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Mai, Gemischtbetrieb".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("GE_KON_MAI")]
        public Int64? GE_KON_MAI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für März, Gemischtbetrieb".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("GE_KON_MRZ")]
        public Int64? GE_KON_MRZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für November, Gemischtbetrieb".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("GE_KON_NOV")]
        public Int64? GE_KON_NOV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Oktober, Gemischtbetrieb".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("GE_KON_OKT")]
        public Int64? GE_KON_OKT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für September, Gemischtbetrieb".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("GE_KON_SEP")]
        public Int64? GE_KON_SEP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Standardabweichung der statischen Wochenwerte, Gemischtbetrieb".
        /// </summary>
        [Column("GE_KON_STA")]
        public Int64? GE_KON_STA { get; set; }

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
        /// Gets or sets the value of "Abgänge - Anzahl Summe Abgänge".
        /// </summary>
        [Column("RI_AB_SUM")]
        public Int64? RI_AB_SUM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Rinder Bestand aktuelles Jahr".
        /// </summary>
        /// <remarks>
        /// aus VOK_GEW
        /// </remarks>
        [Column("RI_BS_J")]
        public Int64? RI_BS_J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für August, Rinder".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("RI_KON_AUG")]
        public Int64? RI_KON_AUG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Dezember, Rinder".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("RI_KON_DEZ")]
        public Int64? RI_KON_DEZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Jahresdurchschnitt der statischen Wochenwerte, Rinder".
        /// </summary>
        /// <remarks>
        /// Handelskontakte, unabhängig von Seuchen-Startbetrieben, gleitender Durchschnitt aus 52 Wochen
        /// </remarks>
        [Column("RI_KON_DUR")]
        public Int64? RI_KON_DUR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Februar, Rinder".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("RI_KON_FEB")]
        public Int64? RI_KON_FEB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Januar, Rinder".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("RI_KON_JAN")]
        public Int64? RI_KON_JAN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Juli, Rinder".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("RI_KON_JUL")]
        public Int64? RI_KON_JUL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Juni, Rinder".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("RI_KON_JUN")]
        public Int64? RI_KON_JUN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Mai, Rinder".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("RI_KON_MAI")]
        public Int64? RI_KON_MAI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für März, Rinder".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("RI_KON_MRZ")]
        public Int64? RI_KON_MRZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für November, Rinder".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("RI_KON_NOV")]
        public Int64? RI_KON_NOV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Oktober, Rinder".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("RI_KON_OKT")]
        public Int64? RI_KON_OKT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für September, Rinder".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("RI_KON_SEP")]
        public Int64? RI_KON_SEP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Standardabweichung der statischen Wochenwerte, Rinder".
        /// </summary>
        [Column("RI_KON_STA")]
        public Int64? RI_KON_STA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Durchscnittliche Verweildauer Rinder in Tagen".
        /// </summary>
        [Column("RI_VERWEIL")]
        public decimal? RI_VERWEIL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zugänge - Anzahl Summe Zugänge".
        /// </summary>
        [Column("RI_ZU_SUM")]
        public Int64? RI_ZU_SUM { get; set; }

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
        /// Gets or sets the value of "Schafe-Abgangsvorgänge, Anzahl abgegebener Schafe".
        /// </summary>
        /// <remarks>
        /// oder Staffelung nach Umfanggrößenklassen
        /// </remarks>
        [Column("SZ_AB_SUMF")]
        public Int64? SZ_AB_SUMF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ziegen-Abgangsvorgänge, Anzahl abgegebener Ziegen".
        /// </summary>
        /// <remarks>
        /// oder Staffelung nach Umfanggrößenklassen
        /// </remarks>
        [Column("SZ_AB_ZUMF")]
        public Int64? SZ_AB_ZUMF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für April, Schafe/Ziegen".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("SZ_KON_APR")]
        public Int64? SZ_KON_APR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für August, Schafe/Ziegen".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("SZ_KON_AUG")]
        public Int64? SZ_KON_AUG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Dezember, Schafe/Ziegen".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("SZ_KON_DEZ")]
        public Int64? SZ_KON_DEZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Jahresdurchschnitt der statischen Wochenwerte, Schafe/Ziegen".
        /// </summary>
        /// <remarks>
        /// Handelskontakte, unabhängig von Seuchen-Startbetrieben, gleitender Durchschnitt aus 52 Wochen
        /// </remarks>
        [Column("SZ_KON_DUR")]
        public Int64? SZ_KON_DUR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Februar,Schafe/Ziegen".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("SZ_KON_FEB")]
        public Int64? SZ_KON_FEB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Januar, Schafe/Ziegen".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("SZ_KON_JAN")]
        public Int64? SZ_KON_JAN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Juli, Schafe/Ziegen".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("SZ_KON_JUL")]
        public Int64? SZ_KON_JUL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Juni, Schafe/Ziegen".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("SZ_KON_JUN")]
        public Int64? SZ_KON_JUN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Mai, Schafe/Ziegen".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("SZ_KON_MAI")]
        public Int64? SZ_KON_MAI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für März, Schafe/Ziegen".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("SZ_KON_MRZ")]
        public Int64? SZ_KON_MRZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für November, Schafe/Ziegen".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("SZ_KON_NOV")]
        public Int64? SZ_KON_NOV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Oktober, Schafe/Ziegen".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("SZ_KON_OKT")]
        public Int64? SZ_KON_OKT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für September, Schafe/Ziegen".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("SZ_KON_SEP")]
        public Int64? SZ_KON_SEP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Standardabweichung der statischen Wochenwerte, Schafe/Ziegen".
        /// </summary>
        [Column("SZ_KON_STA")]
        public Int64? SZ_KON_STA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl gemeldeter Schafe insgesamt (Gruppen 1+2+3)".
        /// </summary>
        /// <remarks>
        /// oder Staffelung nach Umfanggrößenklassen
        /// </remarks>
        [Column("SZ_STM_SUS")]
        public Int64? SZ_STM_SUS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl gemeldeter Ziegen insgesamt (Gruppen 1+2+3)".
        /// </summary>
        /// <remarks>
        /// oder Staffelung nach Umfanggrößenklassen
        /// </remarks>
        [Column("SZ_STM_ZUS")]
        public Int64? SZ_STM_ZUS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Durchscnittliche Verweildauer Schafe/Ziegen in Tagen".
        /// </summary>
        [Column("SZ_VERWEIL")]
        public decimal? SZ_VERWEIL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schafe-Zugangsvorgänge, Anzahl aufgenommener Schafe".
        /// </summary>
        /// <remarks>
        /// oder Staffelung nach Umfanggrößenklassen
        /// </remarks>
        [Column("SZ_ZU_SUMF")]
        public Int64? SZ_ZU_SUMF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ziegen-Zugangsvorgänge, Anzahl aufgenommener Ziegen".
        /// </summary>
        /// <remarks>
        /// oder Staffelung nach Umfanggrößenklassen
        /// </remarks>
        [Column("SZ_ZU_ZUMF")]
        public Int64? SZ_ZU_ZUMF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schweinebewegungs-Meldung, Umfang Abgänge".
        /// </summary>
        [Column("S_AB_UMF")]
        public Int64? S_AB_UMF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für April, Schweine".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("S_KON_APR")]
        public Int64? S_KON_APR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für August, Schweine".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("S_KON_AUG")]
        public Int64? S_KON_AUG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Dezember, Schweine".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("S_KON_DEZ")]
        public Int64? S_KON_DEZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Jahresdurchschnitt der statischen Wochenwerte, Schweine".
        /// </summary>
        /// <remarks>
        /// Handelskontakte, unabhängig von Seuchen-Startbetrieben, gleitender Durchschnitt aus 52 Wochen
        /// </remarks>
        [Column("S_KON_DUR")]
        public Int64? S_KON_DUR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Februar,Schweine".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("S_KON_FEB")]
        public Int64? S_KON_FEB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Januar, Schweine".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("S_KON_JAN")]
        public Int64? S_KON_JAN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Juli, Schweine".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("S_KON_JUL")]
        public Int64? S_KON_JUL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Juni, Schweine".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("S_KON_JUN")]
        public Int64? S_KON_JUN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Mai, Schweine".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("S_KON_MAI")]
        public Int64? S_KON_MAI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für März, Schweine".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("S_KON_MRZ")]
        public Int64? S_KON_MRZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für November, Schweine".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("S_KON_NOV")]
        public Int64? S_KON_NOV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für Oktober, Schweine".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("S_KON_OKT")]
        public Int64? S_KON_OKT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Statisches Maß für September, Schweine".
        /// </summary>
        /// <remarks>
        /// durchschnittl. wöchentl. Betriebskontakte des Monats
        /// </remarks>
        [Column("S_KON_SEP")]
        public Int64? S_KON_SEP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Standardabweichung der statischen Wochenwerte, Schweine".
        /// </summary>
        [Column("S_KON_STA")]
        public Int64? S_KON_STA { get; set; }

        /// <summary>
        /// Gets or sets the value of "Stichtagsmeldung, Umfang Gruppen 1+2+3".
        /// </summary>
        /// <remarks>
        /// Summe S_STM_UMF1 + S_STM_UMF2 + S_STM_UMF3
        /// </remarks>
        [Column("S_STM_UMF")]
        public Int64? S_STM_UMF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Durchscnittliche Verweildauer Schweine in Tagen".
        /// </summary>
        [Column("S_VERWEIL")]
        public decimal? S_VERWEIL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Schweinebewegungs-Meldung, Umfang Zugänge".
        /// </summary>
        [Column("S_ZU_UMF")]
        public Int64? S_ZU_UMF { get; set; }

        /// <summary>
        /// Gets or sets the value of "letztes Datum, das bei der Berechnung der statischen Werte berücksichtigt wurde".
        /// </summary>
        /// <remarks>
        /// ca. 4 Wochen vor heute
        /// </remarks>
        [Column("TI_KON_DAT")]
        [Required]
        public DateOnly? TI_KON_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ergebnis und Hinweise, EPI-Ermittlung (Rückwärts)".
        /// </summary>
        [Column("EPI_ERG_B")]
        public int? EPI_ERG_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ergebnis und Hinweise, EPI-Ermittlung (Vorwärts)".
        /// </summary>
        [Column("EPI_ERG_F")]
        public int? EPI_ERG_F { get; set; }

        /// <summary>
        /// Gets or sets the value of "Rang, EPI-Ermittlung (Rückwärts)".
        /// </summary>
        [Column("EPI_RANG_B")]
        public int? EPI_RANG_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "Rang, EPI-Ermittlung (Vorwärts)".
        /// </summary>
        [Column("EPI_RANG_F")]
        public int? EPI_RANG_F { get; set; }

        /// <summary>
        /// Gets or sets the value of "EPI-Marker".
        /// </summary>
        [Column("EPI_MARKER")]
        [Required]
        public int? EPI_MARKER { get; set; }

        /// <summary>
        /// Gets or sets the value of "EPI-Pfad backward".
        /// </summary>
        [Column("EPI_PFAD_B")]
        [Required]
        public string? EPI_PFAD_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "EPI-Pfad forward".
        /// </summary>
        [Column("EPI_PFAD_F")]
        [Required]
        public string? EPI_PFAD_F { get; set; }

        /// <summary>
        /// Gets or sets the value of "EPI-Marker Anzahl".
        /// </summary>
        [Column("EPI_M_ANZ")]
        public Int64? EPI_M_ANZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "EPI-Marker Detail".
        /// </summary>
        [Column("EPI_M_DET")]
        [Required]
        public string? EPI_M_DET { get; set; }

        /// <summary>
        /// Gets or sets the value of "EPI-Quelle".
        /// </summary>
        [Column("EPI_QUELLE")]
        [Required]
        public int? EPI_QUELLE { get; set; }

    }
}
