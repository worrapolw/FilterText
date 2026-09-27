using FilterText.Business;
using FilterText.Utility;

string directoryPath = AppContext.BaseDirectory;
string filePath = Path.Combine(directoryPath, "input.txt");
string resultFilePath = Path.Combine(directoryPath, "result.txt");
string emptyLine = "\r\n";
ITextUtility _textUtility = new TextUtility();
IFilterConditions _filterConditions = new FilterConditions(_textUtility);
IWordFilter _filter = new WordFilter(_filterConditions);

try
{
    Console.WriteLine("Loading file from:" + filePath);
    string text = File.ReadAllText(filePath);
    Console.WriteLine("Loaded file:" + text);
    string[] words = _textUtility.MatchTextToStrings(text);
    Console.WriteLine("Matched all Text to " + words.Length + " words" + emptyLine);

    string[] filteredWords = _filter.filter(words);
    string resultText = String.Join(' ', filteredWords);
    Console.WriteLine("Result: " + resultText + emptyLine);
    File.WriteAllText(resultFilePath, resultText);
    Console.WriteLine("Done Write Result File at " + resultFilePath);
}
catch (Exception exception)
{
    Console.Error.WriteLine($"Unable to read input file: " + exception.Message);
}
Console.WriteLine("Press any key to close this window . . .");
Console.ReadKey();