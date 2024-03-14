public class FileOperation : IFileOperation
{
    public byte[] Read(string filePath)
    {
        Console.WriteLine($"Reading file {filePath}.");
        return File.ReadAllBytes(filePath);
    }

    public void Write(string filePath, byte[] data)
    {
        Console.WriteLine($"Writing to file {filePath}.");
        File.WriteAllBytes(filePath, data);
    }
}
