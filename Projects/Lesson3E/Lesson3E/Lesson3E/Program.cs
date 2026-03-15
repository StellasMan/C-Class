using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3E
{
    class Program
    {
        static int[] intVals = { 1, 2, 3, 4, 5 };
        static double[] dblVals = { 1.0, 2.0, 3.0, 4.0, 5.0 };

        public static void Swap<T>(ref T val1, ref T val2)
        {
            T temp = val1;
            val1 = val2;
            val2 = temp;
        }

        static void Main(string[] args)
        {
            StackX<double> intStack = new StackX<double>(100);
            intStack.Push(100.5);
            intStack.Push(200.5);
            intStack.Push(300.5);
            intStack.Push(400.5);

            double dblValue = intStack.Pop();
            Console.WriteLine($"Popped {dblValue}");

            intStack.Push(500.5);

            dblValue = intStack.Pop();
            Console.WriteLine($"Popped {dblValue}");

            dblValue = intStack.Pop();
            Console.WriteLine($"Popped {dblValue}");

            dblValue = intStack.Pop();
            Console.WriteLine($"Popped {dblValue}");

            dblValue = intStack.Pop();
            Console.WriteLine($"Popped {dblValue}");

            Console.ReadLine();
        }
    }
}
