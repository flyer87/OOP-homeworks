using System;
using System.Text;

class Person
{
    #region Fileds
    private string name;
    private byte? age;
    #endregion

    #region Constructors
    public Person(string name, byte? age)
    {
        this.Name = name;
        this.Age = age;
    }

    #endregion

    #region Properties
    public string Name
    {
        get { return name; }
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty or null!");
            }
            name = value;
        }
    }

    public byte? Age
    {
        get { return age; }
        set
        {
            if (value > 150)
            {
                throw new ArgumentOutOfRangeException("Age could not be grater than 150!");
            }
            age = value;
        }
    }
    #endregion 

    #region Methods
    public override string ToString()
    {
        string temp = "Name: " + this.Name + "\r\n";
        if (Age == null)
        {
            temp = temp + "Age:  not specified!";
        }
        else
        {
            temp += "Age: " + this.Age;
        }

        return temp;
    }
    #endregion 

}