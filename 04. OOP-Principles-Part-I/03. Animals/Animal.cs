using System;
using System.Collections.Generic;

public abstract class Animal : ISound
{
    private string name;
    private byte age;
    private char sex;

    // consturctors
    protected Animal(string name, byte age, char sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }

    // properties 
    public char Sex
    {
        get { return sex; }
        set { sex = value; }
    }

    public byte Age
    {
        get { return age; }
        set
        {
            if (value < 1 || value > 25)
            {
                throw new ArgumentOutOfRangeException("Age should be [1,25]");
            }
            age = value;
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name cannot be null or empty!");
            }
            name = value;
        }
    }

    // methods
    public abstract void SaySomething();

    public static double CalcAverageAge(Animal[] animals)
    {
        double ageSum = 0;
        for (int i = 0; i < animals.Length; i++)
        {
            ageSum += animals[i].Age;
        }

        return ageSum / animals.Length;
    }
}