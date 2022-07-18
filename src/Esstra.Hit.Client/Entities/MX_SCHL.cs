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
    /// Slaugther notification with reference to EU, memberstate exchange
    /// </summary>
    [Entity("MX_SCHL")]
    public class MX_SCHL
    {
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
        /// Gets or sets the value of "ear tag".
        /// </summary>
        /// <remarks>
        /// ear tag number for identification of the animal in numerical format (for member state exchange)
        /// </remarks>
        [Column("MX_EARTG")]
        [Required]
        public decimal? MX_EARTG { get; set; }

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
        /// Gets the value of "way of notification, reporting channel".
        /// </summary>
        /// <remarks>
        /// reporting channel (mail, voice response, online internet, batch...)
        /// </remarks>
        [Column("MX_NTF_WAY")]
        public int? MX_NTF_WAY { get; set; }

        /// <summary>
        /// Gets or sets the value of "special slaughter information from Austria".
        /// </summary>
        /// <remarks>
        /// special slaughter information for weight calculation - Zurichtform
        /// </remarks>
        [Column("MX_SLA_AUS")]
        public int? MX_SLA_AUS { get; set; }

        /// <summary>
        /// Gets or sets the value of "date of slaughter or death".
        /// </summary>
        /// <remarks>
        /// date of slaughter or death (for member state exchange)
        /// </remarks>
        [Column("MX_SLA_DAT")]
        [Required]
        public DateOnly? MX_SLA_DAT { get; set; }

        /// <summary>
        /// Gets or sets the value of "weight of animal slaughtered".
        /// </summary>
        /// <remarks>
        /// weight of carcase (for member state exchange)
        /// </remarks>
        [Column("MX_SLA_WEI")]
        public decimal? MX_SLA_WEI { get; set; }

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
        /// Gets the value of "internal cluster".
        /// </summary>
        /// <remarks>
        /// for internal use
        /// </remarks>
        [Column("MX_SYS_CLU")]
        public int? MX_SYS_CLU { get; set; }

        /// <summary>
        /// Gets the value of "end timestamp".
        /// </summary>
        /// <remarks>
        /// timestamp until when data is valid
        /// </remarks>
        [Column("MX_SYS_BIS")]
        public DateTime? MX_SYS_BIS { get; set; }

        /// <summary>
        /// Gets the value of "annunciator, personal sub-number".
        /// </summary>
        /// <remarks>
        /// sub-number of person within organisation, responsible for data notification/notification
        /// </remarks>
        [Column("MX_NTF_MBN")]
        public int? MX_NTF_MBN { get; set; }

        /// <summary>
        /// Gets the value of "annunciator, registration number".
        /// </summary>
        /// <remarks>
        /// registration number of holding or organisation, responsible for data notification
        /// </remarks>
        [Column("MX_NTF_BNR")]
        public decimal? MX_NTF_BNR { get; set; }

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

    }
}
