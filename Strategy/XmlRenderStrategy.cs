public class XmlRenderStrategy : IRenderStrategy
{
    public string Render(string data)
    {
        // Simulate converting data to XML format
        return $"<data>{data}</data>";
    }
}
