using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByRef
{
    class Program
    {
        static void DumpArray(int[] someArray)
        {
            Console.WriteLine();

            int nCount = 0;
            foreach (int item in someArray)
            {
                Console.WriteLine("Value " + (++nCount) + " of array is " + item);
            }
        }

        static void ModArray(int[] someArray)
        {
            Console.WriteLine();

            int nCount = 0;
            for (int nIx = 0; nIx < someArray.Length; nIx++)
            {
                someArray[nIx] *= 2;
                Console.WriteLine("Value " + (++nCount) + " of array is " + someArray[nIx]);
            }
        }

        static void Main(string[] args)
        {
            int[] myArray1 = { 10, 20, 30, 40, 50 };

            Console.WriteLine("\n********** Calling method 'ModArray' **********");
            ModArray(myArray1);

            Console.ReadKey();
        }

        //static void Main(string[] args)
        //{
        //    int[] myArray1 = { 10, 20, 30, 40, 50 };

        //    int[] myArray2 = myArray1;
        //    Console.WriteLine("\nDumping 'myArray1'");
        //    DumpArray(myArray1);

        //    Console.WriteLine("\nDumping 'myArray2'");
        //    DumpArray(myArray2);

        //    Console.WriteLine("\n********** Modifying 'myArray1' **********");

        //    myArray1[0] = 500;
        //    Console.WriteLine("\nDumping 'myArray1'");
        //    DumpArray(myArray1);

        //    Console.WriteLine("\nDumping 'myArray2'");
        //    DumpArray(myArray2);

        //    Console.WriteLine("\n********** Calling method 'ModArray' **********");
        //    ModArray(myArray1);

        //    Console.WriteLine("\nDumping 'myArray1'");
        //    DumpArray(myArray1);

        //    Console.ReadKey();
        //}
    }
}
