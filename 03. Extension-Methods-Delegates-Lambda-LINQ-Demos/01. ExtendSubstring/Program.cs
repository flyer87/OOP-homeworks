using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //StringBuilder myBuilder = new StringBuilder("Example");
        //StringBuilder newBuilder = myBuilder.Substring(1, 2);
        Console.WriteLine( (new StringBuilder("Example")).Substring(1,200).ToString());
    }
}