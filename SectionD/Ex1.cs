using System;

namespace DelegateDemo
{

    public delegate double MathOperation(double x, double y);

    class Program
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero!");
                return 0;
            }
            return a / b;
        }

        public static void Main()
        {
            MathOperation op;
            op = Add;
            Console.WriteLine("Add: " + op(10, 5));

            op = Subtract;
            Console.WriteLine("Subtract: " + op(10, 5));

            op = Multiply;
            Console.WriteLine("Multiply: " + op(10, 5));

            op = Divide;
            Console.WriteLine("Divide: " + op(10, 5));
        }
    }
}
