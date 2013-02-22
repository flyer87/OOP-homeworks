using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GSMTest
{
    static void Main3()
    {
        GSM[] testGsm = new GSM[2];
        testGsm[0] = new GSM("Galaxy", "Samsung", 1500m, "Yumer Yumer");
        testGsm[1] = new GSM("Nokia", "7654", 70m, "Ivan Ivanov");

        Console.WriteLine("Info about GSMs");
        for (int i = 0; i < testGsm.Length; i++)
        {
            Console.WriteLine(testGsm[i]);
        }

        Console.WriteLine("Value about static property IPhone4S --->  " + GSM.IPhone4S);
    }
}
