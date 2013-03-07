﻿using System;
using System.Collections.Generic;

public class Dog : Animal
{
    // constructors
    public Dog(string name, byte age, AnimalSex sex)
        : base(name, age, sex)
    {
    }

    // methods
    public override void SaySomething()
    {
        Console.WriteLine("Bau!");
    }
}
