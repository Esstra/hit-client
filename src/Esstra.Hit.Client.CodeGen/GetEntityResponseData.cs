namespace Esstra.Hit.Client.CodeGen
{

    using System.Text.Json.Serialization;

    public class GetEntityResponseData
    {
        [JsonPropertyName("D_MELD_E_E")]
        public IEnumerable<GetEntityResponseDataItems> Items { get; set; }
    }
}