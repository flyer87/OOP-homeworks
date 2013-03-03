using System;
using System.Collections.Generic;

class Discipline
{
    // -= Fields =-
    private string name;
    private byte numOfLectures;
    private byte numOfExcercies;

    // -= Constructors =-
    public Discipline(string name)
    {
        this.name = name;
    }

    // -= Properties =-
    public byte NumOfExcercies
    {
        get { return numOfExcercies; }
        set { numOfExcercies = value; }
    }    

    public byte NumOfLectures
    {
        get
        {
            return numOfLectures;
        }
        set
        {
            numOfLectures = value;
        }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // -= Methods =-
 
}
