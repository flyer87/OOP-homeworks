using System;
using System.Collections.Generic;

class Class
{
    private string name;
    private List<Teacher> teachers;

    public List<Teacher> Teachers
    {
        get { return teachers; }        
    }    

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
}
