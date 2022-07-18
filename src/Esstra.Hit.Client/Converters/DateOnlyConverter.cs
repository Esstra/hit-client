namespace Esstra.Hit.Client.Converters
{
    using System.Globalization;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class DateOnlyConverter : JsonConverter<DateOnly?>
    {
        public override DateOnly? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();

            return !string.IsNullOrWhiteSpace(value)
                ? DateOnly.ParseExact(value, "dd.MM.yyyy", CultureInfo.InvariantCulture)
                : null;
        }

        public override void Write(Utf8JsonWriter writer, DateOnly? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
            {
                writer.WriteStringValue(value.Value.ToString("dd.MM.yyyy"));
            }
            else if (options.DefaultIgnoreCondition != JsonIgnoreCondition.WhenWritingNull)
            {
                writer.WriteNullValue();
            }
        }
    }
}
