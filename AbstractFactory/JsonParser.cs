public class JsonParser : IJsonParser
{
    public void Parse(string input)
    {
        Console.WriteLine($"Parsing JSON: {input}");
    }
}
