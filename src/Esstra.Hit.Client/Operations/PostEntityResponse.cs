namespace Esstra.Hit.Client.Operations
{
    using System.Text.Json.Serialization;

    public class PostEntityResponse
    {
        [JsonPropertyName("MaxSchwere")]
        public int? MaxSeverity { get; set; }

        [JsonPropertyName("Fehlerliste")]
        public IEnumerable<PostEntityResponseNotification> Notifications { get; set; }
    }
}
