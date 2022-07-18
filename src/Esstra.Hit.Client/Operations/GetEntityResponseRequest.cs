namespace Esstra.Hit.Client.Operations
{
    using System.Text.Json.Serialization;

    public class GetEntityResponseRequest
    {
        [JsonPropertyName("befehl")]
        public string? Subcodes { get; set; }

        [JsonPropertyName("meldung")]
        public string? Entity { get; set; }

        [JsonPropertyName("spalten")]
        public string? Columns { get; set; }

        [JsonPropertyName("bedingung")]
        public string? Condition { get; set; }
    }
}