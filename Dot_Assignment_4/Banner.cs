using System;


public class Banner
{
    
    private double width;
    private double height;
       public Banner(double w,double h)
        {
        width=w;
        height=h;
        }

        public double Width 
        {
            get { return width; }
            set { width = value; }
        }

        
        public double Height 
        {
            get { return height; }
            set { height = value; }
        }

        public virtual double Area()
        {
         return width * height;     
        }

        public virtual double BannerPrice(Banner info,int copies)
        {
          double rate= copies<5?0.80:0.75;
          Console.WriteLine($"Number of copies are={copies} and Rate is={rate}");
        return  rate * copies * info.Area();
            //return price;
        }

}