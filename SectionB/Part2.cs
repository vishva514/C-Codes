using System;

namespace PartialClassDemo
{
    public partial class Student
    {
        partial void OnCreated()
        {
            Console.WriteLine("Student object created successfully!");
        }
    }
}
