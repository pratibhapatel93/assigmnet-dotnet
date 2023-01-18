using System;
class Employee
{
    private int id;
    private int age;
    private int hours;
    private double rate;

    public Employee(int i, int a, int h, double r)
    {
        id = i;
        age = a;
        hours = h;
        rate = r;
    }
    public double GetIncome()
    {
        return hours * rate + GetOvertime();
    }
    public double getnet()
    {
        return hours * rate;
    }
    public double GetOvertime()
    {
        double extratime = 2;
        return extratime * 100;
    }
    public String PrintEmployee()
    {
        return "Good Manner";
    }
}