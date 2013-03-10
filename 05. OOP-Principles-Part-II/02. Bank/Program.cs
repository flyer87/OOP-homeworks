using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Account myDepositAccount = new DepositAccount(Customers.Individual, 1200m, 1.2m);
        // Console.WriteLine("Interest: " + myDepositAccount.CalcInterstAmount(2));

        //Account myIndividualMortgageAccount = new MortgageAccount(Customers.Individual, 1000m, 3.4m);
        //Console.WriteLine("Interest amount: " + myIndividualMortgageAccount.CalcInterstAmount(14));

        Account myCompanyMortgageAccount = new MortgageAccount(Customers.Company, 1000m, 3.4m);
        Console.WriteLine("Interest amount: " + myCompanyMortgageAccount.CalcInterstAmount(13));

    }
}