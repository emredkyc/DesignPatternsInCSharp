public class SqlDatabaseConnectionFactory : IDatabaseConnectionFactory
{
    public IDatabaseConnection CreateConnection()
    {
        return new SqlConnection();
    }
}