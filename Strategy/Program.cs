/* In this example, DataRenderer is the context, and IRenderStrategy is the strategy interface. 
 * JsonRenderStrategy, XmlRenderStrategy, and CsvRenderStrategy are concrete strategies. 
 * This pattern allows the DataRenderer class to change its rendering behavior dynamically, 
 * depending on the strategy object it's composed with, promoting flexibility and making it easy 
 * to introduce new rendering algorithms. */

string sampleData = "Hello, Strategy Pattern";

DataRenderer renderer = new DataRenderer(new JsonRenderStrategy());
Console.WriteLine(renderer.RenderData(sampleData)); // Renders data in JSON format

renderer.SetRenderStrategy(new XmlRenderStrategy());
Console.WriteLine(renderer.RenderData(sampleData)); // Renders data in XML format

renderer.SetRenderStrategy(new CsvRenderStrategy());
Console.WriteLine(renderer.RenderData(sampleData)); // Renders data in CSV format