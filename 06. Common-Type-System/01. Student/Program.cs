using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {

        Student st = new Student("Ivo", "Ivanov", "Ivanov", "123456789", "Ruse", "+359", "a@abv.bg",
            3, University.UniofRuse, Faculty.EngineeringFaculty, Specialty.CST);

        Student st1 = new Student("Ivo", "Ivanov", "Ivanov", "123456789", "Ruse", "+359", "a@abv.bg",
            3, University.UniofRuse, Faculty.EngineeringFaculty, Specialty.CST);

        Student st2 = new Student("Ivo2", "Ivanov2", "Ivanov2", "123456799", "Ruse", "+359", "a2@abv.bg",
            3, University.SofiaUni, Faculty.EngineeringFaculty, Specialty.CST);

        // test Equals
        Console.WriteLine("Test Equals: ");
        Console.WriteLine(st.Equals(st1));

        // test !=
        Console.WriteLine(st1 != st2);

        // test Clone()
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Cloning: ");
        Console.WriteLine("");
        Student st3 = st.Clone();
        Console.WriteLine(st3);

        // test CompareTo()
        Console.WriteLine();
        Console.WriteLine("CompareTo(): ");
        Console.WriteLine(st.CompareTo(st2));
    }

    public static string st4 { get; set; }
}