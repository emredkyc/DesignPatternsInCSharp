/* In this example, IDatabaseConnectionFactory serves as a contract 
 * for creating database connections, and concrete factories implement 
 * this interface to provide specific connection types. 
 * This pattern effectively decouples the instantiation logic from the 
 * client code, making the system easier to extend and maintain. */

IDatabaseConnectionFactory factory;

// The choice of factory can be dynamically decided based on configuration or environment settings
factory = new SqlDatabaseConnectionFactory();
// For Oracle: factory = new OracleDatabaseConnectionFactory();

DatabaseClient client = new DatabaseClient(factory);
client.UseDatabase();