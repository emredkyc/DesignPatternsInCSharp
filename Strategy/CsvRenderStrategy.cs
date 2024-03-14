public class CsvRenderStrategy : IRenderStrategy
{
    public string Render(string data)
    {
        // Simulate converting data to CSV format
        return $"data,{data}";
    }
}
