//using System;

//public abstract class Shape
//{
//    public abstract double GetArea();
//}

//public class Circle : Shape
//{
//    private double _radius;

//    public Circle(double radius)
//    {
//        _radius = radius;
//    }

//    public override double GetArea()
//    {
//        return Math.PI * _radius * _radius;
//    }
//}

//public class Rectangle : Shape
//{
//    private double _width;
//    private double _height;

//    public Rectangle(double width, double height)
//    {
//        _width = width;
//        _height = height;
//    }

//    public override double GetArea()
//    {
//        return _width * _height;
//    }
//}

//public class AreaCalculator
//{
//    public static double CalculateArea(Shape shape)
//    {
//        return shape.GetArea();
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Circle circle = new Circle(5);
//        Rectangle rectangle = new Rectangle(10, 5);

//        double circleArea = AreaCalculator.CalculateArea(circle);
//        double rectangleArea = AreaCalculator.CalculateArea(rectangle);

//        Console.WriteLine("Circle area: " + circleArea);
//        Console.WriteLine("Rectangle area: " + rectangleArea);
//        Console.ReadKey();
//    }
//}

//2
//using HW2_Others;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Student student = new Student(20, "Joe");
//        Instructor instructor = new Instructor(50, "Attony");
//        student.SayHi();
//        instructor.SayHi();
//    }
//}

//3
using HW2_Others;

class Program
{
    static void Main(string[] args)
    {
        Color red = new Color(255, 0, 0);
        Color blue = new Color(0, 0, 255);

        Ball ball1 = new Ball(10, red);
        Ball ball2 = new Ball(20, blue);

        ball1.Throw();
        ball1.Throw();
        ball2.Throw();

        Console.WriteLine("Ball 1 throw count: " + ball1.GetThrowCount());
        Console.WriteLine("Ball 2 throw count: " + ball2.GetThrowCount());

        ball1.Pop();
        ball2.Throw();
        ball2.Throw();
        ball2.Pop();

        Console.WriteLine("Ball 1 throw count: " + ball1.GetThrowCount());
        Console.WriteLine("Ball 2 throw count: " + ball2.GetThrowCount());
    }
}
