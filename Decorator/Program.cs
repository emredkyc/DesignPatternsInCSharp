/* This example uses the CompressionDecorator to handle both the 
 * compression and decompression processes, simplifying the the Decorator pattern's 
 * application for file operations. It focuses on the core functionality—compressing 
 * data before writing to a file and then decompressing it upon reading */

string compressedFilePath = "compressed.gz";

// Original data to compress and write
string originalData = "This is a test string to compress and decompress.";
byte[] dataToCompress = System.Text.Encoding.UTF8.GetBytes(originalData);

// Initialize the file operation with compression decorator
IFileOperation compressedFileOp = new CompressionDecorator(new FileOperation());

// Compress and write data to file
compressedFileOp.Write(compressedFilePath, dataToCompress);
Console.WriteLine($"Data compressed and written to {compressedFilePath}");

// Read and decompress data from file
byte[] decompressedData = compressedFileOp.Read(compressedFilePath);

// Convert decompressed data back to string
string decompressedString = System.Text.Encoding.UTF8.GetString(decompressedData);
Console.WriteLine($"Decompressed data: {decompressedString}");
