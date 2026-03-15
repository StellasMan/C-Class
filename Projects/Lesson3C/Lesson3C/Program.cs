using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3C
{
    class Program
    {
        static void Process(int nValue)
        {
            string sSelect = (nValue > 75) ? "nValue > 75 and <= 100" :
                            (nValue > 50) ? "nValue > 50 and <= 75" :
                            (nValue > 25) ? "nValue > 25 and <= 50" :
                                            "nValue >= 1 and <= 25";

            Console.WriteLine(sSelect);
        }

        static void Main(string[] args)
        {
            Animal myAnimal = new Mammal();
            myAnimal.Talk();
            myAnimal.Talk("Howdy Folks!");

            int nTest = 2;
            int nSquared = nTest.Square();

            Console.ReadLine();

            //while (true)
            //{
            //    int nValue = 0;
            //    Console.Write("Enter value between 1 and 100, 'Q' to quit >> ");
            //    string sValue = Console.ReadLine();
            //    if (sValue.Length > 0)
            //    {
            //        if (int.TryParse(sValue, out nValue))
            //        {
            //            if ((nValue >= 1) && (nValue <= 100))
            //            {
            //                Process(nValue);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Error: '" + sValue + "' is not between 1 and 100.");
            //            }
            //        }
            //        else if (sValue.ToUpper()[0] == 'Q')
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error: '" + sValue + "' is not a valid integer.");
            //        }
            //    }
            //}
        }
    }
}
