using System;
using System.Collections.Generic;

public class Teacher
{
    private string name;
    private List<Discipline> disciplines;

    // constructors
    public Teacher(string name)
    {
        this.name = name;
    }

    // properties
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public List<Discipline> Disciplines
    {
        get
        {
            return disciplines;
        }
    }


    //methods 
    public void Add(Discipline discipline)
    {
        disciplines.Add(discipline);
    }
    public void RemoveAt(int index)
    {
        disciplines.RemoveAt(index);
    }


}