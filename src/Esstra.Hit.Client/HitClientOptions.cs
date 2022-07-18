namespace Esstra.Hit.Client
{
    /// <summary>
    /// Optional default values used by <see cref="HitClient"/>.
    /// </summary>
    public class HitClientOptions
    {
        /// <summary>
        /// Gets or sets the base address of the HIT endpoint.
        /// </summary>
        /// <remarks>
        /// <see cref="HitBaseAddresses"/> contains a full list of valid endpoints.
        /// </remarks>
        public Uri? BaseAddress { get; set; }
    }
}