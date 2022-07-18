namespace Esstra.Hit.Client.Converters
{
    using Esstra.Hit.Client.Annotations;
    using Esstra.Hit.Client.Operations;

    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class GetEntityResponseItemsConverter<TEntity> : JsonConverter<IEnumerable<TEntity>>
    {
        public override IEnumerable<TEntity>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var entityAttribute = typeof(TEntity).GetCustomAttribute<EntityAttribute>();

            if (entityAttribute == null)
            {
                throw new EntityNameMissingException(typeof(TEntity).Name);
            }

            var entityName = entityAttribute.Name;

            var dataDocument = JsonDocument.ParseValue(ref reader);

            var jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.Converters.Add(new BoolConverter());
            jsonSerializerOptions.Converters.Add(new DateTimeConverter());
            jsonSerializerOptions.Converters.Add(new DateOnlyConverter());

            var items = dataDocument
                .RootElement
                .GetProperty(entityName)
                .Deserialize<IEnumerable<TEntity>>(jsonSerializerOptions);

            return items;
        }

        public override void Write(Utf8JsonWriter writer, IEnumerable<TEntity> value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
