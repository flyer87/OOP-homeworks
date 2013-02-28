using System;
using System.Collections.Generic;
using System.Linq;

static class Extention
{
    public static void PrintAll<T>(this IEnumerable<T> items)
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}

class Program
{

    static void Main()
    {
        var students = new[] { 
            new { FirstName = "Asen", LastName = "Stoyanov", Age = 22 },
            new { FirstName = "Asen", LastName = "Asenov", Age = 22 },
            new { FirstName = "Ivan", LastName = "Ivanov", Age = 27 },
            new { FirstName = "Stanka",  LastName = "Stanipetkowa", Age = 18 }
        };

        /* 03. Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators. */
        var filteredStud =
            from student in students
            where student.FirstName.CompareTo(student.LastName) < 0
            select student;

        Console.WriteLine("Studnents whos firstname < lastname alphabetically: ");
        filteredStud.PrintAll<object>();


        /*  04. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.  */
        Console.WriteLine("Students with age between 18 and 24: ");     
        var strictedStudent =
            from student in students
            where student.Age >= 18 && student.Age <= 24
            select new { FirstName = student.FirstName, LastName = student.LastName };

        strictedStudent.PrintAll<object>();

        /* 05. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ. */
        Console.WriteLine("Sorted students (lambda expressions): ");
        var sortedStudents = 
              students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName);
        sortedStudents.PrintAll();

        /* Rewrite the same with LINQ */
        Console.WriteLine("Sorted students (LINQ): ");
        var sortedStudents2 =
            from stud in students
            orderby stud.FirstName descending, stud.LastName descending
            select stud;
        sortedStudents2.PrintAll();


    }
}
