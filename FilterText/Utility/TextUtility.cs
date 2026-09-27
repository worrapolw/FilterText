using System.Text.RegularExpressions;

namespace FilterText.Utility
{
    public class TextUtility : ITextUtility
    {
        private static readonly Regex Words = new("[a-zA-Z]+");
        private static string[] vows = ["a", "e", "i", "o", "u"];

        public string[] MatchTextToStrings(string text)
        {
            return Words.Matches(text).Select(match => match.Value).ToArray();
        }

        private bool ContainsVow(string letter)
        {
            return vows.Any(vow => letter.ToLower().Contains(vow));
        }

        public bool isMiddleCharVow(string word)
        {
            if (word.Length == 0) return false;

            int middle = word.Length / 2;
            return ContainsVow(word[middle].ToString())
                || word.Length % 2 == 0 && ContainsVow(word[middle - 1].ToString());
        }
    }
}
