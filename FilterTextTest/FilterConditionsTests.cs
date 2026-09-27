using FilterText.Business;
using FilterText.Utility;

namespace FilterText.Tests
{
    public class FilterConditionsTests
    {
        private readonly IFilterConditions _filterConditions;
        public FilterConditionsTests()
        {
            _filterConditions = new FilterConditions(new TextUtility());
        }

        [Fact]
        public void MiddleVowelRule()
        {
            string[] words = ["what", "clean", "the", "rather"];
            var result = _filterConditions.vowFiltering(words);

            Assert.Equal(2, result.Length);
        }


        [Fact]
        public void ShortWordRule()
        {
            string[] words = ["what", "clean", "the", "rather"];
            var result = _filterConditions.shortWordFiltering(words);

            Assert.Equal(3, result.Length);
        }

        [Fact]
        public void ContainTLetterRule()
        {
            string[] words = ["what", "clean", "the", "rather"];
            var result = _filterConditions.containTFiltering(words);

            Assert.Single(result);
        }
    }
}
