using System;
namespace App
{
    class Car
    {
        protected string model = "Mustang";
    }
    class SportsCar : Car
    {
        public void show()
        {
            Console.WriteLine("SportsCar " + model);
        }
    }
    class Program
    {
        static void Main()
        {
            SportsCar c = new SportsCar();
            c.show();
        }
    }
}