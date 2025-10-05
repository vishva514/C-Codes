using System;
public interface IShape
{
    void Draw();
}
public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

public class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Square");
    }
}

public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Rectangle");
    }
}
public abstract class ShapeFactory
{
    public abstract IShape CreateShape();
}

public class CircleFactory : ShapeFactory
{
    public override IShape CreateShape()
    {
        return new Circle();
    }
}

public class SquareFactory : ShapeFactory
{
    public override IShape CreateShape()
    {
        return new Square();
    }
}

public class RectangleFactory : ShapeFactory
{
    public override IShape CreateShape()
    {
        return new Rectangle();
    }
}

class Program
{
    static void Main()
    {
        ShapeFactory circleFactory = new CircleFactory();
        ShapeFactory squareFactory = new SquareFactory();
        ShapeFactory rectangleFactory = new RectangleFactory();
        IShape circle = circleFactory.CreateShape();
        circle.Draw();

        IShape square = squareFactory.CreateShape();
        square.Draw();

        IShape rectangle = rectangleFactory.CreateShape();
        rectangle.Draw();
    }
}
