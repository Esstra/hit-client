namespace Esstra.Hit.Client.Operations
{
    using System.Text.Json.Serialization;

    public class GetEntityResponseReplies
    {
        [JsonPropertyName("text")]
        public string? Message { get; set; }

        [JsonPropertyName("schwere")]
        public int? Severity { get; set; }

        [JsonPropertyName("plausi")]
        public int? ErrorNumber { get; set; }

        [JsonPropertyName("spalten")]
        public int? Columns { get; set; }

        [JsonPropertyName("hauptnummer")]
        public int? MainNumber { get; set; }

        [JsonPropertyName("unternummer")]
        public int? SubNumber { get; set; }
    }
}