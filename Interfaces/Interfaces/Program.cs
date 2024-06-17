using System;

// Interface
public interface IMovable
{
    void Move();
}

// Class that implements IMovable
public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Class that implements IMovable
public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

// Main method
public class Program
{
    public static void Main()
    {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();

        car.Move();  // Outputs: Car is moving
        bicycle.Move();  // Outputs: Bicycle is moving
    }
}

