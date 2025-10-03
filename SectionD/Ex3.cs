using System;
namespace Demo
{
    public delegate void SpeakDel();
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal Sounds");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }
    class Program
    {
        static void Main()
        {
            Animal a1 = new Animal();
            Animal a2 = new Dog();
            SpeakDel d1 = a1.Speak;  
            SpeakDel d2 = a2.Speak;
            d1();
            d2();
        }
    }
}