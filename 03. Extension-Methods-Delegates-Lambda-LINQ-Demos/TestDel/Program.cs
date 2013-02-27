using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDel
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar =  new { Color = "Red", Brand = "BMW", Speed = 180 };
            Console.WriteLine("My car is a {0} {1}.",
              myCar.Color, myCar.Brand);

        }
    }
}
