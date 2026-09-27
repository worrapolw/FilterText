using FilterText.Business;
using FilterText.Utility;

namespace FilterText.Tests
{
    public class TextUtilityTests
    {
        private readonly ITextUtility _textUtility;
        public TextUtilityTests()
        {
            _textUtility = new TextUtility();
        }

        [Theory]
        [InlineData("time to see it pop down a large rabbit hole under the hedge.", 13)]
        [InlineData("what is your name", 4)]
        [InlineData("how are you", 3)]
        [InlineData("have a nice day", 4)]
        public void MatchTextToStringsTest(string text, int lengthResult)
        {
            var result = _textUtility.MatchTextToStrings(text);

            Assert.Equal(lengthResult, result.Length);
        }

        [Theory]
        [InlineData("hedge", false)]
        [InlineData("MARMALADE", true)]
        [InlineData("beginning", false)]
        [InlineData("ought", false)]
        [InlineData("across", true)]
        public void IsMiddleCharVowTest(string word, bool testResult)
        {
            var result = _textUtility.isMiddleCharVow(word);

            Assert.Equal(result, testResult);
        }
    }
}
