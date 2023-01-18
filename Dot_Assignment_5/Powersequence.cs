namespace Sequence;
public class PowerSequence : Sequence, IResetable
{
         private double current;
         private double factor;
         public PowerSequence()
         {
                  current = 1;
                  factor = 5;
         }
         public override double next()
         {
                  double term = current;
                  current *= factor;
                  return term;
         }
         public void reset()
         {
                  current = 1;
         }

}