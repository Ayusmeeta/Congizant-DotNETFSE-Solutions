using System;

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        logger1.Log("First message");
        logger2.Log("Second message");

        // Check if both references are same
        Console.WriteLine(object.ReferenceEquals(logger1, logger2));
    }
}