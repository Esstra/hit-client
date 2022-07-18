namespace Esstra.Hit.Client.CodeGen
{
    using System.Text.Json.Serialization;

    public class GetEntityResponse
    {
        [JsonPropertyName("daten")]
        public GetEntityResponseData Data { get; set; }
    }
}