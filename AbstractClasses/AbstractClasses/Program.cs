using System;

// Abstract base class
public abstract class Shape
{
    public abstract double GetArea();
}

// Derived class
public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

// Derived class
public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double GetArea()
    {
        return length * width;
    }
}

// Main method
public class Program
{
    public static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Circle circle = new Circle(radius);

        Console.Write("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());
        Rectangle rectangle = new Rectangle(length, width);

        Console.WriteLine("Area of circle: " + circle.GetArea());
        Console.WriteLine("Area of rectangle: " + rectangle.GetArea());
    }
}

