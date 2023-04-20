using System;

// Abstraction: Define an abstract base class to provide a common interface
// for derived classes and hide implementation details.
public abstract class Shape
{
    public abstract double GetArea();
}

// Encapsulation: Define a concrete class to encapsulate data and behavior.
public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}

// Inheritance: Define a derived class that inherits from the base class and
// adds new data and behavior.
public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
    }

    public override double GetArea()
    {
        return _width * _height;
    }
}

// Polymorphism: Use a common interface to operate on objects of different types.
public class AreaCalculator
{
    public static double CalculateArea(Shape shape)
    {
        return shape.GetArea();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(10, 5);

        double circleArea = AreaCalculator.CalculateArea(circle);
        double rectangleArea = AreaCalculator.CalculateArea(rectangle);

        Console.WriteLine("Circle area: " + circleArea);
        Console.WriteLine("Rectangle area: " + rectangleArea);
        Console.ReadKey();
    }
}
