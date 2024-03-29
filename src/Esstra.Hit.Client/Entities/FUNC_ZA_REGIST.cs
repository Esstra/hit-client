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
    /// Zahlungsanspruchsregister für Betrieb zum Zeitpunkt
    /// </summary>
    [Entity("FUNC_ZA_REGIST")]
    public class FUNC_ZA_REGIST
    {
        /// <summary>
        /// Gets or sets the value of "Grund der Änderung des Zeitwertes".
        /// </summary>
        [Column("ZA_ZW_AEN")]
        public int? ZA_ZW_AEN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Milch-Erhöhung 2006".
        /// </summary>
        /// <remarks>
        /// potentielle Erhöhung des Wertes
        /// </remarks>
        [Column("ZA_ME_06")]
        public decimal? ZA_ME_06 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betrag aus Nationaler Reserve".
        /// </summary>
        /// <remarks>
        /// ist auch im Wert des ZA enthalten, bedeutet damit davon
        /// </remarks>
        [Column("ZA_AUS_NR")]
        public decimal? ZA_AUS_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Basiswert des Zahlungsanspruchs bei Ausgabe (ohne BIB)".
        /// </summary>
        /// <remarks>
        /// Wert in Euro mit 2 Nachkommastellen ohne betriebsindividuelle Beihilfe
        /// </remarks>
        [Column("ZA_W_BASIS")]
        public decimal? ZA_W_BASIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Milchanteil 2005 am TOP".
        /// </summary>
        /// <remarks>
        /// ist auch im Wert des ZA enthalten, bedeutet damit davon
        /// </remarks>
        [Column("ZA_MP_05")]
        public decimal? ZA_MP_05 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Wert des BIB innerhalb des Zahlungsanspruchs bei Ausgabe".
        /// </summary>
        /// <remarks>
        /// Wert der betriebsindividuelle Beihilfe in Euro mit 2 Nachkommastellen
        /// </remarks>
        [Column("ZA_W_BIB")]
        public decimal? ZA_W_BIB { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe ob Satz aus zugepachteten ZA".
        /// </summary>
        [Column("ZA_IS_PAZ")]
        public bool? ZA_IS_PAZ { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchsintervall, externe Darstellung".
        /// </summary>
        /// <remarks>
        /// zur Vereinfachten Anlieferung von Land, Serie und Nr-Von und Bis
        /// </remarks>
        [Column("ZA_IV_EXT")]
        public string? ZA_IV_EXT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlungsanspruchs-Land".
        /// </summary>
        /// <remarks>
        /// Land das den ZA ausgegeben hat. Dient mit Serie und Nr zur Identifikation.
        /// </remarks>
        [Column("ZA_LAND")]
        public int? ZA_LAND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art des Zahlungsanspruchs".
        /// </summary>
        /// <remarks>
        /// Art gemäß der Entstehung als AL, DGL, BES, STL
        /// </remarks>
        [Column("ZA_ART")]
        public int? ZA_ART { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art des Zahlungsanspruchs bezüglich NR".
        /// </summary>
        /// <remarks>
        /// Urpsüngl. Ausgabeart ohne NR, bis 20% oder mehr als 20% kann sich im Zeitablauf ändern
        /// </remarks>
        [Column("ZA_ART_NR")]
        public int? ZA_ART_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zeitwert des Zahlungsanspruchs".
        /// </summary>
        /// <remarks>
        /// Wert in Euro mit 2 Nachkommastellen (damit auf Cent genau)
        /// </remarks>
        [Column("ZA_ZWERT")]
        public decimal? ZA_ZWERT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ende der Gültigkeit des Zeitwertes".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem Zeitwert nicht mehr gültig ist, damit ggf. identisch mit nächstem Beginn
        /// </remarks>
        [Column("ZA_ZW_BIS")]
        public DateTime? ZA_ZW_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Änderungsaktion, laufende Nummer".
        /// </summary>
        [Column("ZA_AKT_LFN")]
        public int? ZA_AKT_LFN { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Änderungsaktion (mit Level)".
        /// </summary>
        [Column("ZA_AKT_LEV")]
        public int? ZA_AKT_LEV { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Aktionskandidat".
        /// </summary>
        [Column("ZA_AKT_KAN")]
        public bool? ZA_AKT_KAN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginn der Gültigkeit des Zeitwertes".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem der neue Zeitwert gültig ist
        /// </remarks>
        [Column("ZA_ZW_VON")]
        public DateTime? ZA_ZW_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Ausgabe Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der ursprünglichen Ausgabe
        /// </remarks>
        [Column("ZA_AG_BNR")]
        public decimal? ZA_AG_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe ob Satz aus Zeitattributen".
        /// </summary>
        [Column("ZA_IS_ZW")]
        public bool? ZA_IS_ZW { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art der Ausgabe des Zahlungsanspruchs".
        /// </summary>
        /// <remarks>
        /// Ausgabeart gemäß der Entstehung als Erstzuteilung, Nationale Reserve usw.
        /// </remarks>
        [Column("ZA_ART_AUS")]
        public int? ZA_ART_AUS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Fristeinhaltung bei Übertragung für Antragstellung".
        /// </summary>
        /// <remarks>
        /// Hinweise zur Fristeinhaltung bei Übertragungen für Antragstellung
        /// </remarks>
        [Column("ZA_ANT_FRS")]
        public int? ZA_ANT_FRS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Liegt besondere Kennzeichnung als Obst - Gemüse - Speisekartoffel vor".
        /// </summary>
        /// <remarks>
        /// Berechtigt zur Aktivierung mit OGS-Flächen
        /// </remarks>
        [Column("ZA_OGS")]
        public bool? ZA_OGS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe ob Satz aus offenem Verpachtvorgang".
        /// </summary>
        [Column("ZA_IS_VPO")]
        public bool? ZA_IS_VPO { get; set; }

        /// <summary>
        /// Gets or sets the value of "Wert des Zahlungsanspruchs bei Ausgabe".
        /// </summary>
        /// <remarks>
        /// Wert in Euro mit 2 Nachkommastellen (damit auf Cent genau)
        /// </remarks>
        [Column("ZA_AWERT")]
        public decimal? ZA_AWERT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ende der Gültigkeit der Pacht für verpachtete ZA".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem die Pacht nicht mehr gültig ist, damit ggf. identisch mit nächstem Beginn
        /// </remarks>
        [Column("ZA_PAV_BIS")]
        public DateTime? ZA_PAV_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginn der Gültigkeit der Pacht für zugepachtete ZA".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem die Pacht gültig ist
        /// </remarks>
        [Column("ZA_PAZ_VON")]
        public DateTime? ZA_PAZ_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Grund der Änderung des Eigentums".
        /// </summary>
        [Column("ZA_EI_AEN")]
        public int? ZA_EI_AEN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginn der Gültigkeit des Eigentums".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem das neue Eigentum gültig ist
        /// </remarks>
        [Column("ZA_EI_VON")]
        public DateTime? ZA_EI_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Verpächter Betriebsnummer für zugepachtete ZA".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Person bzw. InVeKoS / Unternehmen
        /// </remarks>
        [Column("ZA_PAZ_BNR")]
        public decimal? ZA_PAZ_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ende der Gültigkeit des Eigentums".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem Eigentum nicht mehr gültig ist, damit ggf. identisch mit nächstem Beginn
        /// </remarks>
        [Column("ZA_EI_BIS")]
        public DateTime? ZA_EI_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Umfang des Intervalls in Hundertstel ZA".
        /// </summary>
        /// <remarks>
        /// auf Ar -Basis
        /// </remarks>
        [Column("ZA_IV_UMF")]
        public Int64? ZA_IV_UMF { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Obergrenze des Intervalls".
        /// </summary>
        /// <remarks>
        /// Intervallobergrenze innerhalb der Serie als 2. Teil der Identifikation eines Intervalls
        /// </remarks>
        [Column("ZA_NR_BIS")]
        public Int64? ZA_NR_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Pachtart (mit oder ohne Fläche) der zugepachteten ZA".
        /// </summary>
        [Column("ZA_PAZ_ART")]
        public int? ZA_PAZ_ART { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Eigentümer Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Person bzw. InVeKoS / Unternehmen
        /// </remarks>
        [Column("ZA_EI_BNR")]
        public decimal? ZA_EI_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe ob Satz aus verpachteten ZA".
        /// </summary>
        [Column("ZA_IS_PAV")]
        public bool? ZA_IS_PAV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe ob Satz aus Eigentum".
        /// </summary>
        [Column("ZA_IS_EI")]
        public bool? ZA_IS_EI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Untergrenze des Intervalls".
        /// </summary>
        /// <remarks>
        /// Intervalluntergrenze innerhalb der Serie als 2. Teil der Identifikation eines Intervalls
        /// </remarks>
        [Column("ZA_NR_VON")]
        public Int64? ZA_NR_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ende der Gültigkeit der Pacht für zugepachtete ZA".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem die Pacht nicht mehr gültig ist, damit ggf. identisch mit nächstem Beginn
        /// </remarks>
        [Column("ZA_PAZ_BIS")]
        public DateTime? ZA_PAZ_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Serie".
        /// </summary>
        /// <remarks>
        /// Seriennummer des Zahlungsanspruchs als 1. Teil der Identifikation
        /// </remarks>
        [Column("ZA_SERIE")]
        public Int64? ZA_SERIE { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Zukäufer-Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Person bzw. InVeKoS / Unternehmen
        /// </remarks>
        [Column("ZA_ZK_BNR")]
        public decimal? ZA_ZK_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginnzeitpunkt der Wirksamkeit des Zahlungsanspruchs für die Nationale Obergrenze".
        /// </summary>
        /// <remarks>
        /// nur gleich oder nach Begründung / Ausgabe (ZA_GR_VON)
        /// </remarks>
        [Column("ZA_GR_WRK")]
        public DateTime? ZA_GR_WRK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ende der Gültigkeit des Zahkungsanspruches".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem der ZA nicht mehr gültig ist
        /// </remarks>
        [Column("ZA_GR_BIS")]
        public DateTime? ZA_GR_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Region des Bewirtschaftungslandes".
        /// </summary>
        /// <remarks>
        /// Region der Belegenheit der Fläche die den ZA begründet hat
        /// </remarks>
        [Column("ZA_REG_FL")]
        public int? ZA_REG_FL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Pachtart (mit oder ohne Fläche) der verpachteten ZA".
        /// </summary>
        [Column("ZA_PAV_ART")]
        public int? ZA_PAV_ART { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginnzeitpunkt des Zahlungsanspruchs, Begründung / Ausgabe".
        /// </summary>
        /// <remarks>
        /// Zeitpunkt der Verfügbarkeit und nicht Bescheidsdatum
        /// </remarks>
        [Column("ZA_GR_VON")]
        public DateTime? ZA_GR_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Pächter-Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Person bzw. InVeKoS / Unternehmen die zupachtet
        /// </remarks>
        [Column("ZA_ZP_BNR")]
        public decimal? ZA_ZP_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vertrags-Transaktionsnummer für ZA-Verpachtungsvorgang".
        /// </summary>
        /// <remarks>
        /// vom System generierter Schlüssel, eindeutig innerhalb Verkäufer und Transaktion
        /// </remarks>
        [Column("ZA_VP_TAN")]
        public Int64? ZA_VP_TAN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginn der Gültigkeit der Pacht für verpachtete ZA".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem die Pacht gültig ist
        /// </remarks>
        [Column("ZA_PAV_VON")]
        public DateTime? ZA_PAV_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe ob Satz aus Grunddaten".
        /// </summary>
        [Column("ZA_IS_GR")]
        public bool? ZA_IS_GR { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Pächter Betriebsnummer für verpachtete ZA".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Person bzw. InVeKoS / Unternehmen
        /// </remarks>
        [Column("ZA_PAV_BNR")]
        public decimal? ZA_PAV_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe ob Satz aus offenem Verkaufsvorgang".
        /// </summary>
        [Column("ZA_IS_VKO")]
        public bool? ZA_IS_VKO { get; set; }

        /// <summary>
        /// Gets or sets the value of "Vertrags-Transaktionsnummer für ZA-Verkaufsvorgang".
        /// </summary>
        /// <remarks>
        /// vom System generierter Schlüssel, eindeutig innerhalb Verkäufer und Transaktion
        /// </remarks>
        [Column("ZA_VK_TAN")]
        public Int64? ZA_VK_TAN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe ob Milcherhöhung bereits durchgeführt".
        /// </summary>
        [Column("ZA_ME_DONE")]
        public bool? ZA_ME_DONE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ist der Anteil aus Nationalen Reserve größer 20 Prozent".
        /// </summary>
        [Column("ZA_NR_G_20")]
        public bool? ZA_NR_G_20 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Tabak-Erhöhung 2006".
        /// </summary>
        /// <remarks>
        /// In 2006 vorgenommene Erhöhung des Wertes
        /// </remarks>
        [Column("ZA_TB_06")]
        public decimal? ZA_TB_06 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe ob Satz aus Nutzungs-Rangfolge".
        /// </summary>
        [Column("ZA_IS_NR")]
        public bool? ZA_IS_NR { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Nutzungsart 2006".
        /// </summary>
        /// <remarks>
        /// Normale Nutzung oder Pseudo-Nutzung
        /// </remarks>
        [Column("ZA_NU_A_06")]
        public int? ZA_NU_A_06 { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Nutzungsart 2007".
        /// </summary>
        /// <remarks>
        /// Normale Nutzung oder Pseudo-Nutzung
        /// </remarks>
        [Column("ZA_NU_A_07")]
        public int? ZA_NU_A_07 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Paket-Land".
        /// </summary>
        /// <remarks>
        /// Land das das Paket ausgegeben hat. Dient mit Serie zur Identifikation.
        /// </remarks>
        [Column("ZA_P_LAND")]
        public int? ZA_P_LAND { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Nutzungsart".
        /// </summary>
        /// <remarks>
        /// Normale Nutzung oder Pseudo-Nutzung
        /// </remarks>
        [Column("ZA_NU_ART")]
        public int? ZA_NU_ART { get; set; }

        /// <summary>
        /// Gets or sets the value of "Paket-Identifikation mit Land und Serie".
        /// </summary>
        /// <remarks>
        /// zur Vereinfachten Darstellung von Paket-Land, und -Serie
        /// </remarks>
        [Column("ZA_P_EXT")]
        public string? ZA_P_EXT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Untergrenze des Intervalls - Paket".
        /// </summary>
        /// <remarks>
        /// Intervalluntergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_PK_NR_V")]
        public Int64? ZA_PK_NR_V { get; set; }

        /// <summary>
        /// Gets or sets the value of "Jahr der ZA-Nutzung".
        /// </summary>
        /// <remarks>
        /// Jahresangabe, vierstellig
        /// </remarks>
        [Column("ZA_NU_JAHR")]
        public int? ZA_NU_JAHR { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Nutzung Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Person bzw. InVeKoS / Unternehmen
        /// </remarks>
        [Column("ZA_NU_BNR")]
        public decimal? ZA_NU_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe ob Satz aus Paketdaten".
        /// </summary>
        [Column("ZA_IS_PK")]
        public bool? ZA_IS_PK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe ob Satz aus Nutzungsdaten".
        /// </summary>
        [Column("ZA_IS_NU")]
        public bool? ZA_IS_NU { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Nutzungsart 2005".
        /// </summary>
        /// <remarks>
        /// Normale Nutzung oder Pseudo-Nutzung
        /// </remarks>
        [Column("ZA_NU_A_05")]
        public int? ZA_NU_A_05 { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Nutzungsart 2008".
        /// </summary>
        /// <remarks>
        /// Normale Nutzung oder Pseudo-Nutzung
        /// </remarks>
        [Column("ZA_NU_A_08")]
        public int? ZA_NU_A_08 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginn der Gültigkeit der Paketzugehörigkeit".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem der ZA zum Paket zugehörig ist.
        /// </remarks>
        [Column("ZA_PK_VON")]
        public DateTime? ZA_PK_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Nutzungsart 2009".
        /// </summary>
        /// <remarks>
        /// Normale Nutzung oder Pseudo-Nutzung
        /// </remarks>
        [Column("ZA_NU_A_09")]
        public int? ZA_NU_A_09 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Obergrenze des Intervalls - Paket".
        /// </summary>
        /// <remarks>
        /// Intervallobergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_PK_NR_B")]
        public Int64? ZA_PK_NR_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "Paket-GVE".
        /// </summary>
        [Column("ZA_PK_GVE")]
        public decimal? ZA_PK_GVE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ende der Gültigkeit der Paketzugehörigkeit".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem ZA nicht mehr zum Paket gehört, damit ggf. identisch mit nächstem Beginn
        /// </remarks>
        [Column("ZA_PK_BIS")]
        public DateTime? ZA_PK_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Paket-Serie".
        /// </summary>
        /// <remarks>
        /// Seriennummer des Pakets, aus den ursprünglichen Entstehungs-ZA
        /// </remarks>
        [Column("ZA_P_SERIE")]
        public Int64? ZA_P_SERIE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zucker-Erhöhung 2006".
        /// </summary>
        /// <remarks>
        /// vorgenommene Erhöhung des Wertes in 2006, bzw. für nachträglich ausgegebene 1.Erhöhung
        /// </remarks>
        [Column("ZA_ZU_06")]
        public decimal? ZA_ZU_06 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Obergrenze des Intervalls - Nutzung".
        /// </summary>
        /// <remarks>
        /// Intervallobergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_NU_NR_B")]
        public Int64? ZA_NU_NR_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Untergrenze des Intervalls - Nutzrang".
        /// </summary>
        /// <remarks>
        /// Intervalluntergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_NR_NR_V")]
        public Int64? ZA_NR_NR_V { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Obergrenze des Intervalls - Nutzrang".
        /// </summary>
        /// <remarks>
        /// Intervallobergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_NR_NR_B")]
        public Int64? ZA_NR_NR_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe ob Satz aus beendeter Pacht stammt".
        /// </summary>
        [Column("ZA_IS_PR")]
        public bool? ZA_IS_PR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Angabe ob Satz aus Aktion Beriebs-Intervall".
        /// </summary>
        [Column("ZA_IS_BI")]
        public bool? ZA_IS_BI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Untergrenze des Intervalls - Grunddaten".
        /// </summary>
        /// <remarks>
        /// Intervalluntergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_GR_NR_V")]
        public Int64? ZA_GR_NR_V { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Obergrenze des Intervalls - Grunddaten".
        /// </summary>
        /// <remarks>
        /// Intervallobergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_GR_NR_B")]
        public Int64? ZA_GR_NR_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Untergrenze des Intervalls - Eigentum".
        /// </summary>
        /// <remarks>
        /// Intervalluntergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_EI_NR_V")]
        public Int64? ZA_EI_NR_V { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Obergrenze des Intervalls - Eigentum".
        /// </summary>
        /// <remarks>
        /// Intervallobergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_EI_NR_B")]
        public Int64? ZA_EI_NR_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Untergrenze des Intervalls - Aktions-Beriebs-Intervall".
        /// </summary>
        /// <remarks>
        /// Intervalluntergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_BI_NR_V")]
        public Int64? ZA_BI_NR_V { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Obergrenze des Intervalls - Aktions-Beriebs-Intervall".
        /// </summary>
        /// <remarks>
        /// Intervallobergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_BI_NR_B")]
        public Int64? ZA_BI_NR_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art des Zahlungsanspruchs (zusammengefasst)".
        /// </summary>
        /// <remarks>
        /// Art des Zahlungsanspruchs (normal, besonders, STL)
        /// </remarks>
        [Column("ZA_ART_NBS")]
        public int? ZA_ART_NBS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Grund der Übertragung (bei Verkauf, in Register-Funktion)".
        /// </summary>
        /// <remarks>
        /// normale Aktion, oder spezielle Ausnahme durch Behörde, wie z.B. Erbfolge
        /// </remarks>
        [Column("ZA_UEB_GRK")]
        public int? ZA_UEB_GRK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art der Übertragung (bei Verpachtung, in Register-Funktion)".
        /// </summary>
        /// <remarks>
        /// Verkauf, Pacht mit oder ohne Fläche, ggf. als Paket
        /// </remarks>
        [Column("ZA_UEB_AVP")]
        public int? ZA_UEB_AVP { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art der Übertragung (bei Verkauf, in Register-Funktion)".
        /// </summary>
        /// <remarks>
        /// Verkauf, Pacht mit oder ohne Fläche, ggf. als Paket
        /// </remarks>
        [Column("ZA_UEB_AVK")]
        public int? ZA_UEB_AVK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Laufende Zeilennummer im Register".
        /// </summary>
        [Column("ZA_REG_ZEI")]
        public int? ZA_REG_ZEI { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ist Satz Register konsistent".
        /// </summary>
        /// <remarks>
        /// wenn OK dann wahr 1 , sonst falsch 0
        /// </remarks>
        [Column("ZA_REG_KON")]
        public bool? ZA_REG_KON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Untergrenze des Intervalls - Pacht, zugepachtet".
        /// </summary>
        /// <remarks>
        /// Intervalluntergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_PZ_NR_V")]
        public Int64? ZA_PZ_NR_V { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Obergrenze des Intervalls - Pacht, zugepachtet".
        /// </summary>
        /// <remarks>
        /// Intervallobergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_PZ_NR_B")]
        public Int64? ZA_PZ_NR_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Untergrenze des Intervalls - Pacht, verpachtet".
        /// </summary>
        /// <remarks>
        /// Intervalluntergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_PV_NR_V")]
        public Int64? ZA_PV_NR_V { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Obergrenze des Intervalls - Pacht, verpachtet".
        /// </summary>
        /// <remarks>
        /// Intervallobergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_PV_NR_B")]
        public Int64? ZA_PV_NR_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginn der Gültigkeit ab wann die Pacht zurück gefallen ist".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem die Daten zu diesem Abschnitt gültig sind
        /// </remarks>
        [Column("ZA_PR_VON")]
        public DateTime? ZA_PR_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Untergrenze des Intervalls - Nutzung".
        /// </summary>
        /// <remarks>
        /// Intervalluntergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_PR_NR_V")]
        public Int64? ZA_PR_NR_V { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Obergrenze des Intervalls - Nutzung".
        /// </summary>
        /// <remarks>
        /// Intervallobergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_PR_NR_B")]
        public Int64? ZA_PR_NR_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Untergrenze des Intervalls - Verpachtung offen".
        /// </summary>
        /// <remarks>
        /// Intervalluntergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_PO_NR_V")]
        public Int64? ZA_PO_NR_V { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Obergrenze des Intervalls - Verpachtung offen".
        /// </summary>
        /// <remarks>
        /// Intervallobergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_PO_NR_B")]
        public Int64? ZA_PO_NR_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "Rangfolge für die Nutzung / Aktivierung".
        /// </summary>
        /// <remarks>
        /// Rang 1 bedeutet möglichst als erster, dann 2 bis N, 0 bedeutet gar nicht oder zuletzt
        /// </remarks>
        [Column("ZA_NU_RANG")]
        public Int64? ZA_NU_RANG { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Untergrenze des Intervalls - Nutzung".
        /// </summary>
        /// <remarks>
        /// Intervalluntergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_NU_NR_V")]
        public Int64? ZA_NU_NR_V { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Untergrenze des Intervalls - Zeitattribut".
        /// </summary>
        /// <remarks>
        /// Intervalluntergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_ZW_NR_V")]
        public Int64? ZA_ZW_NR_V { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Obergrenze des Intervalls - Zeitattribut".
        /// </summary>
        /// <remarks>
        /// Intervallobergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_ZW_NR_B")]
        public Int64? ZA_ZW_NR_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Untergrenze des Intervalls - Verkauf offen".
        /// </summary>
        /// <remarks>
        /// Intervalluntergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_VO_NR_V")]
        public Int64? ZA_VO_NR_V { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Obergrenze des Intervalls - Verkauf offen".
        /// </summary>
        /// <remarks>
        /// Intervallobergrenze innerhalb der Serie zur Identifikation des Original-Intervalls
        /// </remarks>
        [Column("ZA_VO_NR_B")]
        public Int64? ZA_VO_NR_B { get; set; }

        /// <summary>
        /// Gets or sets the value of "Grund der Übertragung (bei Verpachtung, in Register-Funktion)".
        /// </summary>
        /// <remarks>
        /// normale Aktion, oder spezielle Ausnahme durch Behörde, wie z.B. Erbfolge
        /// </remarks>
        [Column("ZA_UEB_GRP")]
        public int? ZA_UEB_GRP { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Nutzungsart 2010".
        /// </summary>
        /// <remarks>
        /// Normale Nutzung oder Pseudo-Nutzung
        /// </remarks>
        [Column("ZA_NU_A_10")]
        public int? ZA_NU_A_10 { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Nutzungsart 2011".
        /// </summary>
        /// <remarks>
        /// Normale Nutzung oder Pseudo-Nutzung
        /// </remarks>
        [Column("ZA_NU_A_11")]
        public int? ZA_NU_A_11 { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Nutzungsart 2012".
        /// </summary>
        /// <remarks>
        /// Normale Nutzung oder Pseudo-Nutzung
        /// </remarks>
        [Column("ZA_NU_A_12")]
        public int? ZA_NU_A_12 { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Nutzungsart 2013".
        /// </summary>
        /// <remarks>
        /// Normale Nutzung oder Pseudo-Nutzung
        /// </remarks>
        [Column("ZA_NU_A_13")]
        public int? ZA_NU_A_13 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Registriernummer für Betrieb, Langform mit B.Land und Staat
        /// </remarks>
        [Column("BNR15")]
        public decimal? BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Datenbasis im Register".
        /// </summary>
        /// <remarks>
        /// Info ob Eigentum, Pacht, Verpacht
        /// </remarks>
        [Column("ZA_AKT_BAS")]
        public int? ZA_AKT_BAS { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Nutzungsart 2014".
        /// </summary>
        /// <remarks>
        /// Normale Nutzung oder Pseudo-Nutzung
        /// </remarks>
        [Column("ZA_NU_A_14")]
        public int? ZA_NU_A_14 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zeitwert des Zahlungsanspruchs (virtuell, immer hochgerechnet)".
        /// </summary>
        /// <remarks>
        /// wenn ZA-Erhöhung durchgeführt ist Inhalt identisch zu ZA_ZWERT, andernfalls hier errechneter Wert
        /// </remarks>
        [Column("ZA_ZWERTV")]
        public decimal? ZA_ZWERTV { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zeitwert des Zahlungsanspruchs, Hochrechnung Antragstermin 2010".
        /// </summary>
        /// <remarks>
        /// korrigierter ZA_ZWERT zur schrittweisen Anpassung an regionalen Durchschnitt (Gleitflug)
        /// </remarks>
        [Column("ZA_ZW_H10")]
        public decimal? ZA_ZW_H10 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zeitwert des Zahlungsanspruchs, Hochrechnung Antragstermin 2011".
        /// </summary>
        /// <remarks>
        /// korrigierter ZA_ZWERT zur schrittweisen Anpassung an regionalen Durchschnitt (Gleitflug)
        /// </remarks>
        [Column("ZA_ZW_H11")]
        public decimal? ZA_ZW_H11 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zeitwert des Zahlungsanspruchs, Hochrechnung Antragstermin 2012".
        /// </summary>
        /// <remarks>
        /// korrigierter ZA_ZWERT zur schrittweisen Anpassung an regionalen Durchschnitt (Gleitflug)
        /// </remarks>
        [Column("ZA_ZW_H12")]
        public decimal? ZA_ZW_H12 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zeitwert des Zahlungsanspruchs, Hochrechnung Antragstermin 2013 - Endwert".
        /// </summary>
        /// <remarks>
        /// korrigierter ZA_ZWERT zur schrittweisen Anpassung an regionalen Durchschnitt (Gleitflug)
        /// </remarks>
        [Column("ZA_ZW_H13")]
        public decimal? ZA_ZW_H13 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zeitwert des Zahlungsanspruchs, ohne Hochrechnung".
        /// </summary>
        /// <remarks>
        /// analog echtem ZA_ZWERT aus ZA_ZEITATR
        /// </remarks>
        [Column("ZA_ZW_RAW")]
        public decimal? ZA_ZW_RAW { get; set; }

    }
}
