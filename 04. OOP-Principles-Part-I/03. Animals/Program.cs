using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dog[] dogs =
            {
                new Dog( "Dog1", 4, AnimalSex.male),
                new Dog( "Dog2", 6, AnimalSex.male),
                new Dog( "Dog3", 1, AnimalSex.male),
                new Dog( "Dog4", 2, AnimalSex.female)
            };


        Frog[] frogs =
            {
                // new Frog( "Frog1", 100, AnimalSex.male), - throws exception, beacause age should be [1,25]
                new Frog( "Frog1", 1, AnimalSex.male),
                new Frog( "Frog2", 5,AnimalSex.female),
                new Frog( "Frog3", 7,AnimalSex.male),
                new Frog( "Frog4", 2,AnimalSex.female)
            };

        Cat[] cats =
            {
                // new Kitten("Cat1", 3, AnimalSex.male), - throws exception !!! because Kitten might be only female
                new Kitten("Cat1", 3,AnimalSex.female),
                new Tomcat("Cat2", 5, AnimalSex.male),
                                   
                new Kitten("Cat3", 2,AnimalSex.female),
                new Tomcat("Cat4", 1,AnimalSex.male)
            };

        double avgFrogs = frogs.Average(x => x.Age);
        Console.WriteLine("Average of cats: {0:0.00}", avgFrogs);

        // by static method Animals.CalcAverageAge()
        double avgDogs = Animal.CalcAverageAge(dogs);
        Console.WriteLine("Average of dogs: {0:0.00}", avgDogs);
    }
}
