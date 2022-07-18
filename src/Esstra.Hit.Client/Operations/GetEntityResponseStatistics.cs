namespace Esstra.Hit.Client.Operations
{
    using System.Text.Json.Serialization;

    public class GetEntityResponseStatistics
    {
        [JsonPropertyName("dauer_ticks")]
        public int? DurationTicks { get; set; }

        [JsonPropertyName("dauer_millis")]
        public int? DurationMilliseconds { get; set; }

        [JsonPropertyName("dauer_fmt")]
        public string? DurationFormatted { get; set; }

        [JsonPropertyName("zeilen_total")]
        public int? TotalLines { get; set; }

        [JsonPropertyName("zeilen_basis")]
        public int? TotalBases { get; set; }

        [JsonPropertyName("maxschwere")]
        public int? MaxSeverity { get; set; }
    }
}