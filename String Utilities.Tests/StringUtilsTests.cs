using System.Text;
using Xunit;

namespace String_Utilities.Tests
{
    public class StringUtilsTests
    {
        #region snippet_FindSubstring_ReturnsWithPosition_InputIsCorrectString

        [Fact]
        public void FindSubstring_ReturnsWithPosition_InputIsCorrectString()
        {
            // Arrange
            const string searchString = "1 12 123 1234 12345";
            const string substring = "123";

            // Act
            var result = StringUtils.FindSubstring(searchString, substring);

            // Assert
            Assert.IsType<int>(result);
        }

        #endregion

        #region snippet_FindSubstring_ReturnsWith-1_InputSubstringWasNotFoundString

        [Fact]
        public void FindSubstring_ReturnsWith_1_InputSubstringWasNotFoundString()
        {
            // Arrange
            const string searchString = "1 12 123 1234 12345";
            const string substring = "1237";

            // Act
            var result = StringUtils.FindSubstring(searchString, substring);

            // Assert
            Assert.IsType<int>(result);
        }

        #endregion

        #region snippet_FindSubstring_ThrowsStringUtilException_SearchStringIsNullString

        [Fact]
        public void FindSubstring_ThrowsStringUtilException_SearchStringIsNullString()
        {
            // Arrange
            const string searchString = null;
            const string substring = "1237";

            // Act
            void Result()
            {
                StringUtils.FindSubstring(searchString, substring);
            }

            // Assert
            Assert.Throws<StringUtilException>(Result);
        }

        #endregion

        #region snippet_FindSubstring_ThrowsStringUtilException_SubstringIsNullString

        [Fact]
        public void FindSubstring_ThrowsStringUtilException_SubstringIsNullString()
        {
            // Arrange
            const string searchString = "1 12 123 1234 12345";
            const string substring = null;

            // Act
            void Result()
            {
                StringUtils.FindSubstring(searchString, substring);
            }

            // Assert
            Assert.Throws<StringUtilException>(Result);
        }

        #endregion

        #region snippet_FindSubstring_ReturnsWithPosition_InputIsCorrectStringBuilder

        [Fact]
        public void FindSubstring_ReturnsWithPosition_InputIsCorrectStringBuilder()
        {
            // Arrange
            var searchString = new StringBuilder("1 12 123 1234 12345");
            var substring = new StringBuilder("123");

            // Act
            var result = StringUtils.FindSubstring(searchString, substring);

            // Assert
            Assert.IsType<int>(result);
        }

        #endregion

        #region snippet_FindSubstring_ReturnsWith-1_InputSubstringWasNotFoundStringBuilder

        [Fact]
        public void FindSubstring_ReturnsWith_1_InputSubstringWasNotFoundStringBuilder()
        {
            // Arrange
            var searchString = new StringBuilder("1 12 123 1234 12345");
            var substring = new StringBuilder("123");

            // Act
            var result = StringUtils.FindSubstring(searchString, substring);

            // Assert
            Assert.IsType<int>(result);
        }

        #endregion

        #region snippet_FindSubstring_ThrowsStringUtilException_SearchStringIsNullStringBuilder

        [Fact]
        public void FindSubstring_ThrowsStringUtilException_SearchStringIsNullStringBuilder()
        {
            // Arrange
            var substring = new StringBuilder("123");

            // Act
            void Result()
            {
                StringUtils.FindSubstring(null, substring);
            }

            // Assert
            Assert.Throws<StringUtilException>(Result);
        }

        #endregion

        #region snippet_FindSubstring_ThrowsStringUtilException_SubstringIsNullStringBuilder

        [Fact]
        public void FindSubstring_ThrowsStringUtilException_SubstringIsNullStringBuilder()
        {
            // Arrange
            var searchString = new StringBuilder("1 12 123 1234 12345");

            // Act
            void Result()
            {
                StringUtils.FindSubstring(searchString, null);
            }

            // Assert
            Assert.Throws<StringUtilException>(Result);
        }

        #endregion

