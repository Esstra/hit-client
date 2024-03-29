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
    /// Export notification, memberstate exchange
    /// </summary>
    [Entity("MX_EXP")]
    public class MX_EXP
    {
        /// <summary>
        /// Gets or sets the value of "date of birth".
        /// </summary>
        /// <remarks>
        /// date of birth the animal (for member state exchange)
        /// </remarks>
        [Column("MX_BIR_DAT")]
        public DateOnly? MX_BIR_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "number of holding".
        /// </summary>
        /// <remarks>
        /// registration number of holding, long format (for member state exchange)
        /// </remarks>
        [Column("MX_BNR15")]
        [Required]
        public decimal? MX_BNR15 { get; set; }

        /// <summary>
        /// Gets or sets the value of "number of holding of origin".
        /// </summary>
        /// <remarks>
        /// holding of origin, i.e. where birth, first tagging or import happened (for member state exchange)
        /// </remarks>
        [Column("MX_BNR15_O")]
        public decimal? MX_BNR15_O { get; set; }

        /// <summary>
        /// Gets or sets the value of "original breed or colour".
        /// </summary>
        /// <remarks>
        /// breed or colour code of sending member state (for member state exchange)
        /// </remarks>
        [Column("MX_BRE_ORG")]
        public int? MX_BRE_ORG { get; set; }

        /// <summary>
        /// Gets or sets the value of "unified breed code".
        /// </summary>
        /// <remarks>
        /// unified breed code of the animal within EC (for member state exchange)
        /// </remarks>
        [Column("MX_BRE_UNI")]
        public Int64? MX_BRE_UNI { get; set; }

        /// <summary>
        /// Gets or sets the value of "calving status".
        /// </summary>
        /// <remarks>
        /// is calving state of animal known (for member state exchange)
        /// </remarks>
        [Column("MX_CALF_ST")]
        public int? MX_CALF_ST { get; set; }

        /// <summary>
        /// Gets or sets the value of "ear tag".
        /// </summary>
        /// <remarks>
        /// ear tag number for identification of the animal in numerical format (for member state exchange)
        /// </remarks>
        [Column("MX_EARTG")]
        [Required]
        public decimal? MX_EARTG { get; set; }

        /// <summary>
        /// Gets or sets the value of "old ear tag, non-standard format".
        /// </summary>
        /// <remarks>
        /// ear tag number in old alpha-numerical non standard format (for member state exchange)
        /// </remarks>
        [Column("MX_EARTG_A")]
        public string? MX_EARTG_A { get; set; }

        /// <summary>
        /// Gets or sets the value of "ear tag father".
        /// </summary>
        /// <remarks>
        /// ear tag number of father animal in numerical format (for member state exchange)
        /// </remarks>
        [Column("MX_EARTG_F")]
        public decimal? MX_EARTG_F { get; set; }

        /// <summary>
        /// Gets or sets the value of "ear tag mother".
        /// </summary>
        /// <remarks>
        /// ear tag number of mother animal in numerical format (for member state exchange)
        /// </remarks>
        [Column("MX_EARTG_M")]
        public decimal? MX_EARTG_M { get; set; }

        /// <summary>
        /// Gets or sets the value of "date of export".
        /// </summary>
        [Column("MX_EXP_DAT")]
        [Required]
        public DateOnly? MX_EXP_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "date of notification".
        /// </summary>
        /// <remarks>
        /// date when notification was registered
        /// </remarks>
        [Column("MX_NTF_DAT")]
        [Required]
        public DateOnly? MX_NTF_DAT { get; set; }

        /// <summary>
        /// Gets the value of "annunciator, personal sub-number".
        /// </summary>
        /// <remarks>
        /// sub-number of person within organisation, responsible for data notification/notification
        /// </remarks>
        [Column("MX_NTF_MBN")]
        public int? MX_NTF_MBN { get; set; }

        /// <summary>
        /// Gets the value of "way of notification, reporting channel".
        /// </summary>
        /// <remarks>
        /// reporting channel (mail, voice response, online internet, batch...)
        /// </remarks>
        [Column("MX_NTF_WAY")]
        public int? MX_NTF_WAY { get; set; }

        /// <summary>
        /// Gets or sets the value of "premium state".
        /// </summary>
        /// <remarks>
        /// premium state livestock premium in member state or from state of origin (for member state exchange)
        /// </remarks>
        [Column("MX_PREM")]
        public int? MX_PREM { get; set; }

        /// <summary>
        /// Gets or sets the value of "sex of animal".
        /// </summary>
        /// <remarks>
        /// sex of animal (for member state exchange)
        /// </remarks>
        [Column("MX_SEX")]
        public int? MX_SEX { get; set; }

        /// <summary>
        /// Gets or sets the value of "state of birth".
        /// </summary>
        /// <remarks>
        /// ISO-Code of state where the animal was born (for member state exchange)
        /// </remarks>
        [Column("MX_STA_BIR")]
        public int? MX_STA_BIR { get; set; }

        /// <summary>
        /// Gets or sets the value of "state of destination".
        /// </summary>
        /// <remarks>
        /// ISO-Code of state where the animal is exported to (for member state exchange)
        /// </remarks>
        [Column("MX_STA_DES")]
        [Required]
        public int? MX_STA_DES { get; set; }

        /// <summary>
        /// Gets or sets the value of "member state".
        /// </summary>
        /// <remarks>
        /// ISO-Code of member state who provided data (for member state exchange)
        /// </remarks>
        [Column("MX_STA_MX")]
        [Required]
        public int? MX_STA_MX { get; set; }

        /// <summary>
        /// Gets or sets the value of "state of origin".
        /// </summary>
        /// <remarks>
        /// ISO-Code of state where the animal is coming from (for member state exchange)
        /// </remarks>
        [Column("MX_STA_ORG")]
        public int? MX_STA_ORG { get; set; }

        /// <summary>
        /// Gets the value of "end timestamp".
        /// </summary>
        /// <remarks>
        /// timestamp until when data is valid
        /// </remarks>
        [Column("MX_SYS_BIS")]
        public DateTime? MX_SYS_BIS { get; set; }

        /// <summary>
        /// Gets the value of "internal cluster".
        /// </summary>
        /// <remarks>
        /// for internal use
        /// </remarks>
        [Column("MX_SYS_CLU")]
        public int? MX_SYS_CLU { get; set; }

        /// <summary>
        /// Gets the value of "system state of data".
        /// </summary>
        /// <remarks>
        /// system state of data according to code set
        /// </remarks>
        [Column("MX_SYS_STA")]
        public int? MX_SYS_STA { get; set; }

        /// <summary>
        /// Gets the value of "begin timestamp".
        /// </summary>
        /// <remarks>
        /// timestamp of when data was physically stored in data base
        /// </remarks>
        [Column("MX_SYS_VON")]
        public DateTime? MX_SYS_VON { get; set; }

        /// <summary>
        /// Gets or sets the value of "veterinary ban within member state".
        /// </summary>
        /// <remarks>
        /// according to common code set (for member state exchange)
        /// </remarks>
        [Column("MX_VET_BAN")]
        public int? MX_VET_BAN { get; set; }

        /// <summary>
        /// Gets the value of "annunciator, registration number".
        /// </summary>
        /// <remarks>
        /// registration number of holding or organisation, responsible for data notification
        /// </remarks>
        [Column("MX_NTF_BNR")]
        public decimal? MX_NTF_BNR { get; set; }

    }
}
