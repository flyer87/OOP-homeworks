using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        GenericList<double> gl = new GenericList<double>(5);
        gl.Add(2.3);
        gl.Add(5.4);
        gl.Add(6.5);
        gl.Add(7.5);
        gl.RemoveAt(1);
        gl.InsertAt(1, 5.9);
        //gl.Clear();
        Console.WriteLine(gl);
    }
}





