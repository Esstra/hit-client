namespace Esstra.Hit.Client.Converters
{
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class BoolConverter : JsonConverter<bool?>
    {
        public override bool? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number)
            {
                var value = reader.GetInt32();

                // Since this method will not be called when "value" equals "null", "null" is missing in the following switch.
                return value switch
                {
                    0 => false,
                    1 => true,
                    _ => throw new FormatException()
                };
            }
            else if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }
            else
            {
                throw new FormatException();
            }
        }

        public override void Write(Utf8JsonWriter writer, bool? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
            {
                writer.WriteNumberValue(value == true ? 1 : 0);
            }
            else if (options.DefaultIgnoreCondition != JsonIgnoreCondition.WhenWritingNull)
            {
                writer.WriteNullValue();
            }
        }
    }
}
