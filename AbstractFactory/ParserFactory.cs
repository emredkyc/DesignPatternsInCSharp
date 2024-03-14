public class ParserFactory : IParserFactory
{
    public IJsonParser CreateJsonParser()
    {
        return new JsonParser();
    }

    public IXmlParser CreateXmlParser()
    {
        return new XmlParser();
    }

    public ICsvParser CreateCsvParser()
    {
        return new CsvParser();
    }
}