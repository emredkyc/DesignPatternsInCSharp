public interface IParserFactory
{
    IJsonParser CreateJsonParser();
    IXmlParser CreateXmlParser();
    ICsvParser CreateCsvParser();
}