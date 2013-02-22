using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GSMCallHistoryTest
{
    static void Main()
    {
        GSM myGsm = new GSM("110", "Nokia", 100m, "Me - The Boss");
        myGsm.AddCall(DateTime.Parse("21.02.2013 22:45"), "+359881234567", 500);
        myGsm.AddCall(DateTime.Parse("21.02.2013 11:00"), "+359881234567", 200);
        myGsm.AddCall(DateTime.Parse("22.02.2013 13:15"), "+359881234567", 1000);

        for (int i = 0; i < myGsm.CallHistory.Count; i++)
        {
            Console.WriteLine(myGsm.CallHistory[i]);
        }

        Console.WriteLine("Total price: ");
        Console.WriteLine(myGsm.CalcTotalPrice(0.37m));

        // finding max duration
        uint maxDuration = uint.MinValue;
        for (int i = 0; i < myGsm.CallHistory.Count; i++)
        {
            if (myGsm.CallHistory[i].Duration > maxDuration)
            {
                maxDuration = myGsm.CallHistory[i].Duration;
            }
        }

        // deleting call with max duration
        myGsm.DeleteCalling(maxDuration);
        Console.Write("Longest call removed! New price: ");
        Console.WriteLine(myGsm.CalcTotalPrice(0.37m));

        //Clear call history
        myGsm.ClearCallHistory();
        Console.WriteLine("Call history after deleting it: ");
        for (int i = 0; i < myGsm.CallHistory.Count; i++)
        {
            Console.WriteLine(myGsm.CallHistory[i]);
        }

    }


}
