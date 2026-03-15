using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains3
{
    class Program
    {
        static int DigitCount(int nTestValue, int nDigit)
        {
            int nDigitCount = 0;
            while (nTestValue > 0)
            {
                if ((nTestValue % 10) == nDigit)
                    nDigitCount++;

                nTestValue /= 10;
            }

            return nDigitCount;
        }

        static bool Contains3(int nTestValue)
        {
            bool bContains3 = false;
            while (!bContains3 && (nTestValue > 0))
            {
                if ((nTestValue % 10) == 3)
                    bContains3 = true;

                nTestValue /= 10;
            }

            return bContains3;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input positive number, 'Q' to quit >> ");
                string sInput = Console.ReadLine();

                if (sInput.Length > 0)
                {
                    if (sInput.ToUpper()[0] == 'Q')
                        break;

                    int nValue = 0;
                    if (int.TryParse(sInput, out nValue))
                    {
                        if (nValue < 0)
                        {
                            Console.WriteLine("Must be a positive number - try again");
                        }
                        else
                        {
                            Console.Write("Input digit to search for >> ");
                            string sDigit = Console.ReadLine();

                            int nDigit = 0;
                            if (int.TryParse(sDigit, out nDigit) && (nDigit >= 0) && (nDigit < 10))
                            {
                                int nCount = DigitCount(nValue, nDigit);
                                Console.WriteLine(String.Format("Value '{0}' has {1} occurrences of digit {2}", nValue, nCount, nDigit));
                            }
                            else
                            {
                                Console.WriteLine("Must be a positive number between 0 and 9 - try again");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(String.Format("Unable to convert value '{0}' to integer", sInput));
                    }
                }
            }
        }
    }
}
