using System.IO;
using System.IO.Compression;

public class CompressionDecorator : IFileOperation
{
    private readonly IFileOperation _fileOperation;

    public CompressionDecorator(IFileOperation fileOperation)
    {
        _fileOperation = fileOperation;
    }

    public byte[] Read(string filePath)
    {
        Console.WriteLine("Decompressing data after reading from file.");
        var compressedData = _fileOperation.Read(filePath);
        using (var input = new MemoryStream(compressedData))
        using (var gzipStream = new GZipStream(input, CompressionMode.Decompress))
        using (var output = new MemoryStream())
        {
            gzipStream.CopyTo(output);
            var decompressedData = output.ToArray();
            Console.WriteLine("Data decompressed.");
            return decompressedData;
        }
    }

    public void Write(string filePath, byte[] data)
    {
        Console.WriteLine("Compressing data before writing to file.");
        using (var output = new MemoryStream())
        {
            using (var gzipStream = new GZipStream(output, CompressionMode.Compress))
            {
                gzipStream.Write(data, 0, data.Length);
            }
            var compressedData = output.ToArray();
            _fileOperation.Write(filePath, compressedData);
        }
        Console.WriteLine("Data compressed and written to file.");
    }
}


