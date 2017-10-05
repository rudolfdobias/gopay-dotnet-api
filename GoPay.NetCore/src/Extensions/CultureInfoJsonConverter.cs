using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Globalization;

namespace GoPay.Extensions
{
    class CultureInfoJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(CultureInfo);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;
            var token = JToken.Load(reader);
            return new CultureInfo((string)token);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((CultureInfo)value).Name);
        }
    }
}
