using System;

public class Logger
{
    // Step 1: private static instance
    private static Logger _instance;

    // Step 2: lock object for thread safety (important best practice)
    private static readonly object _lock = new object();

    // Step 3: private constructor (prevents external instantiation)
    private Logger()
    {
        Console.WriteLine("Logger instance created");
    }

    // Step 4: public static method to get the single instance
    public static Logger GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
            }
        }
        return _instance;
    }

    // Example method
    public void Log(string message)
    {
        Console.WriteLine($"LOG: {message}");
    }
}