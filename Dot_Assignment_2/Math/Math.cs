namespace Math;
using System;

class Math
{

         public static bool isEven(int a)//1
         {

                  if (a % 2 == 0)
                  {
                           return true;
                  }

                  return false;
         }
         /////////////////////////////////////
         public static bool isOdd(int b)//2
         {
                  if (b % 2 != 0)
                  {
                           return true;
                  }
                  else
                  {
                           return false;
                  }

         }
         //////////////////////////////////////
         public static bool isPrime(int c)
         {
                  bool flag = true;
                  if (c == 0 || c == 1)
                  {
                           return flag = false;
                  }
                  if (c == 2 || c == 3)
                  {
                           return flag = true;
                  }
                  for (int i = 3; i * i <= c; i++)
                  {
                           if (i % c == 0)
                           {
                                    if (i % c == 0)
                                    {
                                             return flag = false;
                                    }
                                    else
                                    {
                                             return flag = true;
                                    }


                           }
                           return flag;
                  }
                  ////////////////////////////////////////////

                  public static int countDigit(int d) //3
                  {

                           int count = 0;
                           while (d != 0)
                           {
                                    d = d / 10;
                                    count++;
                           }
                           return count;
                  }

                  ////////////////////////////////////////////////////////
                  public static int iscountPrimes(int x)
                  {

                           int count = 0;

                           for (int i = 1; i < x; i++)
                           {
                                    bool isPrime = true;
                                    for (int j = 2; j < i; j++)
                                    {

                                             if (i % j == 0)
                                             {
                                                      isPrime = false;
                                                      break;
                                                      break;
                                             }
                                    }
                                    if (isPrime)
                                    {
                                             Console.WriteLine(i);
                                             count++;


                                    }
                           }

                           Console.WriteLine("Counts are");
                           return count;
                  }

                  //////////////////////////////////////////////////
                  static int reverse(int number) //4
                  {
                           int revers = 0;

                           while (number > 0)
                           {
                                    int remaining = number % 10;
                                    revers = 10 * revers + remaining;
                                    number = number / 10;
                           }
                           return revers;
                  }

         
                 
         }
}




























