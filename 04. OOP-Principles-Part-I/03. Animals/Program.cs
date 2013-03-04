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
                new Dog( "Dog1", 4, 'm'),
                new Dog( "Dog2", 6, 'm'),
                new Dog( "Dog3", 1, 'm'),
                new Dog( "Dog4", 2, 'f')
            };


        Frog[] frogs =
            {
                new Frog( "Frog1", 100,'m'),
                new Frog( "Frog2", 5,'f'),
                new Frog( "Frog3", 7,'m'),
                new Frog( "Frog4", 2,'f')
            };


        Cat[] cats =
            {
                new Kitten("Cat1", 3,'m'),
                new Tomcat("Cat2", 5,'f'),
                                   
                new Kitten("Cat3", 2,'f'),
                new Tomcat("Cat4", 1,'m')
            };

        double avgFrogs = frogs.Average(x => x.Age);
        Console.WriteLine("Average of cats: {0:0.00}",avgFrogs);

        // by static method Animals.CalcAverageAge()
        double avgDogs = Animal.CalcAverageAge(dogs);
        Console.WriteLine("Average of dogs: {0:0.00}", avgDogs);

        // ??? Kitten female 

       
    }
}
