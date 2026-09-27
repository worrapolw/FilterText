using FilterText.Business;
using FilterText.Utility;

namespace FilterText.Tests
{
    public class FilterTextTests
    {
        public readonly IWordFilter _wordFilter;
        public FilterTextTests()
        {
            _wordFilter = new WordFilter(new FilterConditions(new TextUtility()));
        }


    }
}
