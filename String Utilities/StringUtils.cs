using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace String_Utilities
{
    public enum StringSearchType
    {
        WithSpaces = 0,
        WithoutSpaces = 1,
        OnlyVowels = 2,
        OnlyConsonant = 3
    }

    public class StringUtils
    {
        private readonly HashSet<char> vowels = new HashSet<char> { 
            'a', 'e', 'i', 'o', 'u', 
            'A', 'E', 'I', 'O', 'U' };
        private readonly HashSet<char> consonants = new HashSet<char> { 
            'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z', 'y', 
            'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Z', 'Y' };

        /// <summary>
        /// Tries to  find the substring in string
        /// </summary>
        /// <param name="searchString">Your main string</param>
        /// <param name="substring">Substring to find</param>
        /// <returns>-1 if source is empty; otherwise, the first entry of element in source.</returns>
        public KeyValuePair<string, int> FindSubstring(string searchString, string substring)
        {
            if (searchString == null)
                throw new StringUtilException("Search string couldn't be null");
            if (substring == null)
                throw new StringUtilException("Substring couldn't be null");


            if (QuickSearch(searchString, substring) == -1)
            {
                return new KeyValuePair<string, int>(null, -1);
            }
            else
            {
                return new KeyValuePair<string, int>(substring, QuickSearch(searchString, substring));
            }

        }

        /// <summary>
        /// Tries to  find the substring in string
        /// </summary>
        /// <param name="searchString">Your main string</param>
        /// <param name="substring">Substring to find</param>
        /// <returns>-1 if source is empty; otherwise, the first entry of element in source.</returns>
        public KeyValuePair<StringBuilder, int> FindSubstring(StringBuilder searchString, StringBuilder substring)
        {
            if (searchString == null)
                throw new StringUtilException("Search string couldn't be null");
            if (substring == null)
                throw new StringUtilException("Substring couldn't be null");

            if (QuickSearch(searchString, substring) == -1)
            {
                return new KeyValuePair<StringBuilder, int>(null, -1);
            }
            else
            {
                return new KeyValuePair<StringBuilder, int>(substring, QuickSearch(searchString, substring));
            }
        }
       
        /// <summary>
        /// Counts number of words (substrings separated by space) in given string
        /// </summary>
        /// <param name="searchString">Your string</param>
        public int CountWords(string searchString)
        {
            if (searchString == null)
                throw new StringUtilException("Search string couldn't be null");

            return Regex.Replace(searchString, @"\s+", " ")
                .Split(' ')
                .Count();
        }

        /// <summary>
        /// Counts number of words (substrings separated by space) in given string
        /// </summary>
        /// <param name="searchString">Your string</param>
        public int CountWords(StringBuilder searchString)
        {
            if (searchString == null)
                throw new StringUtilException("Search string couldn't be null");

            return Regex.Replace(searchString.ToString(), @"\s+", " ")
                .Split(' ')
                .Count();
        }

        /// <summary>
        /// Counts number of entries of chars in given string
        /// </summary>
        /// <param name="searchString">Your string</param>
        /// <param name="searchType">Defines what you want to search</param>
        /// <returns>Number of entries</returns>
        public int CountChars(string searchString, StringSearchType searchType)
        {
            if (searchString == null)
                throw new StringUtilException("Search string couldn't be null");

            return searchType switch
            {
                StringSearchType.WithSpaces => searchString.Length,
                StringSearchType.WithoutSpaces => Regex.Replace(searchString, @"\s+", "").Length,
                StringSearchType.OnlyVowels => searchString.Count(c => vowels.Contains(c)),
                StringSearchType.OnlyConsonant => searchString.Count(c => consonants.Contains(c)),
                _ => throw new Exception("Wrong Search Type"),
            };
        }

        /// <summary>
        /// Counts number of entries of chars in given string
        /// </summary>
        /// <param name="searchString">Your string</param>
        /// <param name="searchType">Defines what you want to search</param>
        /// <returns>Number of entries</returns>
        public int CountChars(StringBuilder searchString, StringSearchType searchType)
        {
            if (searchString == null)
                throw new StringUtilException("Search string couldn't be null");

            return searchType switch
            {
                StringSearchType.WithSpaces => searchString.Length,
                StringSearchType.WithoutSpaces => searchString.Replace("").Length,
                StringSearchType.OnlyVowels => searchString.Count(c => vowels.Contains(c)),
                StringSearchType.OnlyConsonant => searchString.Count(c => consonants.Contains(c)),
                _ => throw new Exception("Wrong Search Type"),
            };
        }

        /// <summary>
        /// Finds shortest word in string
        /// </summary>
        /// <param name="searchString">Your string</param>
        public KeyValuePair<string, int> FindShortestWord(string searchString)
        {
            if (searchString == null)
                throw new StringUtilException("Search string couldn't be null");

            string shortestWord = Regex.Replace(searchString, @"\s+", " ")
                .Split(' ').OrderBy(x => x.Length).FirstOrDefault();
            int shortestWordIndex = searchString.IndexOf(shortestWord);

            return new KeyValuePair<string, int>(shortestWord, shortestWordIndex);
        }

        /// <summary>
        /// Finds shortest word in string
        /// </summary>
        /// <param name="searchString">Your string</param>
        public KeyValuePair<StringBuilder, int> FindShortestWord(StringBuilder searchString)
        {
            if (searchString == null)
                throw new StringUtilException("Search string couldn't be null");

            StringBuilder shortestWord = searchString.Replace(" ")
                .Split(' ').OrderBy(x => x.Length).FirstOrDefault();
            int shortestWordIndex = searchString.IndexOf(shortestWord);

            return new KeyValuePair<StringBuilder, int>(shortestWord, shortestWordIndex);
        }

        /// <summary>
        /// Finds longest word in string
        /// </summary>
        /// <param name="searchString">Your string</param>
        public KeyValuePair<string, int> FindLongestWord(string searchString)
        {
            if (searchString == null)
                throw new StringUtilException("Search string couldn't be null");

            string shortestWord = Regex.Replace(searchString, @"\s+", " ")
               .Split(' ').OrderBy(x => x.Length).LastOrDefault();
            int shortestWordIndex = searchString.IndexOf(shortestWord);

            return new KeyValuePair<string, int>(shortestWord, shortestWordIndex);
        }

        /// <summary>
        /// Finds longest word in string
        /// </summary>
        /// <param name="searchString">Your string</param>
        public KeyValuePair<StringBuilder, int> FindLongestWord(StringBuilder searchString)
        {
            if (searchString == null)
                throw new StringUtilException("Search string couldn't be null");

            StringBuilder shortestWord = searchString.Replace(" ")
                .Split(' ').OrderBy(x => x.Length).LastOrDefault();
            int shortestWordIndex = searchString.IndexOf(shortestWord);

            return new KeyValuePair<StringBuilder, int>(shortestWord, shortestWordIndex);
        }

        private int QuickSearch(string searchString, string substring)
        {
            int shiftIndex = 0;

            while (shiftIndex+ substring.Length<= searchString.Length)
            {
                for (int i = 0; i < substring.Length; i++)
                {
                    if (searchString[i+ shiftIndex] == substring[i])
                    {
                        if (i == substring.Length-1)
                        {
                            return shiftIndex;
                        }
                        continue;
                    }
                    else
                    {
                        shiftIndex++;
                        break;
                    }
                }
            }
            return -1;
        }
        private int QuickSearch(StringBuilder searchString, StringBuilder substring)
        {
            int shiftIndex = 0;

            while (shiftIndex + substring.Length <= searchString.Length)
            {
                for (int i = 0; i < substring.Length; i++)
                {
                    if (searchString[i + shiftIndex] == substring[i])
                    {
                        if (i == substring.Length - 1)
                        {
                            return shiftIndex;
                        }
                        continue;
                    }
                    else
                    {
                        shiftIndex++;
                        break;
                    }
                }
            }
            return -1;
        }
    }
}
