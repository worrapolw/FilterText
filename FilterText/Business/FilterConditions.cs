using FilterText.Utility;

namespace FilterText.Business
{
    public class FilterConditions : IFilterConditions
    {
        private readonly ITextUtility _textUtility;

        public FilterConditions(ITextUtility textUtility)
        {
            _textUtility = textUtility;
        }

        public string[] vowFiltering(string[] words)
        {
            return words.Where(w => w.Length > 0 && !_textUtility.isMiddleCharVow(w)).ToArray();
        }

        public string[] shortWordFiltering(string[] words)
        {
            return words.Where(w => w.Length > 3).ToArray();
        }

        public string[] containTFiltering(string[] words)
        {
            return words.Where(w => !w.Contains('t')).ToArray();
        }
    }
}
