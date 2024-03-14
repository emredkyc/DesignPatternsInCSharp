/* This approach checks twice if the instance is null—the first check 
 * avoids locking each time the instance is requested; the second check, 
 * inside the lock, ensures thread safety. */

public class DoubleCheckedSingleton
{ 
    private static DoubleCheckedSingleton? instance;
    private static readonly object lockObject = new object();

    private DoubleCheckedSingleton() { }

    public static DoubleCheckedSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new DoubleCheckedSingleton();
                    }
                }
            }
            return instance;
        }
    }
}
