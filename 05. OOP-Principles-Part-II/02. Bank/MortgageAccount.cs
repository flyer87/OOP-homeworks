using System;

class MortgageAccount : Account
{
    public MortgageAccount(Customers customer, decimal balance, decimal rate)
        : base(customer, balance, rate)
    {
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
                    if (months <= 6)
                    {
                        return 0m;
                    }
                    else
                    {
                        return Rate * (months - 6);
                    }
                }

            case Customers.Company:
                {
                    if (months <= 12)
                    {
                        return Rate * months / 2;
                    }
                    else
                    {
                        return Rate * months;
                    }
                }
            default:
                throw new ArgumentException("Customer is unknown!");
        }
    }

    public override void Deposit(decimal money)
    {
        if (money <= 0)
        {
            throw new ArgumentOutOfRangeException("Money for deposit should be possitive number!");
        }
        Balance += money;
    }
}
