class Curved : Banner
{
    private double radius;
    public Curved(double w, double h,double r) : base(w, h)
    {
radius =r;
    }
    public double Radius{
        get
        {return radius;}
        set
        {radius=value;}
    }
    public override double Area()
    {
        return base.Area()-(0.86*radius*radius);
    }
     public override double BannerPrice(Banner info,int copies)
        {
          double rate= copies<5?0.80:0.75;
          Console.WriteLine($"Number of copies are={copies} and Rate is={rate}");
          return  rate * copies * info.Area();
            //return price;
        }

}