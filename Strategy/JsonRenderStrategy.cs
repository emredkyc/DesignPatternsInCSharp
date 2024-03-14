public class JsonRenderStrategy : IRenderStrategy
{
    public string Render(string data)
    {
        // Simulate converting data to JSON format
        return $"{{\"data\": \"{data}\"}}";
    }
}
