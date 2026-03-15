using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNov112021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double dblValue = 98.6;
            Console.WriteLine("The value of 'dblValue' is " + dblValue);

            int nVal = (int)dblValue;
            Console.WriteLine("The value of 'nVal' is " + nVal);
            Console.WriteLine("The value of 'dblValue' is " + dblValue);

            dblValue = nVal;
            Console.WriteLine("The value of 'dblValue' is " + dblValue);

            if ((nVal > 50) || (nVal < 100))
                Console.WriteLine("Expression is TRUE!");
            else
                Console.WriteLine("Expression is FALSE!");

            Console.ReadKey();
        }
    }
}
