public class CsvParser : ICsvParser
{
    public void Parse(string input)
    {
        Console.WriteLine($"Parsing CSV: {input}");
    }
}