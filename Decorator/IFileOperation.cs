public interface IFileOperation
{
    byte[] Read(string filePath);
    void Write(string filePath, byte[] data);
}
