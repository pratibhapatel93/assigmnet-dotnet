namespace Sequence;
using System;
class Program
   {
public static double Compute(Sequence Seq,int count)
{
if(Seq is IResetable p)
        p.reset();
return Seq.sum(count)/count;
}

public static void Main(string [] args)
{
Sequence s=factory.linearSequence();
Sequence q=factory.powerSequence();
Console.WriteLine($"The Sum of linear Sequence is {Compute(s,12)}");
Console.WriteLine($"The Sum of Power Sequence is  {Compute(q,3)}");
}

}
