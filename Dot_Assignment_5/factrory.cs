namespace Sequence;
public abstract class factory
{
public static Sequence linearSequence()
{
var seql=new LinearSequence();
return seql;
}

public static  Sequence powerSequence()
{
var seqp=new PowerSequence();
return seqp;
}
private factory(){}
}