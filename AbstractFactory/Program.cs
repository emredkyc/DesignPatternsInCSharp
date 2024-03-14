/* In this example, IParserFactory acts as the abstract factory that defines a method 
 * for each kind of parser product (IJsonParser, IXmlParser, ICsvParser). 
 * The ParserFactory concrete factory implements these methods, creating instances of 
 * the concrete products (JsonParser, XmlParser, CsvParser). This pattern allows you to 
 * introduce new parser types or parser families (factories) without changing the client 
 * code that uses the parsers, adhering to the open/closed principle. */

IParserFactory parserFactory = new ParserFactory();

var jsonParser = parserFactory.CreateJsonParser();
jsonParser.Parse("{\"name\": \"John Doe\"}");

var xmlParser = parserFactory.CreateXmlParser();
xmlParser.Parse("<name>John Doe</name>");

var csvParser = parserFactory.CreateCsvParser();
csvParser.Parse("name,John Doe");