using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    class Program
    {
        static bool CheckForPrime(UInt32 uiValue)
        {
            bool bIsPrime = true;

            // Values 1 & 2 are considered prime
            if (uiValue > 3)
            {
                if ((uiValue & 0x01) == 0)
                {
                    // Rule out any even numbers
                    bIsPrime = false;
                }
                else
                {
                    // Rule out any numbers which are not 1 more or 1 less than a multiple of 6
                    UInt32 uiMod6 = uiValue % 6;
                    bIsPrime = ((uiMod6 == 1) || (uiMod6 == 5));
                }

                if (bIsPrime)
                {
                    // Start from 3 and continue to the square root of 'uiValue', trying
                    // to find an even factor of 'uiValue'. If we can't find one before
                    // we exceed the square root of 'uiValue', then 'uiValue' is prime.
                    int nMaxCheck = (int)Math.Sqrt(uiValue);
                    for (UInt32 uiIx = 3; uiIx <= nMaxCheck; uiIx += 2)
                    {
                        if ((uiValue % uiIx) == 0)
                        {
                            // Console.WriteLine($"{uiIx} is a factor of {uiValue}");
                            bIsPrime = false;
                            break;
                        }
                    }
                }
            }

            return bIsPrime;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                UInt32 uiValue = 0;
                Console.Write("Input prime candidate,Q to quit >> ");
                string sInput = Console.ReadLine();
                if (sInput.Length == 0)
                {
                    Console.WriteLine("Invalid input - try again");
                }
                else if ((sInput.Length == 1) && (sInput.ToUpper() == "Q"))
                {
                    Console.Write("Thanks for playing - goodbye for now");
                    System.Threading.Thread.Sleep(2000);
                    break;
                }
                else if ((!UInt32.TryParse(sInput, out uiValue)) || (uiValue > 1000000))
                {
                    Console.WriteLine("Invalid input - try again");
                }
                else
                {
                    if (CheckForPrime(uiValue))
                    {
                        Console.WriteLine($"{sInput} is a prime number");
                    }
                    else
                    {
                        Console.WriteLine($"{sInput} is a not prime number");
                    }
                }
            }
        }
    }
}
