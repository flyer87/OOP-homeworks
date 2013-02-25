using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        GenericList<int> gl = new GenericList<int>(5);
        gl.Add(2);
        gl.Add(500);
        gl.Add(6);
        gl.Add(-7);
        gl.RemoveAt(2);
        gl.InsertAt(1, 5);
        gl[0] = -20000;
        //gl.Clear();
        Console.WriteLine(gl.Min<int>());
        Console.WriteLine(gl.Max<int>());
    }
}





