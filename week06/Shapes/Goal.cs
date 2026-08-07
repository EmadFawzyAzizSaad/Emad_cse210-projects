// Child class for Circle shape
using System;

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Overriding to compute circle area (Math.PI * radius * radius)
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
