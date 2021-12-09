using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExcersizes;
internal class Worker : Human
{
    private double weekSalary;
    private double workHoursPerDay;

    public double WeekSalary { get { return weekSalary; } private set {
            if (value > 10)
                weekSalary = value;
            else
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
        } }
    public double WorkHoursPerDay { get { return workHoursPerDay; } private set {
            if (value < 1 || value > 12)
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            workHoursPerDay = value; 
        } }
    public Worker(string fName, string lName, double weekSalary, double workHoursPerDay) : base(fName, lName)
    {
        WeekSalary = weekSalary;
        WorkHoursPerDay = workHoursPerDay;
    }
    public override string ToString()
    {
        return $"{base.ToString()}Week Salary: {WeekSalary}\nHours per day: {WorkHoursPerDay}\nSalary per hour: {(WeekSalary/(5 * WorkHoursPerDay)).ToString("0.00")}\n";
    }
}

