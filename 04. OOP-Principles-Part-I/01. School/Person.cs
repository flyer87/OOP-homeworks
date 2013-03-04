using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private string name;

    // constructors
    public Person()
    {
    }

    public Person(string name)
    {
        this.name = name;
    }


    //properties 
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

}