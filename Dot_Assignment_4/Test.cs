using System;
class Test
{
    public static void Main(string [] args)
{
Console.WriteLine("--------------WellCome---------------");
Console.WriteLine("If you want to calculate Banner Price Press A OR If you want to calculate Curvedbanner Price Press B");
char choice= char.Parse(Console.ReadLine());
switch(choice)
{
case 'A':
Console.WriteLine("Enter Width,Height  and Copies\t");
double a= double.Parse(Console.ReadLine());
double b= double.Parse(Console.ReadLine());
int x= int.Parse(Console.ReadLine());
Banner ban= new Banner(a,b);
Console.WriteLine($"Width={a} & Height={b}");
Console.WriteLine($"Calculating area of Banner\nArea of banner ={ban.Area()}");
Console.WriteLine($"Total price  of Banner={ban.BannerPrice(ban,x)}");
break;
case 'B':
Console.WriteLine("Enter Width,Height,Radius and Copies\n");

double c= double.Parse(Console.ReadLine());
double d= double.Parse(Console.ReadLine());
double r= double.Parse(Console.ReadLine());
int y= int.Parse(Console.ReadLine());
Curved cuv= new Curved(c,d,r);
Console.WriteLine($"Width={c},Height={d},Radius={r}\n");
Console.WriteLine($"Calculating area of CurrvedBanner\nArea of banner ={cuv.Area()}");
Console.WriteLine($"Total price  of CurrvedBanner={cuv.BannerPrice(cuv,y)}");
break;

default:
Console.Write("Invalid Entry");
break;
}
}
}