        #region snippet_CountWords_ReturnsWithPosition_InputIsCorrectString

        [Fact]
        public void CountWords_ReturnsWithPosition_InputIsCorrectString()
        {
            // Arrange
            const string searchString = "1 12 123 1234 12345";

            // Act
            var result = StringUtils.CountWords(searchString);

            // Assert
            Assert.IsType<int>(result);
        }

        #endregion

        #region snippet_CountWords_ThrowsStringUtilException_SearchStringIsNullString

        [Fact]
        public void CountWords_ThrowsStringUtilException_SearchStringIsNullString()
        {
            // Arrange

            // Act
            static void Result()
            {
                StringUtils.CountWords((string) null);
            }

            // Assert
            Assert.Throws<StringUtilException>(Result);
        }

        #endregion

        #region snippet_CountWords_ReturnsWithPosition_InputIsCorrectStringBulder

        [Fact]
        public void CountWords_ReturnsWithPosition_InputIsCorrectStringBuilder()
        {
            // Arrange
            var searchString = new StringBuilder("1 12 123 1234 12345");

            // Act
            var result = StringUtils.CountWords(searchString);

            // Assert
            Assert.IsType<int>(result);
        }

        #endregion

        #region snippet_CountWords_ThrowsStringUtilException_SearchStringIsNullStringBulder

        [Fact]
        public void CountWords_ThrowsStringUtilException_SearchStringIsNullStringBuilder()
        {
            // Arrange

            // Act
            static void Result()
            {
                StringUtils.CountWords((StringBuilder) null);
            }

            // Assert
            Assert.Throws<StringUtilException>(Result);
        }

        #endregion

        #region snippet_CountChars_ReturnsWithPosition_InputIsCorrectString

        [Fact]
        public void CountChars_ReturnsWithPosition_InputIsCorrectString()
        {
            // Arrange
            const string searchString = "Loren gypsum";

            // Act
            var resultWithSpaces = StringUtils.CountChars(searchString, StringSearchType.WithSpaces);
            var resultWithoutSpaces = StringUtils.CountChars(searchString, StringSearchType.WithoutSpaces);
            var resultOnlyVowels = StringUtils.CountChars(searchString, StringSearchType.OnlyVowels);
            var resultOnlyConsonants = StringUtils.CountChars(searchString, StringSearchType.OnlyConsonant);

            // Assert
            Assert.IsType<int>(resultWithSpaces);
            Assert.IsType<int>(resultWithoutSpaces);
            Assert.IsType<int>(resultOnlyVowels);
            Assert.IsType<int>(resultOnlyConsonants);
        }

        #endregion

        #region snippet_CountWords_ThrowsStringUtilException_SearchStringIsNullString

        [Fact]
        public void CountChars_ThrowsStringUtilException_SearchStringIsNullString()
        {
            // Arrange

            // Act
            static void Result()
            {
                StringUtils.CountChars((string) null, StringSearchType.WithSpaces);
            }

            // Assert
            Assert.Throws<StringUtilException>(Result);
        }

        #endregion

        #region snippet_CountWords_ReturnsWithPosition_InputIsCorrectStringBulder

        [Fact]
        public void CountChars_ReturnsWithPosition_InputIsCorrectStringBuilder()
        {
            // Arrange
            var searchString = new StringBuilder("Loren gypsum");


            // Act
            var resultWithSpaces = StringUtils.CountChars(searchString, StringSearchType.WithSpaces);
            var resultWithoutSpaces = StringUtils.CountChars(searchString, StringSearchType.WithoutSpaces);
            var resultOnlyVowels = StringUtils.CountChars(searchString, StringSearchType.OnlyVowels);
            var resultOnlyConsonants = StringUtils.CountChars(searchString, StringSearchType.OnlyConsonant);

            // Assert
            Assert.IsType<int>(resultWithSpaces);
            Assert.IsType<int>(resultWithoutSpaces);
            Assert.IsType<int>(resultOnlyVowels);
            Assert.IsType<int>(resultOnlyConsonants);
        }

