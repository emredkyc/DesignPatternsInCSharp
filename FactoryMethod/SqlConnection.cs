public class SqlConnection : IDatabaseConnection
{
    public void Connect()
    {
        Console.WriteLine("Connecting to SQL Database...");
    }

    public void Disconnect()
    {
        Console.WriteLine("Disconnecting from SQL Database...");
    }
}