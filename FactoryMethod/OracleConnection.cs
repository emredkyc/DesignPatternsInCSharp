public class OracleConnection : IDatabaseConnection
{
    public void Connect()
    {
        Console.WriteLine("Connecting to Oracle Database...");
    }

    public void Disconnect()
    {
        Console.WriteLine("Disconnecting from Oracle Database...");
    }
}