using System;
namespace MetTours;

[AttributeUsage(AttributeTargets.Method)]
public class LuxuryTax : Attribute
{
    public double tax { get; set; }

    public LuxuryTax(double value = 8)
    {
        tax = value;
    }
}