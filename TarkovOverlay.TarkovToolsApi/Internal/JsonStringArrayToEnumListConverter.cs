using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TarkovOverlay.TarkovToolsApi.Internal
{
    public class JsonStringArrayToEnumListConverter<T> : JsonConverter<List<T>> where T : Enum
    {
        public override List<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            
            List<T> result = new();
            // read StartArray token
            reader.Read();

            while (reader.TokenType != JsonTokenType.EndArray)
            {
                result.Add((T) Enum.Parse(typeof(T), reader.GetString(), true));
                reader.Read();
            }

            return result;
        }

        public override void Write(Utf8JsonWriter writer, List<T> value, JsonSerializerOptions options)
        {
            throw new InvalidOperationException("This converter does not support the Write() function");
        }
    }
}