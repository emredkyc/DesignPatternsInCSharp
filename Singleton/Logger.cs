/* Simple implementation of Singleton.
 * Note:  Don't use, its not thread safe! */

public class Logger
{
    private static Logger? instance;
    private static readonly object lockObject = new object();

    private Logger() { }

    public static Logger Instance
    {
        get
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }
    }

    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}
