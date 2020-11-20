using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace String_Utilities
{
    public static class StringBuilderExtensions
    {
        /// <summary>
        ///     Converts your string to array by given separator
        /// </summary>
        /// <param name="separator">Separator character</param>
        /// <returns></returns>
        public static StringBuilder[] Split(this StringBuilder source, char separator)
        {
            var results = new List<StringBuilder>();

            var current = new StringBuilder();
            for (var i = 0; i < source.Length; ++i)
                if (source[i] == separator)
                {
                    results.Add(current);
                    current = new StringBuilder();
                }
                else
                {
                    current.Append(source[i]);
                }

            if (current.Length > 0)
                results.Add(current);

            return results.ToArray();
        }

        /// <summary>
        ///     Replaces given sequence of chars with one
        /// </summary>
        /// <param name="replacement">String for replace</param>
        /// <returns></returns>
        public static StringBuilder Replace(this StringBuilder source, string replacement)
        {
            if (source.Length == 0) return source;
            var replaced = Regex.Replace(source.ToString(), @"\s+", replacement);
            return new StringBuilder(replaced);
        }

        /// <summary>
        ///     Counts entry of char with given predicate
        /// </summary>
        /// <param name="predicate">Your predicate function</param>
        /// <returns></returns>
        public static int Count(this StringBuilder source, Func<char, bool> predicate)
        {
            return source.ToString().Count(predicate);
        }

        /// <summary>
        ///     Returns the index of the start of the contents in a StringBuilder
        /// </summary>
        /// <param name="value">The string to find</param>
        /// <returns></returns>
        public static int IndexOf(this StringBuilder source, StringBuilder value)
        {
            int index;
            var length = value.Length;
            var maxSearchLength = source.Length - length + 1;

            for (var i = 0; i < maxSearchLength; ++i)
                if (source[i] == value[0])
                {
                    index = 1;
                    while (index < length && source[i + index] == value[index])
                        ++index;

                    if (index == length)
                        return i;
                }

            return -1;
        }
    }
}