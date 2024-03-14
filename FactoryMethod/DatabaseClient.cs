public class DatabaseClient
{
    private readonly IDatabaseConnection connection;

    public DatabaseClient(IDatabaseConnectionFactory factory)
    {
        connection = factory.CreateConnection();
    }

    public void UseDatabase()
    {
        connection.Connect();
        // Perform database operations...
        connection.Disconnect();
    }
}