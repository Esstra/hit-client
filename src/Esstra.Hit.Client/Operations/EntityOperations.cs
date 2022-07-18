namespace Esstra.Hit.Client.Operations
{
    using Esstra.Hit.Client.Annotations;
    using Esstra.Hit.Client.Converters;

    using System.Net.Http.Json;
    using System.Reflection;
    using System.Text;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class EntityOperations
    {
        private readonly HttpClient? _httpClient;

        protected EntityOperations()
        {

        }

        public EntityOperations(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        /// <summary>
        /// Retrieves entities from the database.
        /// </summary>
        /// <typeparam name="TEntity">The target type to deserialize the response to.</typeparam>
        /// <param name="bnr"></param>
        /// <param name="condition">The condition (query) which will be executed by the database.</param>
        /// <param name="subcodes">The sub codes (e.g. "R" to read) used to query the database.</param>
        /// <param name="mbn"></param>
        /// <param name="pin"></param>
        /// <param name="mandant"></param>
        /// <param name="act"></param>
        /// <param name="cid"></param>
        /// <param name="cacheTimeout"></param>
        /// <param name="cacheSecret"></param>
        /// <returns>The response from the database.</returns>
        /// <exception cref="EntityNameMissingException"><typeparamref name="TEntity"/> is missing the <see cref="EntityAttribute"/>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="entity"/> is null or empty or <paramref name="columns"/> contains no elements.</exception>
        /// <exception cref="ColumnsMissingException">No property of <typeparamref name="TEntity"/> is decorated with <see cref="ColumnAttribute"/>.</exception>
        public Task<GetEntityResponse<TEntity>?> GetAsync<TEntity>(string bnr, string? condition = null, string? subcodes = null, string? mbn = null, string? pin = null, string? mandant = null, string? act = null, string? cid = null, int? cacheTimeout = null, string? cacheSecret = null)
        {
            if (string.IsNullOrWhiteSpace(bnr))
            {
                throw new ArgumentNullException(nameof(bnr));
            }

            if (string.IsNullOrWhiteSpace(pin) && string.IsNullOrWhiteSpace(cacheSecret))
            {
                throw new ArgumentNullException(nameof(pin));
            }

            if (string.IsNullOrWhiteSpace(cacheSecret) && cacheTimeout.HasValue)
            {
                throw new ArgumentNullException(nameof(cacheSecret));
            }

            var entity = GetEntityName<TEntity>();
            var columns = GetColumns<TEntity>();

            var urlBuilder = new StringBuilder();

            urlBuilder.Append($"api/hit/{entity}?");

            urlBuilder.AddToQueryString("columns", columns);
            urlBuilder.AddToQueryString("bnr", bnr);
            urlBuilder.AddToQueryString("condition", condition);
            urlBuilder.AddToQueryString("subcodes", subcodes);
            urlBuilder.AddToQueryString("mbn", mbn);
            urlBuilder.AddToQueryString("pin", pin);
            urlBuilder.AddToQueryString("mandant", mandant);
            urlBuilder.AddToQueryString("act", act);
            urlBuilder.AddToQueryString("cid", cid);
            urlBuilder.AddToQueryString("cacheTimeout", cacheTimeout);
            urlBuilder.AddToQueryString("cacheSecret", cacheSecret);

            urlBuilder.Length--;

            var requestUri = urlBuilder.ToString();

            return Task.Run(async () =>
            {
                var response = await _httpClient.GetStringAsync(requestUri).ConfigureAwait(false);

                return JsonSerializer.Deserialize<GetEntityResponse<TEntity>>(response);
            });
        }

        public Task PutAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PostEntityResponse?> PostAsync<TEntity>(TEntity values, string bnr, string? subcodes = null, string? aktion = null, string? partitionierung = null, string? mbn = null, string? pin = null, string? mandant = null, string? act = null, string? cid = null, int? cacheTimeout = null, string? cacheSecret = null)
        {
            if (string.IsNullOrWhiteSpace(bnr))
            {
                throw new ArgumentNullException(nameof(bnr));
            }

            if (string.IsNullOrWhiteSpace(pin) && string.IsNullOrWhiteSpace(cacheSecret))
            {
                throw new ArgumentNullException(nameof(pin));
            }

            if (string.IsNullOrWhiteSpace(cacheSecret) && cacheTimeout.HasValue)
            {
                throw new ArgumentNullException(nameof(cacheSecret));
            }

            var entity = GetEntityName<TEntity>();

            return Task.Run(async () =>
            {
                var urlBuilder = new StringBuilder();

                urlBuilder.Append($"api/hit/{entity}?");

                urlBuilder.AddToQueryString("bnr", bnr);
                urlBuilder.AddToQueryString("subcodes", subcodes);
                urlBuilder.AddToQueryString("aktion", aktion);
                urlBuilder.AddToQueryString("partitionierung", partitionierung);
                urlBuilder.AddToQueryString("mbn", mbn);
                urlBuilder.AddToQueryString("pin", pin);
                urlBuilder.AddToQueryString("mandant", mandant);
                urlBuilder.AddToQueryString("act", act);
                urlBuilder.AddToQueryString("cid", cid);
                urlBuilder.AddToQueryString("cacheTimeout", cacheTimeout);
                urlBuilder.AddToQueryString("cacheSecret", cacheSecret);

                urlBuilder.Length--;

                var requestUri = urlBuilder.ToString();

                var jsonSerializerOptions = new JsonSerializerOptions()
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                };

                jsonSerializerOptions.Converters.Add(new BoolConverter());
                jsonSerializerOptions.Converters.Add(new DateTimeConverter());
                jsonSerializerOptions.Converters.Add(new DateOnlyConverter());

                var response = await _httpClient.PostAsJsonAsync(requestUri, values, jsonSerializerOptions).ConfigureAwait(false);

                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                return JsonSerializer.Deserialize<PostEntityResponse>(content);
            });
        }

        internal static string GetColumns<TEntity>()
        {
            var properties = typeof(TEntity).GetProperties();

            var columns = new List<string>();

            foreach (var property in properties)
            {
                var columnAttribute = property.GetCustomAttribute<ColumnAttribute>();

                if (columnAttribute != null)
                {
                    columns.Add(columnAttribute.Name);
                }
            }

            if (!columns.Any())
            {
                throw new ColumnsMissingException();
            }

            return string.Join(';', columns);
        }

        internal static string GetEntityName<TEntity>()
        {
            var entityAttribute = typeof(TEntity).GetCustomAttribute<EntityAttribute>();

            var entityName = !string.IsNullOrWhiteSpace(entityAttribute?.Name)
                ? entityAttribute.Name
                : throw new EntityNameMissingException();

            return entityName;
        }
    }
}
