using System;
using System.Collections.Generic;

abstract class Human
{
    private string firstName;
    private string lastName;

    // constructor
    protected Human(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    // properties 
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }    
}