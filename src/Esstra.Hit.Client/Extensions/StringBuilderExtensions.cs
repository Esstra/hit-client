namespace System.Text
{
    internal static class StringBuilderExtensions
    {
        internal static void AddToQueryString(this StringBuilder stringBuilder, string key, string? value)
        {
            if (stringBuilder == null)
            {
                throw new ArgumentNullException(nameof(stringBuilder));
            }

            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (!string.IsNullOrEmpty(value))
            {
                stringBuilder.Append($"{Uri.EscapeDataString(key)}={Uri.EscapeDataString(value)}&");
            }
        }

        internal static void AddToQueryString(this StringBuilder stringBuilder, string key, int? value)
        {
            stringBuilder.AddToQueryString(key, value?.ToString());
        }
    }
}
