namespace BasicWebApp.Services;

public class SimpleInterest : IInterest
{
          public double Interest(double principle,int period,float rate)
         {
                  return ( principle * period * rate) / 100;

         
         }
}

