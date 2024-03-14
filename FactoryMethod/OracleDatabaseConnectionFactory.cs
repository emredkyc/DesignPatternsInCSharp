public class OracleDatabaseConnectionFactory : IDatabaseConnectionFactory
{
    public IDatabaseConnection CreateConnection()
    {
        return new OracleConnection();
    }
}