using System;
using System.Threading.Tasks;

class Program
{
    public static async Task<string> FetchDataAsync()
    {
        Console.WriteLine("Fetching data...");

        return "Data fetched successfully!";
    }

    public static async Task Main()
    {
        Console.WriteLine("Program started");
        string result = await FetchDataAsync();

        Console.WriteLine(result);
        Console.WriteLine("Program ended");
    }
}
