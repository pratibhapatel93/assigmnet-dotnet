class Program
{
    static void Main(string[] args)
    {
        double p = double.Parse(args[0]);
        Type t = Type.GetType(args[1]);

        dynamic policy = Activator.CreateInstance(t);
         double m = 10;
         double  i = policy.Common(p, m);


        Console.WriteLine("{0}",i);
        // int m = 10;
        // for(int n = 1; n <= m; ++n)
        // {
        //     float i = policy.Common(p, n) / 1200; //duck typing
        //     double emi = p * i / (1 - Math.Pow(1 + i, -12 * n));
        //     Console.WriteLine("{0, -6}{1, 12:0.00}", n, emi);
        // }
    }
}