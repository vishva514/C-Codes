using System;
namespace App
{
    class Car
    {
        private  string model = "Mustang";
        static void Main()
        {
            Car obj = new Car();
            Console.WriteLine("Model " + obj.model);
        }
    }
}