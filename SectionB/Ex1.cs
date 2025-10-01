using System;
class Student
{
    private int id;
    private string name;
    private int age;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set {
            if (value > 0)
                age = value;
            else
                Console.WriteLine("Age to be positive");

        }
    }
    public Student()
    {
        id = 0;
        name = "Anaya";
        age = 18;

    }
    public Student(int id) : this()
    {
        this.id = id;
    }
    public Student(int id, string name, int age) : this(id)
    {
        this.name = name;
        this.age = age;
    }
    public void Display()
    {
        Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
    }
    public void Update(string newName)
    {
        name = newName;
    }
    public void Update(string newName, int newAge)
    {
        name = newName;
        age = newAge;
    }
}
class Program
{
    static void Main()
    {
        Student s1 = new Student();
        s1.Display();
        Student s2 = new Student(101);
        s2.Display();
        Student s3 = new Student(102, "Alice", 20);
        s3.Display();
        s3.Update("Alice");
        s3.Display();
        s3.Update("Smith", 22);
    }
}