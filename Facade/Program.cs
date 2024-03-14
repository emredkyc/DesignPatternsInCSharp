/* This example demonstrates how the Facade pattern can simplify interactions 
 * with complex cloud storage APIs by providing a unified interface 
 * (ICloudStorageFacade) for common cloud operations. 
 * Developers can switch between different cloud providers 
 * (e.g., AWS S3, Azure Blob Storage) by changing the concrete facade implementation used, 
 * without altering the application logic that relies on cloud services. 
 * This approach enhances modularity, reduces dependency on specific cloud providers, 
 * and makes the application more adaptable to changes in cloud services. */

// Choose the desired cloud storage facade implementation
ICloudStorageFacade cloudStorage = new AwsStorageFacade(); // or new AzureStorageFacade() for Azure

string fileName = "example.txt";

// Simulated file content as a byte array
// For demonstration purposes, let's create a simple string and convert it to a byte array
string textContent = "Hello, Cloud Storage!";
byte[] fileContent = System.Text.Encoding.UTF8.GetBytes(textContent);

// Uploading simulated content to cloud storage
cloudStorage.UploadFile(fileName, fileContent);

// Assuming the download method returns the content we just uploaded
byte[] downloadedContent = cloudStorage.DownloadFile(fileName);

// Optionally, converting the downloaded byte array back to a string to verify the content
string downloadedText = System.Text.Encoding.UTF8.GetString(downloadedContent);
Console.WriteLine($"Downloaded content: {downloadedText}");
 