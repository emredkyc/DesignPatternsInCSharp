/* This example demonstrates how the CSV and JSON data processors read and 
 * process data specific to their formats by overriding the ReadData method. 
 * Each processor reads its respective data format, processes it (here, simple transformations 
 * are applied for demonstration purposes), and then the SaveData method saves the processed data. 
 * This approach showcases the flexibility of the Template Method pattern, allowing subclasses 
 * to not only provide specific behaviors for certain steps of an algorithm but also to 
 * extend or completely redefine those steps as needed. */

Console.WriteLine("CSV Processor:");
DataProcessor csvProcessor = new CsvDataProcessor();
csvProcessor.ProcessData();

Console.WriteLine("\nJSON Processor:");
DataProcessor jsonProcessor = new JsonDataProcessor();
jsonProcessor.ProcessData();