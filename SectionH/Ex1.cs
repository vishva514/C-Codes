using System;
using System.Threading;

public sealed class Logger
{
    private static Logger _instance = null;
    private static readonly object _lock = new object();
    private Logger()
    {
        Console.WriteLine("Logger initialized...");
    }
    public static Logger Instance
    {
        get
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
    }
    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {message}");
    }
}

class Program
{
    static void Main()
    {
        Thread t1 = new Thread(() => Logger.Instance.Log("Message from Thread 1"));
        Thread t2 = new Thread(() => Logger.Instance.Log("Message from Thread 2"));
        Thread t3 = new Thread(() => Logger.Instance.Log("Message from Thread 3"));

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();
    }
}
