namespace Math;
using System;
class Program
{
 public static void Main(string [] arg)
                  {
                           Console.WriteLine("Enter no to print Following opration");

                           Console.WriteLine("1.Even 2.odd 3.Primeno 4.upto n number of prime 5.count digit 6.reverse\n");

                           int n = Console.Read();
                           switch (n)
                           {
                                    case 3:
                                             Console.WriteLine("Enter no to find prime or not");
                                             int z = Console.Read();
                                             Console.WriteLine(Math.iscountPrimes(z));
                                             break;

                                    case 4:
                                             Console.WriteLine("Enter no to count from 1 to n");
                                             int a = Console.Read();
                                             Console.WriteLine(iscountPrimes(a));
                                             break;

                                    case 1:
                                             Console.WriteLine("Enter no to find even or not");
                                             int b = Console.Read();
                                             Console.WriteLine(isEven(b));
                                             break;

                                    case 2:
                                             Console.WriteLine("Enter no to find odd or not");
                                             int c = Console.Read();
                                             Console.WriteLine(isOdd(c));
                                             break;

                                    case 5:
                                             Console.WriteLine("Enter any number upto 4 digit or more ");
                                             int d = Console.Read();
                                             Console.WriteLine(countDigit(d));
                                             break;

                                    case 6:
                                             Console.WriteLine("Enter no to reverse");
                                             int e = Console.Read();
                                             Console.WriteLine(reverse(e));
                                             break;
                           }
                  }


}
