using System;

class LoanAccount : Account, IDepositable
{
    public LoanAccount(Customers customer, decimal balance, decimal rate)
        : base(customer, balance, rate)
    {
    }

    public override void Deposit(decimal money)
    {
        Balance += money;
    }

    public override decimal CalcInterstAmount(int months)
    {
        if (months <= 0)
        {
            throw new ArgumentOutOfRangeException("Months should be positive!");
        }

        switch (this.Customer)
        {
            case Customers.Individual:
                {
                    if (months <= 3)
                    {
                        return 0m;
                    }
                    else
                    {
                        return this.Rate * (months - 3);
                    }
                }

            case Customers.Company:
                {
                    if (months <= 2)
                    {
                        return 0m;
                    }
                    else
                    {
                        return this.Rate * (months - 2);
                    }
                }
            default:
                throw new ArgumentException("Customer is unknown!");
        }
    }
}