        #endregion

        #region snippet_CountWords_ThrowsStringUtilException_SearchStringIsNullStringBulder

        [Fact]
        public void CountChars_ThrowsStringUtilException_SearchStringIsNullStringBuilder()
        {
            // Arrange

            // Act
            static void Result()
            {
                StringUtils.CountChars((StringBuilder) null, StringSearchType.WithSpaces);
            }

            // Assert
            Assert.Throws<StringUtilException>(Result);
        }

        #endregion

        #region snippet_FindShortestWord_ReturnsWithPosition_InputIsCorrectString

        [Fact]
        public void FindShortestWord_ReturnsWithPosition_InputIsCorrectString()
        {
            // Arrange
            const string searchString = "1 12 123 1234 12345";

            // Act
            var result = StringUtils.FindShortestWord(searchString);

            // Assert
            Assert.IsType<string>(result);
        }

        #endregion

        #region snippet_FindShortestWord_ThrowsStringUtilException_SearchStringIsNullString

        [Fact]
        public void FindShortestWord_ThrowsStringUtilException_SearchStringIsNullString()
        {
            // Arrange

            // Act
            static void Result()
            {
                StringUtils.FindShortestWord((string) null);
            }

            // Assert
            Assert.Throws<StringUtilException>(Result);
        }

        #endregion

        #region snippet_FindShortestWord_ReturnsWithPosition_InputIsCorrectStringBulder

        [Fact]
        public void FindShortestWord_ReturnsWithPosition_InputIsCorrectStringBuilder()
        {
            // Arrange
            var searchString = new StringBuilder("1 12 123 1234 12345");

            // Act
            var result = StringUtils.FindShortestWord(searchString);

            // Assert
            Assert.IsType<StringBuilder>(result);
        }

        #endregion

        #region snippet_FindShortestWord_ThrowsStringUtilException_SearchStringIsNullStringBulder

        [Fact]
        public void FindShortestWord_ThrowsStringUtilException_SearchStringIsNullStringBuilder()
        {
            // Arrange

            // Act
            static void Result()
            {
                StringUtils.FindShortestWord((StringBuilder) null);
            }

            // Assert
            Assert.Throws<StringUtilException>(Result);
        }

        #endregion

        #region snippet_FindLongestWord_ReturnsWithPosition_InputIsCorrectString

        [Fact]
        public void FindLongestWord_ReturnsWithPosition_InputIsCorrectString()
        {
            // Arrange
            const string searchString = "1 12 123 1234 12345";
            const string expected = "12345";

            // Act
            var result = StringUtils.FindLongestWord(searchString);

            // Assert
            Assert.Equal(expected, result);
        }

        #endregion

        #region snippet_FindLongestWord_ThrowsStringUtilException_SearchStringIsNullString

        [Fact]
        public void FindLongestWord_ThrowsStringUtilException_SearchStringIsNullString()
        {
            // Arrange

            // Act
            static void Result()
            {
                StringUtils.FindLongestWord((string) null);
            }

            // Assert
            Assert.Throws<StringUtilException>(Result);
        }

        #endregion

        #region snippet_FindLongestWord_ReturnsWithPosition_InputIsCorrectStringBulder

        [Fact]
        public void FindLongestWord_ReturnsWithPosition_InputIsCorrectStringBuilder()
        {
            // Arrange
            var searchString = new StringBuilder("1 12 123 1234 12345");

            // Act
            var result = StringUtils.FindLongestWord(searchString);

            // Assert
            Assert.IsType<StringBuilder>(result);
        }

        #endregion

        #region snippet_FindLongestWord_ThrowsStringUtilException_SearchStringIsNullStringBulder

        [Fact]
        public void FindLongestWord_ThrowsStringUtilException_SearchStringIsNullStringBuilder()
        {
            // Arrange

            // Act
            static void Result()
            {
                StringUtils.FindLongestWord((StringBuilder) null);
            }

            // Assert
            Assert.Throws<StringUtilException>(Result);
        }

        #endregion
    }
}