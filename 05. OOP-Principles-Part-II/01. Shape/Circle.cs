using System;

public class Circle : Shape
{
    // constructoe
    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius should be positive!");
        }
        this.Height = radius;
        this.Width = radius;
    }

    // methods
    public override double CalculateSurface()
    {
        return Math.PI * Height * Height;
    }
}
