using System;
using System.Collections.Generic;

public class Cat : Animal
{
    // constructors
    public Cat(string name, byte age, AnimalSex sex)
        : base(name, age, sex)
    {
    }

    // methods
    public override void SaySomething()
    {
        Console.WriteLine("Miau!");
    }
}