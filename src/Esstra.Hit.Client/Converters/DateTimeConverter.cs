namespace Esstra.Hit.Client.Converters
{
    using System.Globalization;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class DateTimeConverter : JsonConverter<DateTime?>
    {
        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();

            return !string.IsNullOrWhiteSpace(value)
                ? DateTime.ParseExact(value, "dd.MM.yyyy\\/HH.mm.ss.ffffff", CultureInfo.InvariantCulture)
                : null;
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
            {
                writer.WriteStringValue(value.Value.ToString("dd.MM.yyyy\\/HH.mm.ss.ffffff"));
            }
            else if (options.DefaultIgnoreCondition != JsonIgnoreCondition.WhenWritingNull)
            {
                writer.WriteNullValue();
            }
        }
    }
}
