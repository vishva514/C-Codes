using System;

namespace MyApplication
{

    abstract class Shape
    {

        public abstract double CalculateArea();
        public void Display()
        {
            Console.WriteLine("This is a shape.");
        }
    }


    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            circle.Display();
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

            rectangle.Display();
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
        }
    }
}
