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
    /// Zahlungsansprüche, Grunddaten (Sicht für Eigentümer/Besitzer mit Änderungen an ZA-Serien)
    /// </summary>
    [Entity("ZA_EB_GRUN")]
    public class ZA_EB_GRUN
    {
        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Serie".
        /// </summary>
        /// <remarks>
        /// Seriennummer des Zahlungsanspruchs als 1. Teil der Identifikation
        /// </remarks>
        [Column("ZA_SERIE")]
        public Int64? ZA_SERIE { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlungsanspruchs-Land".
        /// </summary>
        /// <remarks>
        /// Land das den ZA ausgegeben hat. Dient mit Serie und Nr zur Identifikation.
        /// </remarks>
        [Column("ZA_LAND")]
        public int? ZA_LAND { get; set; }

        /// <summary>
        /// Gets or sets the value of "Data-Timestamp von".
        /// </summary>
        /// <remarks>
        /// SYS_VON des Datensatzes
        /// </remarks>
        [Column("DATA_VON")]
        public DateTime? DATA_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Registriernummer für Betrieb, Langform mit B.Land und Staat
        /// </remarks>
        [Column("BNR15")]
        public decimal? BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "Stornobetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung storniert hat
        /// </remarks>
        [Column("STRN_BNR")]
        public decimal? STRN_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldemitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_MBN")]
        public int? MELD_MBN { get; set; }

        /// <summary>
        /// Gets or sets the value of "Meldebetrieb".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer die Meldung abgesetzt hat
        /// </remarks>
        [Column("MELD_BNR")]
        public decimal? MELD_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "ZA-Ausgabe Betriebsnummer".
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der ursprünglichen Ausgabe
        /// </remarks>
        [Column("ZA_AG_BNR")]
        public decimal? ZA_AG_BNR { get; set; }

        /// <summary>
        /// Gets or sets the value of "Art der Ausgabe des Zahlungsanspruchs".
        /// </summary>
        /// <remarks>
        /// Ausgabeart gemäß der Entstehung als Erstzuteilung, Nationale Reserve usw.
        /// </remarks>
        [Column("ZA_ART_AUS")]
        public int? ZA_ART_AUS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Milch-Erhöhung 2006".
        /// </summary>
        /// <remarks>
        /// potentielle Erhöhung des Wertes
        /// </remarks>
        [Column("ZA_ME_06")]
        public decimal? ZA_ME_06 { get; set; }

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
        /// Gets or sets the value of "Basiswert des Zahlungsanspruchs bei Ausgabe (ohne BIB)".
        /// </summary>
        /// <remarks>
        /// Wert in Euro mit 2 Nachkommastellen ohne betriebsindividuelle Beihilfe
        /// </remarks>
        [Column("ZA_W_BASIS")]
        public decimal? ZA_W_BASIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Wert des Zahlungsanspruchs bei Ausgabe".
        /// </summary>
        /// <remarks>
        /// Wert in Euro mit 2 Nachkommastellen (damit auf Cent genau)
        /// </remarks>
        [Column("ZA_AWERT")]
        public decimal? ZA_AWERT { get; set; }

        /// <summary>
        /// Gets or sets the value of "Ende der Gültigkeit des Zahkungsanspruches".
        /// </summary>
        /// <remarks>
        /// erste Mikrosekunde an dem der ZA nicht mehr gültig ist
        /// </remarks>
        [Column("ZA_GR_BIS")]
        public DateTime? ZA_GR_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginnzeitpunkt des Zahlungsanspruchs, Begründung / Ausgabe".
        /// </summary>
        /// <remarks>
        /// Zeitpunkt der Verfügbarkeit und nicht Bescheidsdatum
        /// </remarks>
        [Column("ZA_GR_VON")]
        public DateTime? ZA_GR_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Beginnzeitpunkt der Wirksamkeit des Zahlungsanspruchs für die Nationale Obergrenze".
        /// </summary>
        /// <remarks>
        /// nur gleich oder nach Begründung / Ausgabe (ZA_GR_VON)
        /// </remarks>
        [Column("ZA_GR_WRK")]
        public DateTime? ZA_GR_WRK { get; set; }

        /// <summary>
        /// Gets or sets the value of "Region des Bewirtschaftungslandes".
        /// </summary>
        /// <remarks>
        /// Region der Belegenheit der Fläche die den ZA begründet hat
        /// </remarks>
        [Column("ZA_REG_FL")]
        public int? ZA_REG_FL { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Obergrenze des Intervalls".
        /// </summary>
        /// <remarks>
        /// Intervallobergrenze innerhalb der Serie als 2. Teil der Identifikation eines Intervalls
        /// </remarks>
        [Column("ZA_NR_BIS")]
        public Int64? ZA_NR_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "Zahlunganspruchs-Nummer Untergrenze des Intervalls".
        /// </summary>
        /// <remarks>
        /// Intervalluntergrenze innerhalb der Serie als 2. Teil der Identifikation eines Intervalls
        /// </remarks>
        [Column("ZA_NR_VON")]
        public Int64? ZA_NR_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "storniert".
        /// </summary>
        /// <remarks>
        /// Storno-Zeitpunkt, ab wann die Information technisch nicht meht gültig ist
        /// </remarks>
        [Column("SYS_BIS")]
        public DateTime? SYS_BIS { get; set; }

        /// <summary>
        /// Gets or sets the value of "gespeichert".
        /// </summary>
        /// <remarks>
        /// Speichern-Zeitpunkt, ab wann die Information technisch gültig ist
        /// </remarks>
        [Column("SYS_VON")]
        public DateTime? SYS_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "Stornomitbenutzer".
        /// </summary>
        /// <remarks>
        /// Mitbenutzernummer die Meldung storniert hat
        /// </remarks>
        [Column("STRN_MBN")]
        public int? STRN_MBN { get; set; }

    }
}
