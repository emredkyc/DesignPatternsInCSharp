public abstract class FileOperationDecorator : IFileOperation
{
    protected IFileOperation fileOperation;

    protected FileOperationDecorator(IFileOperation fileOperation)
    {
        this.fileOperation = fileOperation;
    }

    public virtual byte[] Read(string filePath)
    {
        return fileOperation.Read(filePath);
    }

    public virtual void Write(string filePath, byte[] data)
    {
        fileOperation.Write(filePath, data);
    }
}
