/* This approach leverages the .NET built-in support for lazy initialization, 
 * ensuring that the instance is created in a thread-safe manner without 
 * significant performance overhead. */

public class LazySingleton
{
    private static readonly Lazy<LazySingleton> lazy =
        new Lazy<LazySingleton>(() => new LazySingleton());

    public static LazySingleton Instance => lazy.Value;

    private LazySingleton() { }

    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}