namespace FilterText.Business
{
    public interface IFilterConditions
    {
        string[] vowFiltering(string[] words);
        string[] shortWordFiltering(string[] words);
        string[] containTFiltering(string[] words);
    }
}
