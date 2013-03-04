using System;
using System.Collections.Generic;

class Student : Human
{
    private byte grade;

    //constructors
    public Student(string firstName, string lastName, byte grade)
        :base(firstName, lastName)
    {
        this.grade = grade;
    }

    // properties 
    public byte Grade
    {
        get { return grade; }
        set { grade = value; }
    }
    
}

