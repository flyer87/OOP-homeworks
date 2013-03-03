using System;
using System.Collections.Generic;

class School
{
    private List<Class> classes;

    // -= Constructors =-
    public School()
    {
    }

    // -= Properties =-
    public List<Class> Classes
    {
        get { return classes; }
    }


    // -= Methods =-
    public void Add(Class newClass)
    {
        classes.Add(newClass);
    }
    public void RemoveAt(int index)
    {
        classes.RemoveAt(index);
    }

}