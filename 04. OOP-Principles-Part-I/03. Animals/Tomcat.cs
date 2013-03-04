public class Tomcat : Cat
{
    // constructors
    public Tomcat(string name, byte age, char sex)
        : base(name, age, sex)
    {
    }

    // methods
    public override void SaySomething()
    {
        System.Console.WriteLine("Tomcat's miau!");
    }
}
