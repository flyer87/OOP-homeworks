using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>() 
        { 
            new Student("Ivan", "Ivanov", 9),
            new Student("Greorgi", "Pozitano", 10),
            new Student("Hasan", "Ahmed", 11),
            new Student("Radka", "Mincheva", 8),
            new Student("Mehmed", "Mehmed", 7),
            new Student("Stoyan", "Trifonov", 12),
            new Student("Ewstat", "Kirkorov", 11),
            new Student("Asen", "Razctvetnikow", 10),
            new Student("Yusuf", "Adem", 9),
            new Student("Alex", "Affleck", 9)
        };

        // by EXTENSION METHOD: 
        var sortedStudents = students.OrderBy(stud => stud.Grade);
        // ??? etxension method za printwane na sdarjanie na list-a

        // by LINQ 
        var sortedStudents2 =
            from st in students
            orderby st.Grade ascending
            select st;

        foreach (var student in sortedStudents2)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName + "; Grade: " + student.Grade);
        }


        List<Worker> workers = new List<Worker>() 
        { 
            new Worker("Ivan", "Ivanov", 600m, 40),
            new Worker("Greorgi", "Pozitano",  550m, 38),
            new Worker("Hasan", "Ahmed",  650m, 42),
            new Worker("Radka", "Mincheva",  700m, 42),
            new Worker("Mehmed", "Mehmed", 400, 35),
            new Worker("Stoyan", "Trifonov", 600m, 40),
            new Worker("Ewstat", "Kirkorov", 550m, 36),
            new Worker("Asen", "Razctvetnikow",  700m, 40),
            new Worker("Yusuf", "Adem", 650m, 30),
            new Worker("Alex", "Affleck", 450m, 36),
        };

        var sortedWorkers =
            from w in workers
            orderby w.MoneyPerHour() descending
            select w;

        Console.WriteLine();
        Console.WriteLine("Workers:");
        foreach (var worker in sortedWorkers)
        {
            Console.WriteLine(worker.FirstName + " " + worker.LastName + "; MoneyPerHour: " + worker.MoneyPerHour().ToString("F2"));
        }

        Console.WriteLine();
        Console.WriteLine("Concated and sorted: ");
        var humans = students.Concat<Human>(workers).OrderBy(h => h.FirstName).ThenBy(h => h.LastName);
        foreach (var human in humans)
        {
            Console.WriteLine(human.FirstName+ " " + human.LastName);
        }
    }
}