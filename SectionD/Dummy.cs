using System;

class Student
{
    public static void print()
    {
        Console.WriteLine("print");
        //Student student = new Student();
        //student.display();

    }

    public void display()
    {
        Console.WriteLine("Display");
        print();

    }
}
class Program
{
    static void Main()
    {
        Student student = new Student();
        student.display();
    }
}