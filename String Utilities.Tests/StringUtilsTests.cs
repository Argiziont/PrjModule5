using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace String_Utilities.Tests
{
    public class StringUtilsTests
    {
        #region snippet_FindSubstring_ReturnsKeyValuePairWithPosition_InputIsCorrectString
        [Fact]
        public void FindSubstring_ReturnsKeyValuePairWithPosition_InputIsCorrectString()
        {
            // Arrange
            string serachString = "1 12 123 1234 12345";
            string substring = "123";
            KeyValuePair<string, int> expected = new KeyValuePair<string, int>("123", 5);
            StringUtils utils = new StringUtils();

            // Act
            var result = utils.FindSubstring(serachString, substring);

            // Assert
            Assert.Equal(expected, result);
        }
        #endregion
        #region snippet_FindSubstring_ReturnsKeyValuePairWith-1_InputSubstringWasNotFoundString
        [Fact]
        public void FindSubstring_ReturnsKeyValuePairWith_1_InputSubstringWasNotFoundString()
        {
            // Arrange
            string serachString = "1 12 123 1234 12345";
            string substring = "123456";
            KeyValuePair<string, int> expected = new KeyValuePair<string, int>(null, -1);
            StringUtils utils = new StringUtils();

            // Act
            var result = utils.FindSubstring(serachString, substring);

            // Assert
            Assert.Equal(expected, result);
        }
        #endregion
        #region snippet_FindSubstring_ThrowsStringUtilException_SearchStringIsNullString
        [Fact]
        public void FindSubstring_ThrowsStringUtilException_SearchStringIsNullString()
        {
            // Arrange
            string serachString = null;
            string substring = "123456";
            StringUtils utils = new StringUtils();

            // Act
            void result() => utils.FindSubstring(serachString, substring);

            // Assert
            Assert.Throws<StringUtilException>(result);
        }
        #endregion
        #region snippet_FindSubstring_ThrowsStringUtilException_SubstringIsNullString
        [Fact]
        public void FindSubstring_ThrowsStringUtilException_SubstringIsNullString()
        {
            // Arrange
            string serachString = "1 12 123 1234 12345";
            string substring = null;
            StringUtils utils = new StringUtils();

            // Act
            void result() => utils.FindSubstring(serachString, substring);

            // Assert
            Assert.Throws<StringUtilException>(result);
        }
        #endregion

        #region snippet_FindSubstring_ReturnsKeyValuePairWithPosition_InputIsCorrectStringBuilder
        [Fact]
        public void FindSubstring_ReturnsKeyValuePairWithPosition_InputIsCorrectStringBuilder()
        {
            // Arrange
            StringBuilder serachString = new StringBuilder("1 12 123 1234 12345");
            StringBuilder substring = new StringBuilder("123");
            KeyValuePair<StringBuilder, int> expected = new KeyValuePair<StringBuilder, int>(new StringBuilder("123"), 5);
            StringUtils utils = new StringUtils();

            // Act
            var result = utils.FindSubstring(serachString, substring);

            // Assert
            Assert.Equal(expected.Key.ToString(), result.Key.ToString());
        }
        #endregion
        #region snippet_FindSubstring_ReturnsKeyValuePairWith-1_InputSubstringWasNotFoundStringBuilder
        [Fact]
        public void FindSubstring_ReturnsKeyValuePairWith_1_InputSubstringWasNotFoundStringBuilder()
        {
            // Arrange
            StringBuilder serachString = new StringBuilder("1 12 123 1234 12345");
            StringBuilder substring = new StringBuilder("123456");
            KeyValuePair<StringBuilder, int> expected = new KeyValuePair<StringBuilder, int>(null, -1);
            StringUtils utils = new StringUtils();

            // Act
            var result = utils.FindSubstring(serachString, substring);

            // Assert
            Assert.Equal(expected, result);
        }
        #endregion
        #region snippet_FindSubstring_ThrowsStringUtilException_SearchStringIsNullStringBuilder
        [Fact]
        public void FindSubstring_ThrowsStringUtilException_SearchStringIsNullStringBuilder()
        {
            // Arrange
            StringBuilder serachString = null;
            StringBuilder substring = new StringBuilder("123456");
            StringUtils utils = new StringUtils();

            // Act
            void result() => utils.FindSubstring(serachString, substring);

            // Assert
            Assert.Throws<StringUtilException>(result);
        }
        #endregion
        #region snippet_FindSubstring_ThrowsStringUtilException_SubstringIsNullStringBuilder
        [Fact]
        public void FindSubstring_ThrowsStringUtilException_SubstringIsNullStringBuilder()
        {
            // Arrange
            StringBuilder serachString = new StringBuilder("1 12 123 1234 12345");
            StringBuilder substring = null;
            StringUtils utils = new StringUtils();

            // Act
            void result() => utils.FindSubstring(serachString, substring);

            // Assert
            Assert.Throws<StringUtilException>(result);
        }
        #endregion

        #region snippet_CountWords_ReturnsKeyValuePairWithPosition_InputIsCorrectString
        [Fact]
        public void CountWords_ReturnsKeyValuePairWithPosition_InputIsCorrectString()
        {
            // Arrange
            string serachString = "1 12 123 1234 12345";
            int expected = 5;
            StringUtils utils = new StringUtils();

            // Act
            var result = utils.CountWords(serachString);

            // Assert
            Assert.Equal(expected, result);
        }
        #endregion
        #region snippet_CountWords_ThrowsStringUtilException_SearchStringIsNullString
        [Fact]
        public void CountWords_ThrowsStringUtilException_SearchStringIsNullString()
        {
            // Arrange
            string serachString = null;
            StringUtils utils = new StringUtils();

            // Act
            void result() => utils.CountWords(serachString);

            // Assert
            Assert.Throws<StringUtilException>(result);
        }
        #endregion

        #region snippet_CountWords_ReturnsKeyValuePairWithPosition_InputIsCorrectStringBulder
        [Fact]
        public void CountWords_ReturnsKeyValuePairWithPosition_InputIsCorrectStringBulder()
        {
            // Arrange
            StringBuilder serachString = new StringBuilder("1 12 123 1234 12345");
            int expected = 5;
            StringUtils utils = new StringUtils();

            // Act
            var result = utils.CountWords(serachString);

            // Assert
            Assert.Equal(expected, result);
        }
        #endregion
        #region snippet_CountWords_ThrowsStringUtilException_SearchStringIsNullStringBulder
        [Fact]
        public void CountWords_ThrowsStringUtilException_SearchStringIsNullStringBulder()
        {
            // Arrange
            StringBuilder serachString = null;
            StringUtils utils = new StringUtils();

            // Act
            void result() => utils.CountWords(serachString);

            // Assert
            Assert.Throws<StringUtilException>(result);
        }
        #endregion

        #region snippet_CountChars_ReturnsKeyValuePairWithPosition_InputIsCorrectString
        [Fact]
        public void CountChars_ReturnsKeyValuePairWithPosition_InputIsCorrectString()
        {
            // Arrange
            string serachString = "Lorem ipsum";
            int expectedWithSpaces = 11;
            int expectedWithoutSpaces = 10;
            int expectedOnlyVowels = 4;
            int expectedOnlyConsonants = 6;

            StringUtils utils = new StringUtils();

            // Act
            var resultWithSpaces = utils.CountChars(serachString,StringSearchType.WithSpaces);
            var resultWithoutSpaces = utils.CountChars(serachString, StringSearchType.WithoutSpaces);
            var resultOnlyVowels = utils.CountChars(serachString, StringSearchType.OnlyVowels);
            var resultOnlyConsonants = utils.CountChars(serachString, StringSearchType.OnlyConsonant);

            // Assert
            Assert.Equal(expectedWithSpaces, resultWithSpaces);
            Assert.Equal(expectedWithoutSpaces, resultWithoutSpaces);
            Assert.Equal(expectedOnlyVowels, resultOnlyVowels);
            Assert.Equal(expectedOnlyConsonants, resultOnlyConsonants);
        }
        #endregion
        #region snippet_CountWords_ThrowsStringUtilException_SearchStringIsNullString
        [Fact]
        public void CountChars_ThrowsStringUtilException_SearchStringIsNullString()
        {
            // Arrange
            string serachString = null;
            StringUtils utils = new StringUtils();

            // Act
            void result() => utils.CountChars(serachString,StringSearchType.WithSpaces);

            // Assert
            Assert.Throws<StringUtilException>(result);
        }
        #endregion

        #region snippet_CountWords_ReturnsKeyValuePairWithPosition_InputIsCorrectStringBulder
        [Fact]
        public void CountChars_ReturnsKeyValuePairWithPosition_InputIsCorrectStringBulder()
        {
            // Arrange
            StringBuilder serachString = new StringBuilder("Lorem ipsum");
            int expectedWithSpaces = 11;
            int expectedWithoutSpaces = 10;
            int expectedOnlyVowels = 4;
            int expectedOnlyConsonants = 6;

            StringUtils utils = new StringUtils();

            // Act
            var resultWithSpaces = utils.CountChars(serachString, StringSearchType.WithSpaces);
            var resultWithoutSpaces = utils.CountChars(serachString, StringSearchType.WithoutSpaces);
            var resultOnlyVowels = utils.CountChars(serachString, StringSearchType.OnlyVowels);
            var resultOnlyConsonants = utils.CountChars(serachString, StringSearchType.OnlyConsonant);

            // Assert
            Assert.Equal(expectedWithSpaces, resultWithSpaces);
            Assert.Equal(expectedWithoutSpaces, resultWithoutSpaces);
            Assert.Equal(expectedOnlyVowels, resultOnlyVowels);
            Assert.Equal(expectedOnlyConsonants, resultOnlyConsonants);
        }
        #endregion
        #region snippet_CountWords_ThrowsStringUtilException_SearchStringIsNullStringBulder
        [Fact]
        public void CountChars_ThrowsStringUtilException_SearchStringIsNullStringBulder()
        {  // Arrange
            StringBuilder serachString = null;
            StringUtils utils = new StringUtils();

            // Act
            void result() => utils.CountChars(serachString, StringSearchType.WithSpaces);

            // Assert
            Assert.Throws<StringUtilException>(result);
        }
        #endregion

        #region snippet_FindShortestWord_ReturnsKeyValuePairWithPosition_InputIsCorrectString
        [Fact]
        public void FindShortestWord_ReturnsKeyValuePairWithPosition_InputIsCorrectString()
        {
            // Arrange
            string serachString = "1 12 123 1234 12345";
            string expected = "1";
            StringUtils utils = new StringUtils();

            // Act
            var result = utils.FindShortestWord(serachString);

            // Assert
            Assert.Equal(expected, result.Key);
        }
        #endregion
        #region snippet_FindShortestWord_ThrowsStringUtilException_SearchStringIsNullString
        [Fact]
        public void FindShortestWord_ThrowsStringUtilException_SearchStringIsNullString()
        {
            // Arrange
            string serachString = null;
            StringUtils utils = new StringUtils();

            // Act
            void result() => utils.FindShortestWord(serachString);

            // Assert
            Assert.Throws<StringUtilException>(result);
        }
        #endregion

        #region snippet_FindShortestWord_ReturnsKeyValuePairWithPosition_InputIsCorrectStringBulder
        [Fact]
        public void FindShortestWord_ReturnsKeyValuePairWithPosition_InputIsCorrectStringBulder()
        {
            // Arrange
            StringBuilder serachString = new StringBuilder("1 12 123 1234 12345");
            StringBuilder expected = new StringBuilder("1");
            StringUtils utils = new StringUtils();

            // Act
            var result = utils.FindShortestWord(serachString);

            // Assert
            Assert.Equal(expected.ToString(), result.Key.ToString());
        }
        #endregion
        #region snippet_FindShortestWord_ThrowsStringUtilException_SearchStringIsNullStringBulder
        [Fact]
        public void FindShortestWord_ThrowsStringUtilException_SearchStringIsNullStringBulder()
        {
            // Arrange
            StringBuilder serachString = null;
            StringUtils utils = new StringUtils();

            // Act
            void result() => utils.FindShortestWord(serachString);

            // Assert
            Assert.Throws<StringUtilException>(result);
        }
        #endregion

        #region snippet_FindLongestWord_ReturnsKeyValuePairWithPosition_InputIsCorrectString
        [Fact]
        public void FindLongestWord_ReturnsKeyValuePairWithPosition_InputIsCorrectString()
        {
            // Arrange
            string serachString = "1 12 123 1234 12345";
            string expected = "12345";
            StringUtils utils = new StringUtils();

            // Act
            var result = utils.FindLongestWord(serachString);

            // Assert
            Assert.Equal(expected, result.Key);
        }
        #endregion
        #region snippet_FindLongestWord_ThrowsStringUtilException_SearchStringIsNullString
        [Fact]
        public void FindLongestWord_ThrowsStringUtilException_SearchStringIsNullString()
        {
            // Arrange
            string serachString = null;
            StringUtils utils = new StringUtils();

            // Act
            void result() => utils.FindLongestWord(serachString);

            // Assert
            Assert.Throws<StringUtilException>(result);
        }
        #endregion

        #region snippet_FindLongestWord_ReturnsKeyValuePairWithPosition_InputIsCorrectStringBulder
        [Fact]
        public void FindLongestWord_ReturnsKeyValuePairWithPosition_InputIsCorrectStringBulder()
        {
            // Arrange
            StringBuilder serachString = new StringBuilder("1 12 123 1234 12345");
            StringBuilder expected = new StringBuilder("12345");
            StringUtils utils = new StringUtils();

            // Act
            var result = utils.FindLongestWord(serachString);

            // Assert
            Assert.Equal(expected.ToString(), result.Key.ToString());
        }
        #endregion
        #region snippet_FindLongestWord_ThrowsStringUtilException_SearchStringIsNullStringBulder
        [Fact]
        public void FindLongestWord_ThrowsStringUtilException_SearchStringIsNullStringBulder()
        {
            // Arrange
            StringBuilder serachString = null;
            StringUtils utils = new StringUtils();

            // Act
            void result() => utils.FindLongestWord(serachString);

            // Assert
            Assert.Throws<StringUtilException>(result);
        }
        #endregion
    }
}
