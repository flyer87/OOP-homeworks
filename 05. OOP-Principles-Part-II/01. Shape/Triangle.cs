using System;

public class Triangle : Shape
{
    // constructors
    public Triangle(double heigth, double width)
        : base(heigth, width)
    {
    }

    // methods 
    public override double CalculateSurface()
    {
        return this.Height * this.Width / 2;
    }
}