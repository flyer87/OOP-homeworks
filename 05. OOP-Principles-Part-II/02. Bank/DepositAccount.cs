using System;

class DepositAccount : Account, IWithdrawable
{
    public DepositAccount(Customers customer, decimal balance, decimal rate)
        : base(customer, balance, rate)
    {
    }

    public override decimal CalcInterstAmount(int months)
    {
        if (months <= 0)
        {
            throw new ArgumentOutOfRangeException("Months should be positive!");
        }

        if (Balance < 1000)
        {
            return 0;
        }
        else
        {
            return Rate * months;
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

    public void Withdraw(decimal money)
    {
        if (money <= 0)
        {
            throw new ArgumentOutOfRangeException("Money for withdraw should be possitive number!");
        }
        Balance -= money;
    }
}