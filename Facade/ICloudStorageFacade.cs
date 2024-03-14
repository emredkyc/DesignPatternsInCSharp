public interface ICloudStorageFacade
{
    void UploadFile(string fileName, byte[] fileContent);
    byte[] DownloadFile(string fileName);
}