namespace Microsoft.Extensions.DependencyInjection
{
    using Esstra.Hit.Client;

    using Microsoft.Extensions.Configuration;

    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="HitClient"/> and related services to the <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/></param>
        /// <returns>A reference to <paramref name="services"/> after the operation has completed.</returns>
        public static IServiceCollection AddHitClient(this IServiceCollection services)
        {
            services
                .AddHttpClient<HitClient>();

            services
                .AddTransient<HitClient>()
                .AddOptions<HitClientOptions>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="HitClient"/> and related services to the <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/></param>
        /// <param name="configure">The <see cref="HitClientOptions"/> passed to <see cref="HitClient"/></param>
        /// <returns>A reference to <paramref name="services"/> after the operation has completed.</returns>
        public static IServiceCollection AddHitClient(this IServiceCollection services, Action<HitClientOptions, IConfiguration> configure)
        {
            services
                .AddHttpClient<HitClient>();

            services
                .AddTransient<HitClient>()
                .AddOptions<HitClientOptions>()
                .Configure(configure);

            return services;
        }
    }
}
