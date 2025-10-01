using System;

namespace PartialClassDemo
{
    public partial class Student
    {
        private int id;
        private string name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
            OnCreated();
        }

        public void Display()
        {
            Console.WriteLine($"ID: {id}, Name: {name}");
        }

        partial void OnCreated();
    }
}
