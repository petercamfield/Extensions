using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BetaSpline.Extensions
{
    public class StringExtensions
    {
        private readonly string input;

        public StringExtensions(string input)
        {
            this.input = input;
        }

        public string Format(object instance)
        {
            var properties = instance.GetType().GetProperties();
            var lookup = properties.ToDictionary(GetKey, property => GetValue(property, instance));
            return lookup.Aggregate(input, ReplaceKeyWithValue);
        }

        private static string GetKey(PropertyInfo property)
        {
            return string.Join(property.Name, "{", "}");
        }

        private static string GetValue(PropertyInfo property, object instance)
        {
            return property.GetValue(instance, null).ToString();
        }

        private static string ReplaceKeyWithValue(string currentString, KeyValuePair<string, string> entry)
        {
            return currentString.Replace(entry.Key, entry.Value);
        }
    }
}