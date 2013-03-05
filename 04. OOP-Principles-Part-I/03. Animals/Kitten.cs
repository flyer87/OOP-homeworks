using System;

public class Kitten : Cat
{
    // constructor
    public Kitten(string name, byte age, char sex)
        : base(name, age, sex)
    {        
    }

    // methods 
    public override void SaySomething()
    {
        Console.WriteLine("Kitten's miau!");        
    }
}

