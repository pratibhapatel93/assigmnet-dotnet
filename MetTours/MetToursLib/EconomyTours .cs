using System;
namespace MetTours;


public class EconomyTours

{ 
    [LuxuryTax(tax=0.08)]
    public double getDaysRent(int days , int noPersons)
    {
        double total=0;
        
         total=(500*noPersons*days);
         return total+=total * (.08);
     } 
}