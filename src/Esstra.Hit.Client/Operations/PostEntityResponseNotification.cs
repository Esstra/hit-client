namespace Esstra.Hit.Client.Operations
{
    using System.Text.Json.Serialization;

    public class PostEntityResponseNotification
    {
        public string? Message { get; set; }

        [JsonPropertyName("Schwere")]
        public int? Severity { get; set; }
    }
}
