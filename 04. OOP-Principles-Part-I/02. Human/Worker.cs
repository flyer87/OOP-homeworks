using System;
using System.Collections.Generic;

class Worker : Human
{    
    private decimal weekSalary;
    private decimal workHoursPerDay;
    private const int workDays = 5;

    // -= Constructors =-
    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
        :base(firstName,lastName)
    {
        this.weekSalary = weekSalary;
        this.workHoursPerDay = workHoursPerDay;
    }


    //   -= properties =-
    public decimal WorkHoursPerDay
    {
        get { return workHoursPerDay; }
        set { workHoursPerDay = value; }
    }

    public decimal WeekSalary
    {
        get { return weekSalary; }
        set { weekSalary = value; }
    }

    // -= methods =- 
    public decimal MoneyPerHour()
    {
        return weekSalary / (workDays * workHoursPerDay);
    }


}
