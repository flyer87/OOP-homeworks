using System;
using System.Collections.Generic;

public enum Customers { Individual, Company }

public abstract class Account : IInterestable, IDepositable
{
    // fields
    private Customers customer;
    private decimal balance;
    private decimal rate;

    // constructors
    protected Account(Customers customer, decimal balance, decimal rate)
    {
        this.Customer = customer;
        this.Balance = balance;
        this.Rate = rate;
    }


    // properties
    public Customers Customer
    {
        get { return customer; }
        private set { customer = value; }
    }

    public decimal Balance
    {
        get { return balance; }
        protected set
        {
            balance = value;
        }
    }

    public decimal Rate
    {
        get { return rate; }
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Interest range should be positive!");
            }
            rate = value;
        }
    }

    // methods 
    public abstract decimal CalcInterstAmount(int month);

    public abstract void Deposit(decimal money);
}
