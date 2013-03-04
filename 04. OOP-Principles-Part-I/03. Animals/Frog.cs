class Frog : Animal
{
    // constructors
    public Frog(string name, byte age, char sex)
        : base(name, age, sex)
    {
    }

    // methods
    public override void SaySomething()
    {
        System.Console.WriteLine("Fooorg!");
    }
}
