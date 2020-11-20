using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace String_Utilities
{
    public static class StringUtils
    {
        private static readonly HashSet<char> Vowels = new()
        {
            'a', 'e', 'i', 'o', 'u',
            'A', 'E', 'I', 'O', 'U'
        };

        private static readonly HashSet<char> Consonants = new()
        {
            'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z', 'y',
            'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Z', 'Y'
        };

        /// <summary>
        ///     Tries to  find the substring in string
        /// </summary>
        /// <param name="searchString">Your main string</param>
        /// <param name="substring">Substring to find</param>
        /// <returns>-1 if source is empty; otherwise, the first entry of element in source.</returns>
        public static int FindSubstring(string searchString, string substring)
        {
            if (searchString == null)
                throw new StringUtilException("Search string couldn't be null");
            if (substring == null)
                throw new StringUtilException("Substring couldn't be null");


            return QuickSearch(searchString, substring);
        }

        /// <summary>
        ///     Tries to  find the substring in string
        /// </summary>
        /// <param name="searchString">Your main string</param>
        /// <param name="substring">Substring to find</param>
        /// <returns>-1 if source is empty; otherwise, the first entry of element in source.</returns>
        public static int FindSubstring(StringBuilder searchString, StringBuilder substring)
        {
            if (searchString == null) throw new StringUtilException(nameof(searchString));
            if (substring == null) throw new StringUtilException(nameof(substring));
            return FindSubstring(searchString.ToString(), substring.ToString());
        }

        /// <summary>
        ///     Counts number of words (substrings separated by space) in given string
        /// </summary>
        /// <param name="searchString">Your string</param>
        public static int CountWords(string searchString)
        {
            //var list = searchString.Split(' ').Where(s => !string.IsNullOrWhiteSpace(s));
            //searchString = string.Join(" ", list);

            if (searchString == null)
                throw new StringUtilException("Search string couldn't be null");

            return Regex.Replace(searchString, @"\s+", " ")
                .Split(' ').Length;
        }

        /// <summary>
        ///     Counts number of words (substrings separated by space) in given string
        /// </summary>
        /// <param name="searchString">Your string</param>
        public static int CountWords(StringBuilder searchString)
        {
            if (searchString == null)
                throw new StringUtilException("Search string couldn't be null");

            return Regex.Replace(searchString.ToString(), @"\s+", " ")
                .Split(' ').Length;
        }

        /// <summary>
        ///     Counts number of entries of chars in given string
        /// </summary>
        /// <param name="searchString">Your string</param>
        /// <param name="searchType">Defines what you want to search</param>
        /// <returns>Number of entries</returns>
        public static int CountChars(string searchString, StringSearchType searchType)
        {
            if (searchString == null)
                throw new StringUtilException("Search string couldn't be null");

            return searchType switch
            {
                StringSearchType.WithSpaces => searchString.Length,
                StringSearchType.WithoutSpaces => Regex.Replace(searchString, @"\s+", "").Length,
                StringSearchType.OnlyVowels => searchString.Count(c => Vowels.Contains(c)),
                StringSearchType.OnlyConsonant => searchString.Count(c => Consonants.Contains(c)),
                _ => throw new Exception("Wrong Search Type")
            };
        }

        /// <summary>
        ///     Counts number of entries of chars in given string
        /// </summary>
        /// <param name="searchString">Your string</param>
        /// <param name="searchType">Defines what you want to search</param>
        /// <returns>Number of entries</returns>
        public static int CountChars(StringBuilder searchString, StringSearchType searchType)
        {
            if (searchString == null)
                throw new StringUtilException("Search string couldn't be null");

            return searchType switch
            {
                StringSearchType.WithSpaces => searchString.Length,
                StringSearchType.WithoutSpaces => searchString.Replace("").Length,
                StringSearchType.OnlyVowels => searchString.Count(c => Vowels.Contains(c)),
                StringSearchType.OnlyConsonant => searchString.Count(c => Consonants.Contains(c)),
                _ => throw new Exception("Wrong Search Type")
            };
        }

        /// <summary>
        ///     Finds shortest word in string
        /// </summary>
        /// <param name="searchString">Your string</param>
        public static string FindShortestWord(string searchString)
        {
            if (searchString == null)
                throw new StringUtilException("Search string couldn't be null");

            var shortestWord = Regex.Replace(searchString, @"\s+", " ")
                .Split(' ').OrderBy(x => x.Length).FirstOrDefault();

            return shortestWord;
        }

        /// <summary>
        ///     Finds shortest word in string
        /// </summary>
        /// <param name="searchString">Your string</param>
        public static StringBuilder FindShortestWord(StringBuilder searchString)
        {
            if (searchString == null) throw new StringUtilException(nameof(searchString));
            return new StringBuilder(FindShortestWord(searchString.ToString()));
        }

        /// <summary>
        ///     Finds longest word in string
        /// </summary>
        /// <param name="searchString">Your string</param>
        public static string FindLongestWord(string searchString)
        {
            if (searchString == null)
                throw new StringUtilException("Search string couldn't be null");

            var shortestWord = Regex.Replace(searchString, @"\s+", " ")
                .Split(' ').OrderBy(x => x.Length).LastOrDefault();

            return shortestWord;
        }

        /// <summary>
        ///     Finds longest word in string
        /// </summary>
        /// <param name="searchString">Your string</param>
        public static StringBuilder FindLongestWord(StringBuilder searchString)
        {
            if (searchString == null) throw new StringUtilException(nameof(searchString));

            return new StringBuilder(FindLongestWord(searchString.ToString()));
        }

        private static int QuickSearch(string searchString, string substring)
        {
            var shiftIndex = 0;

            while (shiftIndex + substring.Length <= searchString.Length)
                for (var i = 0; i < substring.Length; i++)
                    if (searchString[i + shiftIndex] == substring[i])
                    {
                        if (i == substring.Length - 1) return shiftIndex;
                    }
                    else
                    {
                        shiftIndex++;
                        break;
                    }

            return -1;
        }
    }
}