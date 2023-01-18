using System.Threading;
namespace ThreadClass
{

         class Program
         {
                  public void EvenOdd()
                  {
                           for (int i = 1; i <= 10; i++)
                           {
                                    if (i % 2 == 0)
                                    {
                                             Console.WriteLine($"Even no {i}");
                                             Thread.Sleep(1000);
                                    }
                                    else
                                    {
                                             Console.WriteLine($"Odd no {i}");
                                             Thread.Sleep(1000);
                                    }
                           }
                  }


                  public static void Main(string[] args)
                  {
                           Program obj = new Program();
                           Thread t1 = new Thread(obj.EvenOdd);
                           t1.Start();
                           Console.WriteLine($"Even Odd Execution begins After Main Thread \n---------");
                           Console.WriteLine($"------------\n");

                  }

         }
}