namespace Esstra.Hit.Client.Converters
{
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class GetEntityResponseItemsConverterFactory : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.Name == "IEnumerable`1";
        }

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var keyType = typeToConvert.GetGenericArguments()[0];
            
            var converter = (JsonConverter)Activator.CreateInstance(
                typeof(GetEntityResponseItemsConverter<>).MakeGenericType(new Type[] { keyType }), 
                BindingFlags.Instance | BindingFlags.Public, 
                binder: null, 
                args: null, 
                culture: null)!;

            return converter;
        }
    }
}
