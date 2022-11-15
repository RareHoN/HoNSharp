using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoNSharp.Converters
{
    internal class StringToLongJsonConverter : JsonConverter
    {
        private readonly JsonSerializer _defaultSerializer = new JsonSerializer();

        public override bool CanRead => true;

        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType)
        {
            return typeof(string) == objectType || IsIntegerType(objectType);
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            return reader.TokenType switch
            {
                JsonToken.Integer or JsonToken.Float or JsonToken.Null => _defaultSerializer.Deserialize(reader, objectType),
                JsonToken.String => (long)0,
                _ => throw new JsonSerializationException(string.Format("Token \"{0}\" of type {1} was not a JSON integer.", reader.Value, reader.TokenType)),
            };
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        private static bool IsIntegerType(Type type)
        {
            type = Nullable.GetUnderlyingType(type) ?? type;
            if (type == typeof(long)
                || type == typeof(ulong)
                || type == typeof(int)
                || type == typeof(uint)
                || type == typeof(short)
                || type == typeof(ushort)
                || type == typeof(byte)
                || type == typeof(sbyte)
                || type == typeof(System.Numerics.BigInteger))
                return true;
            return false;
        }
    }
}
