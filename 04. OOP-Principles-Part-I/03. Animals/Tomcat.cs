using System;

public class Tomcat : Cat
{
    // constructors
    public Tomcat(string name, byte age, AnimalSex sex)
        : base(name, age, sex)
    {
        if (sex != AnimalSex.male)
        {
            throw new ArgumentOutOfRangeException("Tomcats sex might be only female");
        }
    }

    // methods
    public override void SaySomething()
    {
        System.Console.WriteLine("Tomcat's miau!");
    }
}
