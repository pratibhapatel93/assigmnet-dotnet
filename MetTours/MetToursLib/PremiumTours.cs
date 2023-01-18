using System;
namespace MetTours;

public class PremiumTours
{
    [LuxuryTax(tax=10)]
    public double Common(double days, double noPersons) => 
    ((1200 * days * noPersons)+((1200 * days * noPersons)*(0.10)));


    public double Seniors(double days, double noPersons)
    {
        double cal=(1200 * days * noPersons);
        double r;
        if (days > 6)
        {
            r = ((cal - (100 * days) - (100 * days * noPersons)));
            r+=(r*0.10);
        }
        else
        {
            r = (((cal - (100 * days)))+((cal - (100 * days))));//(100*days*noPersons))
            r+=(r*0.10);
        }
        return r;
    }



    [LuxuryTax(tax=10)]
    public double Woman(double days, double noPersons)
    {
        double r;
        if (days > 4)
        {
            r = (((1200 * days * noPersons) - (200 * days) - (100 * days * noPersons)));
            r+=(r*0.10);
        }
        else
        {
            r = (((1200 * days * noPersons) - (200 * days)));//(100*days*noPersons))
            r+=(r*0.10);
            
        }
        return r;
    }


}