namespace Esstra.Hit.Client
{
    /// <summary>
    /// A collection of all valid base addresses.
    /// </summary>
    public static class HitBaseAddresses
    {
        /// <summary>
        /// Gets the base address that points to the test environment (https://www.hi-tier.de/HitCom3/).
        /// </summary>
        public static readonly Uri Production = new("https://www.hi-tier.de/HitCom3/");

        /// <summary>
        /// Gets the base address that points to the test environment (https://www.hi-tier.de/HitTest3/).
        /// </summary>
        public static readonly Uri Test = new("https://www.hi-tier.de/HitTest3/");
    }
}
