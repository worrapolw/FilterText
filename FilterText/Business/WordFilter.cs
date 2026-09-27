namespace FilterText.Business
{
    public class WordFilter : IWordFilter
    {
        private readonly IFilterConditions _filters;

        public WordFilter(IFilterConditions filterCondition)
        {
            _filters = filterCondition;
        }

        public string[] filter(string[] words)
        {
            words = _filters.vowFiltering(words);
            words = _filters.shortWordFiltering(words);
            words = _filters.containTFiltering(words);
            return words;
        }
    }
}
