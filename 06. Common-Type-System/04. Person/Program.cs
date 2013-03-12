using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // test Age = null
        Person person1 = new Person("John", null);
        Console.WriteLine(person1);

        // test Age grater than 150 - throws expcetion
        // Person person2 = new Person("Cris", 151);

        // test Name is null - throws expcetion
        Person person3 = new Person(null, null);
        Console.WriteLine(person3);
    }
}
