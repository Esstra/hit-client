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
    /// Rinder Mortalität, gemäß Bestandsregister
    /// </summary>
    [Entity("RI_MORT")]
    public class RI_MORT
    {
        /// <summary>
        /// Gets or sets the value of "Männlich, Gesamt standartisierte Abweichung vom Erwartungswert, 6 Monate - 2 Jahre".
        /// </summary>
        [Column("M_SA_6M_2J")]
        public decimal? M_SA_6M_2J { get; set; }

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
        /// Gets the value of "Data-Timestamp von".
        /// </summary>
        /// <remarks>
        /// SYS_VON des Datensatzes
        /// </remarks>
        [Column("DATA_VON")]
        public DateTime? DATA_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, erwarteter Wert, 0 - 12 Wochen".
        /// </summary>
        [Column("G_EW_0_12W")]
        public decimal? G_EW_0_12W { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, erwarteter Wert, 3 - 6 Monate".
        /// </summary>
        [Column("G_EW_3_6M")]
        public decimal? G_EW_3_6M { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, erwarteter Wert, 6 Monate - 2 Jahre".
        /// </summary>
        [Column("G_EW_6M_2J")]
        public decimal? G_EW_6M_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, erwarteter Wert, über 2 Jahre".
        /// </summary>
        [Column("G_EW_AB_2J")]
        public decimal? G_EW_AB_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, erwarteter Wert, insgesamt".
        /// </summary>
        [Column("G_EW_GES")]
        public decimal? G_EW_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, Abweichungs-Klasse, 0 - 12 Wochen".
        /// </summary>
        [Column("G_KL_0_12W")]
        public int? G_KL_0_12W { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, Abweichungs-Klasse, 3 - 6 Monate".
        /// </summary>
        [Column("G_KL_3_6M")]
        public int? G_KL_3_6M { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, Abweichungs-Klasse, 6 Monate - 2 Jahre".
        /// </summary>
        [Column("G_KL_6M_2J")]
        public int? G_KL_6M_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, Abweichungs-Klasse, über 2 Jahre".
        /// </summary>
        [Column("G_KL_AB_2J")]
        public int? G_KL_AB_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, Abweichungs-Klasse, insgesamt".
        /// </summary>
        [Column("G_KL_GES")]
        public int? G_KL_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, Durchschnitt, Lebensjahre, 0 - 12 Wochen".
        /// </summary>
        [Column("G_LJ_0_12W")]
        public decimal? G_LJ_0_12W { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, Durchschnitt, Lebensjahre, 3 - 6 Monate".
        /// </summary>
        [Column("G_LJ_3_6M")]
        public decimal? G_LJ_3_6M { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, Durchschnitt, Lebensjahre, 6 Monate - 2 Jahre".
        /// </summary>
        [Column("G_LJ_6M_2J")]
        public decimal? G_LJ_6M_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, Durchschnitt, Lebensjahre, über 2 Jahre".
        /// </summary>
        [Column("G_LJ_AB_2J")]
        public decimal? G_LJ_AB_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, Durchschnitt, Lebensjahre, insgesamt".
        /// </summary>
        [Column("G_LJ_GES")]
        public decimal? G_LJ_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, Gesamt standartisierte Abweichung vom Erwartungswert, 0 - 12 Wochen".
        /// </summary>
        [Column("G_SA_0_12W")]
        public decimal? G_SA_0_12W { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, Gesamt standartisierte Abweichung vom Erwartungswert, 3 - 6 Monate".
        /// </summary>
        [Column("G_SA_3_6M")]
        public decimal? G_SA_3_6M { get; set; }

        /// <summary>
        /// Gets or sets the value of "frühe Verluste, gesamt".
        /// </summary>
        [Column("FRVER")]
        public int? FRVER { get; set; }

        /// <summary>
        /// Gets or sets the value of "frühe Verluste, gemeldet".
        /// </summary>
        [Column("FRVER_GEM")]
        public int? FRVER_GEM { get; set; }

        /// <summary>
        /// Gets or sets the value of "frühe Verluste, Schätzwert".
        /// </summary>
        [Column("FRVER_SCH")]
        public int? FRVER_SCH { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, Gesamt standartisierte Abweichung vom Erwartungswert, 6 Monate - 2 Jahre".
        /// </summary>
        [Column("G_SA_6M_2J")]
        public decimal? G_SA_6M_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, Gesamt standartisierte Abweichung vom Erwartungswert, über 2 Jahre".
        /// </summary>
        [Column("G_SA_AB_2J")]
        public decimal? G_SA_AB_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, Gesamt standartisierte Abweichung vom Erwartungswert, insgesamt".
        /// </summary>
        [Column("G_SA_GES")]
        public decimal? G_SA_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, realer Wert, 0 - 12 Wochen".
        /// </summary>
        [Column("G_TA_0_12W")]
        public int? G_TA_0_12W { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, realer Wert, 3 - 6 Monate".
        /// </summary>
        [Column("G_TA_3_6M")]
        public int? G_TA_3_6M { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, realer Wert, 6 Monate - 2 Jahre".
        /// </summary>
        [Column("G_TA_6M_2J")]
        public int? G_TA_6M_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, realer Wert, über 2 Jahre".
        /// </summary>
        [Column("G_TA_AB_2J")]
        public int? G_TA_AB_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Gesamt, realer Wert, insgesamt".
        /// </summary>
        [Column("G_TA_GES")]
        public int? G_TA_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, erwarteter Wert, 0 - 12 Wochen".
        /// </summary>
        [Column("M_EW_0_12W")]
        public decimal? M_EW_0_12W { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, erwarteter Wert, 3 - 6 Monate".
        /// </summary>
        [Column("M_EW_3_6M")]
        public decimal? M_EW_3_6M { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, erwarteter Wert, 6 Monate - 2 Jahre".
        /// </summary>
        [Column("M_EW_6M_2J")]
        public decimal? M_EW_6M_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geburten, erwartet".
        /// </summary>
        [Column("GEB_ERW")]
        public int? GEB_ERW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Geburten, gemeldet".
        /// </summary>
        [Column("GEB_GEM")]
        public int? GEB_GEM { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, erwarteter Wert, über 2 Jahre".
        /// </summary>
        [Column("M_EW_AB_2J")]
        public decimal? M_EW_AB_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, erwarteter Wert, insgesamt".
        /// </summary>
        [Column("M_EW_GES")]
        public decimal? M_EW_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, Abweichungs-Klasse, 0 - 12 Wochen".
        /// </summary>
        [Column("M_KL_0_12W")]
        public int? M_KL_0_12W { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, Abweichungs-Klasse, 3 - 6 Monate".
        /// </summary>
        [Column("M_KL_3_6M")]
        public int? M_KL_3_6M { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, Abweichungs-Klasse, 6 Monate - 2 Jahre".
        /// </summary>
        [Column("M_KL_6M_2J")]
        public int? M_KL_6M_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, Abweichungs-Klasse, über 2 Jahre".
        /// </summary>
        [Column("M_KL_AB_2J")]
        public int? M_KL_AB_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, Abweichungs-Klasse, insgesamt".
        /// </summary>
        [Column("M_KL_GES")]
        public int? M_KL_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, Durchschnitt, Lebensjahre, 0 - 12 Wochen".
        /// </summary>
        [Column("M_LJ_0_12W")]
        public decimal? M_LJ_0_12W { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, Durchschnitt, Lebensjahre, 3 - 6 Monate".
        /// </summary>
        [Column("M_LJ_3_6M")]
        public decimal? M_LJ_3_6M { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, Durchschnitt, Lebensjahre, 6 Monate - 2 Jahre".
        /// </summary>
        [Column("M_LJ_6M_2J")]
        public decimal? M_LJ_6M_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, Durchschnitt, Lebensjahre, über 2 Jahre".
        /// </summary>
        [Column("M_LJ_AB_2J")]
        public decimal? M_LJ_AB_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, Durchschnitt, Lebensjahre, insgesamt".
        /// </summary>
        [Column("M_LJ_GES")]
        public decimal? M_LJ_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, Gesamt standartisierte Abweichung vom Erwartungswert, 0 - 12 Wochen".
        /// </summary>
        [Column("M_SA_0_12W")]
        public decimal? M_SA_0_12W { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, Gesamt standartisierte Abweichung vom Erwartungswert, 3 - 6 Monate".
        /// </summary>
        [Column("M_SA_3_6M")]
        public decimal? M_SA_3_6M { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, Gesamt standartisierte Abweichung vom Erwartungswert, über 2 Jahre".
        /// </summary>
        [Column("M_SA_AB_2J")]
        public decimal? M_SA_AB_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, Gesamt standartisierte Abweichung vom Erwartungswert, insgesamt".
        /// </summary>
        [Column("M_SA_GES")]
        public decimal? M_SA_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, realer Wert, 0 - 12 Wochen".
        /// </summary>
        [Column("M_TA_0_12W")]
        public int? M_TA_0_12W { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, realer Wert, 3 - 6 Monate".
        /// </summary>
        [Column("M_TA_3_6M")]
        public int? M_TA_3_6M { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, realer Wert, 6 Monate - 2 Jahre".
        /// </summary>
        [Column("M_TA_6M_2J")]
        public int? M_TA_6M_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, realer Wert, über 2 Jahre".
        /// </summary>
        [Column("M_TA_AB_2J")]
        public int? M_TA_AB_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Männlich, realer Wert, insgesamt".
        /// </summary>
        [Column("M_TA_GES")]
        public int? M_TA_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Jahr der Bestandsberechnung".
        /// </summary>
        [Column("REG_JAHR")]
        [Required]
        public int? REG_JAHR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Jahresteil der Bestandsberechnung".
        /// </summary>
        [Column("REG_J_TEIL")]
        [Required]
        public int? REG_J_TEIL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, erwarteter Wert, 0 - 12 Wochen".
        /// </summary>
        [Column("W_EW_0_12W")]
        public decimal? W_EW_0_12W { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, erwarteter Wert, 3 - 6 Monate".
        /// </summary>
        [Column("W_EW_3_6M")]
        public decimal? W_EW_3_6M { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, erwarteter Wert, 6 Monate - 2 Jahre".
        /// </summary>
        [Column("W_EW_6M_2J")]
        public decimal? W_EW_6M_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, erwarteter Wert, über 2 Jahre".
        /// </summary>
        [Column("W_EW_AB_2J")]
        public decimal? W_EW_AB_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, erwarteter Wert, insgesamt".
        /// </summary>
        [Column("W_EW_GES")]
        public decimal? W_EW_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, Abweichungs-Klasse, 0 - 12 Wochen".
        /// </summary>
        [Column("W_KL_0_12W")]
        public int? W_KL_0_12W { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, Abweichungs-Klasse, 3 - 6 Monate".
        /// </summary>
        [Column("W_KL_3_6M")]
        public int? W_KL_3_6M { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, Abweichungs-Klasse, 6 Monate - 2 Jahre".
        /// </summary>
        [Column("W_KL_6M_2J")]
        public int? W_KL_6M_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, Abweichungs-Klasse, über 2 Jahre".
        /// </summary>
        [Column("W_KL_AB_2J")]
        public int? W_KL_AB_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, Abweichungs-Klasse, insgesamt".
        /// </summary>
        [Column("W_KL_GES")]
        public int? W_KL_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, Durchschnitt, Lebensjahre, 0 - 12 Wochen".
        /// </summary>
        [Column("W_LJ_0_12W")]
        public decimal? W_LJ_0_12W { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, Durchschnitt, Lebensjahre, 3 - 6 Monate".
        /// </summary>
        [Column("W_LJ_3_6M")]
        public decimal? W_LJ_3_6M { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, Durchschnitt, Lebensjahre, 6 Monate - 2 Jahre".
        /// </summary>
        [Column("W_LJ_6M_2J")]
        public decimal? W_LJ_6M_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, Durchschnitt, Lebensjahre, über 2 Jahre".
        /// </summary>
        [Column("W_LJ_AB_2J")]
        public decimal? W_LJ_AB_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, Durchschnitt, Lebensjahre, insgesamt".
        /// </summary>
        [Column("W_LJ_GES")]
        public decimal? W_LJ_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, Gesamt standartisierte Abweichung vom Erwartungswert, 0 - 12 Wochen".
        /// </summary>
        [Column("W_SA_0_12W")]
        public decimal? W_SA_0_12W { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, Gesamt standartisierte Abweichung vom Erwartungswert, 3 - 6 Monate".
        /// </summary>
        [Column("W_SA_3_6M")]
        public decimal? W_SA_3_6M { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, Gesamt standartisierte Abweichung vom Erwartungswert, 6 Monate - 2 Jahre".
        /// </summary>
        [Column("W_SA_6M_2J")]
        public decimal? W_SA_6M_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, Gesamt standartisierte Abweichung vom Erwartungswert, über 2 Jahre".
        /// </summary>
        [Column("W_SA_AB_2J")]
        public decimal? W_SA_AB_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, Gesamt standartisierte Abweichung vom Erwartungswert, insgesamt".
        /// </summary>
        [Column("W_SA_GES")]
        public decimal? W_SA_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, realer Wert, 0 - 12 Wochen".
        /// </summary>
        [Column("W_TA_0_12W")]
        public int? W_TA_0_12W { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, realer Wert, 3 - 6 Monate".
        /// </summary>
        [Column("W_TA_3_6M")]
        public int? W_TA_3_6M { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, realer Wert, 6 Monate - 2 Jahre".
        /// </summary>
        [Column("W_TA_6M_2J")]
        public int? W_TA_6M_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, realer Wert, über 2 Jahre".
        /// </summary>
        [Column("W_TA_AB_2J")]
        public int? W_TA_AB_2J { get; set; }

        /// <summary>
        /// Gets or sets the value of "Weiblich, realer Wert, insgesamt".
        /// </summary>
        [Column("W_TA_GES")]
        public int? W_TA_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "frühe Verluste binnen 2 Wochen, gemeldet".
        /// </summary>
        [Column("FRVER_GEM2")]
        public int? FRVER_GEM2 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anteil der Geburten an allen Geburten der Mütter (Nutzungsanteil)".
        /// </summary>
        [Column("ANTEIL_GES")]
        public decimal? ANTEIL_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anteil der Geburten auf Betrieb an allen Geburten der bereits verstorbenen Mütter (Nutzungsanteil)".
        /// </summary>
        [Column("ANTEIL_TOT")]
        public decimal? ANTEIL_TOT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl aller Kalbungen (noch lebende und bereits tote Mütter)".
        /// </summary>
        [Column("ANZ_K_GES")]
        public Int64? ANZ_K_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl der Kälber von toten Müttern, nur Kalbungen die stattgefunden haben".
        /// </summary>
        [Column("ANZ_K_TOT")]
        public Int64? ANZ_K_TOT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl aller Mütter insg. im Betrachtungszeitraum (3 Jahre) (noch lebende und bereits tote Mütter)".
        /// </summary>
        [Column("ANZ_M_GES")]
        public Int64? ANZ_M_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl der bereits verstorbenen Mütter".
        /// </summary>
        [Column("ANZ_M_TOT")]
        public Int64? ANZ_M_TOT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl der Kälber pro Jahr, berechnet anhand Zwischenkalbezeit.".
        /// </summary>
        /// <remarks>
        /// Schätzung der Anzahl der Kälber, aus der durchschn. Zwischenkalbezeit eines Betriebes
        /// </remarks>
        [Column("AVGA_K_J0")]
        public decimal? AVGA_K_J0 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl Kälber pro Jahr, berechnet aus durchs. Anz. Kalb. verstorb. Mütter und durch. Nutzungsdauer".
        /// </summary>
        [Column("AVGA_K_J1")]
        public decimal? AVGA_K_J1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Modifizierte Version von AVG_ANZ_KALB_J1 um die Zeit der ersten Trächtigkeit zu berücksichtigen.".
        /// </summary>
        /// <remarks>
        /// Hierzu werden zur Nutzungsdauer zusätzlich 285 Tage addiert.
        /// </remarks>
        [Column("AVGA_K_J1A")]
        public decimal? AVGA_K_J1A { get; set; }

        /// <summary>
        /// Gets or sets the value of "Durchschn. Anzahl Kalbungen je bereits verstorbenem Mutter, nur Kalbungen die stattgefunden haben".
        /// </summary>
        [Column("AVGA_K_TOT")]
        public decimal? AVGA_K_TOT { get; set; }

        /// <summary>
        /// Gets or sets the value of "durchschn. Anzahl Kalbungen je Mutter".
        /// </summary>
        /// <remarks>
        /// noch lebende und bereits tote Mütter, ANZ_KALB_GES / ANZ_MUT_GES
        /// </remarks>
        [Column("AVG_ANZ_K")]
        public decimal? AVG_ANZ_K { get; set; }

        /// <summary>
        /// Gets or sets the value of "Durchschn. Erstkalbealter, wobei nur Erstkalbungen auf diesem Betrieb berücksichtigt werden".
        /// </summary>
        [Column("AVG_EK_ALT")]
        public decimal? AVG_EK_ALT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Durchschn. Letztkalbealter, wobei nur letzte Kalbungen auf diesem Betrieb berücksichtigt werden".
        /// </summary>
        [Column("AVG_LK_ALT")]
        public decimal? AVG_LK_ALT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Durchschn. Nutzungsdauer von bereits verstorbenen Müttern, bez. auf gesamte Nutzungsdauer der Tiere".
        /// </summary>
        /// <remarks>
        /// daher nicht betriebsspezifisch. Spezifische Berechnung der durchschn. Nutzungsdauer noch zu prüfen
        /// </remarks>
        [Column("AVG_NTZD")]
        public decimal? AVG_NTZD { get; set; }

        /// <summary>
        /// Gets or sets the value of "Modifizierte Version von AVG_NTZD um Zeit der ersten Trächtigkeit zu berücksichtigen".
        /// </summary>
        /// <remarks>
        /// Hierzu werden zur Nutzungsdauer zusätzlich 285 Tage addiert.
        /// </remarks>
        [Column("AVG_NTZD1")]
        public decimal? AVG_NTZD1 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Durchschn. Restlebenszeit von bereits verstorb. Müttern, bez. auf gesamte Restlebenszeit der Tiere".
        /// </summary>
        /// <remarks>
        /// daher nicht betriebsspezifisch. Spezifische Berechnung der durchschn. Restlebenszeit noch zu prüfen
        /// </remarks>
        [Column("AVG_RLZ")]
        public decimal? AVG_RLZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Durchschnittliche Zwischenkalbezeit".
        /// </summary>
        [Column("AVG_ZKZ")]
        public decimal? AVG_ZKZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl aller Kalbungen bez. auf alle Tiere".
        /// </summary>
        /// <remarks>
        /// d.h. nicht nur Kalbungen am Betrieb  (noch lebende und bereits tote Mütter)
        /// </remarks>
        [Column("K_M_GES")]
        public Int64? K_M_GES { get; set; }

        /// <summary>
        /// Gets or sets the value of "Anzahl der Kälber der toten Mütter, auch Kalbungen, die nicht stattgefunden haben".
        /// </summary>
        [Column("K_M_TOT")]
        public Int64? K_M_TOT { get; set; }

    }
}
