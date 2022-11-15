using System.Text.RegularExpressions;

namespace HoNSharp.Converters
{
    internal class PhPToJsonConverter
    {
        private const string _stringKeyRegex = "s:[0-9]+:(?<key>\"[a-zA-Z0-9_]+\");";
        private const string _intKeyRegex = "i:(?<key>[\\-]?[0-9]+);";

        private const string _stringValueRegex = @"s:[0-9]+:(?<value>""[\\\/_\:\-`\s\.,\da-zA-Z\[\]\(\)]*"");";
        private const string _booleanValueRegex = "b:(?<value>[01]{1});";
        private const string _doubleValueRegex = @"d:(?<value>[\-]?[0-9]+\.?[0-9]*);";
        private const string _nanValueRegex = @"d:NAN;";
        private const string _nullValueRegex = "N;";
        private const string _arrayValueRegex = "a:[0-9]+:";

        private readonly Regex _intToStringConvertRegex = new($"{_intKeyRegex}");
        private readonly Regex _stringToIntConvertRegex = new(@"""(?<key>[0-9]+)"",");

        private readonly Regex _stringToStringRegex = new($"{_stringKeyRegex}{_stringValueRegex}");
        private readonly Regex _stringToBooleanRegex = new($"{_stringKeyRegex}{_booleanValueRegex}");
        private readonly Regex _stringToDoubleRegex = new($"{_stringKeyRegex}{_doubleValueRegex}");
        private readonly Regex _stringToNaNRegex = new($"{_stringKeyRegex}{_nanValueRegex}");
        private readonly Regex _stringToNullRegex = new($"{_stringKeyRegex}{_nullValueRegex}");
        private readonly Regex _stringToArrayRegex = new($"{_stringKeyRegex}{_arrayValueRegex}");

        private readonly Regex _arrayStartRegex = new($"{_arrayValueRegex}");
        private readonly Regex _arrayEndRegex = new("}\"");
        private readonly Regex _lastArrayElementRegex = new(",}");

        public string ConvertToJson(string phpSerialized)
        {
            if (string.IsNullOrWhiteSpace(phpSerialized))
            {
                return string.Empty;
            }

            var result = phpSerialized;

            result = _intToStringConvertRegex.Replace(result, m =>
            {
                var key = m.Groups["key"];

                return $"s:0:\"{key}\";";
            });

            result = _stringToStringRegex.Replace(result, m =>
            {
                var key = m.Groups["key"];
                var value = m.Groups["value"];

                return $"{key}:{value},";
            });

            result = _stringToBooleanRegex.Replace(result, m =>
            {
                var key = m.Groups["key"];
                var value = m.Groups["value"];
                var boolean = value.Value != "0";

                return $"{key}:{boolean.ToString().ToLower()},";
            });

            result = _stringToDoubleRegex.Replace(result, m =>
            {
                var key = m.Groups["key"];
                var value = m.Groups["value"];

                return $"{key}:{value},";
            });

            result = _stringToNaNRegex.Replace(result, m =>
            {
                var key = m.Groups["key"];
                var value = m.Groups["value"];

                return $"{key}:null,";
            });

            result = _stringToNullRegex.Replace(result, m =>
            {
                var key = m.Groups["key"];

                return $"{key}:null,";
            });

            result = _stringToArrayRegex.Replace(result, m =>
            {
                var key = m.Groups["key"];

                return $"{key}:";
            });

            result = _stringToIntConvertRegex.Replace(result, m =>
            {
                var key = m.Groups["key"];

                return $"{key},";
            });

            result = _arrayStartRegex.Replace(result, m => "");
            result = _arrayEndRegex.Replace(result, m => "},\"");
            result = _lastArrayElementRegex.Replace(result, m => "}");

            return result;
        }
    }
}
