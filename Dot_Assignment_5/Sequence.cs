namespace Sequence;

using System;

public abstract class Sequence
{
private double total=0;
public abstract double next();

public  double sum(int count)
{
for (int i=1;i<=count;i++)
{
total+=next();
}
return total;
}
}
