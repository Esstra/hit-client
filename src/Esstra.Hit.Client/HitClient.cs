namespace Esstra.Hit.Client
{
    using Esstra.Hit.Client.Operations;

    using Microsoft.Extensions.Options;

    public class HitClient
    {
        protected HitClient()
        {

        }

        public HitClient(HttpClient httpClient, IOptions<HitClientOptions> options)
        {
            if (options.Value == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            httpClient.BaseAddress = options.Value.BaseAddress != null 
                ? new Uri($"{options.Value.BaseAddress.ToString().TrimEnd('/')}/")
                : HitBaseAddresses.Production;

            Entities = new EntityOperations(httpClient);
        }

        public virtual EntityOperations Entities { get; set; }
    }
}