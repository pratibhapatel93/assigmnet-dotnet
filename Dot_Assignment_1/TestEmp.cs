using System;
class main
{
        public static void Main(string[] args)
        {
      
         Console.WriteLine("Enter id,age,hours,rate");
        int id=int.Parse(Console.ReadLine());
        int age=int.Parse(Console.ReadLine());
        int hours=int.Parse(Console.ReadLine());
        double rate=double.Parse(Console.ReadLine());
        Employee e =new Employee(id,age,hours,rate);

        e.GetOvertime();
        Console.WriteLine($"Net Income:={e.getnet()}");
        Console.WriteLine($"Total Income with overtime{e.GetIncome()}");
        Console.WriteLine($"{e.PrintEmployee()}");
        }

}
