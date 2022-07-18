namespace Esstra.Hit.Client.Operations
{
    using Esstra.Hit.Client.Converters;

    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class GetEntityResponse<TEntity>
    {
        [JsonPropertyName("cache_secret")]
        public string? CacheSecret { get; set; }

        [JsonPropertyName("anfrage")]
        public GetEntityResponseRequest Request { get; set; }

        [JsonPropertyName("antworten")]
        public IEnumerable<GetEntityResponseReplies> Replies { get; set; }

        [JsonPropertyName("statistik")]
        public GetEntityResponseStatistics Statistics { get; set; }

        [JsonPropertyName("daten")]
        [JsonConverter(typeof(GetEntityResponseItemsConverterFactory))]
        public IEnumerable<TEntity> Items { get; set; }
    }
}
