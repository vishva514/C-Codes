using System;

namespace MyApplication
{
   
    class Vehicle
    {
        public string Brand { get; set; }

        public void Start()
        {
            Console.WriteLine($"{Brand} is starting...");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} is stopping...");
        }
    }

    class Car : Vehicle
    {
        public int Doors { get; set; }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Car Brand: {Brand}, Doors: {Doors}");
        }
    }

    class Bike : Vehicle
    {
        public bool HasCarrier { get; set; }

        public void ShowBikeInfo()
        {
            Console.WriteLine($"Bike Brand: {Brand}, Carrier: {HasCarrier}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car();
            myCar.Brand = "Toyota";
            myCar.Doors = 4;
            myCar.Start();      
            myCar.ShowCarInfo();
            myCar.Stop();

            Console.WriteLine();

            Bike myBike = new Bike();
            myBike.Brand = "Yamaha";
            myBike.HasCarrier = true;
            myBike.Start();      
            myBike.ShowBikeInfo();
            myBike.Stop();
        }
    }
}
