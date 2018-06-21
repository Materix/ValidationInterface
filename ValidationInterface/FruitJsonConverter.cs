using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ValidationInterface.Model;

namespace ValidationInterface
{
    public class FruitJsonConverter : JsonConverter
    {
        public override bool CanRead => true;

        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new JsonException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.StartObject && reader.Value == null) return null;

            var source = JObject.Load(reader);
            return serializer.Deserialize(source.CreateReader(), source["type"].ToString() == "apple" ? typeof(Apple) : typeof(Orange));
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(IFruit) == objectType;
        }
    }
}