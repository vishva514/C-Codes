using System;
using System.Threading;
using System.Threading.Tasks;

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
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] {message} | Instance Hash: {this.GetHashCode()}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Using Threads ===");
        Thread[] threads = new Thread[5];
        for (int i = 0; i < 5; i++)
        {
            int id = i;
            threads[i] = new Thread(() => Logger.Instance.Log($"Thread {id} logging"));
            threads[i].Start();
        }
        foreach (var t in threads) t.Join();

        Console.WriteLine("\n=== Using Tasks ===");
        Task[] tasks = new Task[5];
        for (int i = 0; i < 5; i++)
        {
            int id = i;
            tasks[i] = Task.Run(() => Logger.Instance.Log($"Task {id} logging"));
        }
        Task.WaitAll(tasks);

        Console.WriteLine("\nProgram ended.");
    }
}

