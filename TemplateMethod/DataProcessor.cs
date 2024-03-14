public abstract class DataProcessor
{
    // The template method
    public void ProcessData()
    {
        var data = ReadData();
        var processedData = ProcessDataCore(data);
        SaveData(processedData);
    }

    protected virtual string ReadData()
    {
        // Generic implementation, can be overridden
        Console.WriteLine("Reading generic data...");
        return "Sample data";
    }

    protected abstract string ProcessDataCore(string data); // Requires implementation

    protected virtual void SaveData(string data)
    {
        // Default implementation for saving data
        Console.WriteLine($"Saving data: {data}");
    }
}
