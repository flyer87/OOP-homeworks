using System;

public class Kitten : Cat
{
    // constructor
    public Kitten(string name, byte age, AnimalSex sex)
        : base(name, age, sex)
    {
        if (sex != AnimalSex.female)
        {
            throw new ArgumentOutOfRangeException("Kitten's sex might be only female");
        }

    }

    // methods 
    public override void SaySomething()
    {
        Console.WriteLine("Kitten's miau!");
    }
}

