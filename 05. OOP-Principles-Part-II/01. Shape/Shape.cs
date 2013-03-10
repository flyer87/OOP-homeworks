using System;
using System.Collections.Generic;

public abstract class Shape
{
    private double height;
    private double width;

    //constructor
    protected Shape(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    protected Shape()
    {
        this.height = 0;
        this.width = 0;
    }

    // properties 
    public double Height
    {
        get
        {
            return height;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Height must be positive!");
            }
            height = value;
        }
    }

    public double Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Widht must be positive!");
            }
            width = value;
        }
    }

    // methods - ili protected ???
    public abstract double CalculateSurface();

    public override string ToString()
    {
        return this.GetType() + ": " + CalculateSurface();        
    } 
}
