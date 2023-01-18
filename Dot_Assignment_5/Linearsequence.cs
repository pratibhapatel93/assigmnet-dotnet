namespace Sequence;
class LinearSequence:Sequence
{
 public LinearSequence()
{
current =5;
steps=3;
}
private double current;
private double steps;
public override double next()
{
double term=current;
current+=steps;
return term;
}

}