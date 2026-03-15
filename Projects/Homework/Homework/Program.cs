using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void MinMaxAvg(int[] arrArray, ref int nMin, ref int nMax, ref double dblAvg)
        {
            int nTotal = 0;
            nMax = int.MinValue;
            nMin = int.MaxValue;

            foreach(int nItem in arrArray)
            {
                nTotal += nItem;
                if (nItem < nMin)
                    nMin = nItem;

                if (nItem > nMax)
                    nMax = nItem;
            }

            dblAvg = ((double)nTotal / arrArray.Count());
        }

        static double StandardDev(int[] someArray)
        {
            double dblAverage = Average(someArray);

            double dblTotal = 0;
            foreach(int nItem in someArray)
            {
                double dblDiff = (nItem - dblAverage);
                double dblSquare = dblDiff * dblDiff;
                dblTotal += dblSquare;
            }

            double stdDev = Math.Sqrt(dblTotal / someArray.Count());

            return stdDev;
        }

        static double Average(int[] someArray)
        {
            int nTotal = 0;
            foreach(int nItem in someArray)
            {
                nTotal += nItem;
            }

            double dblAverage = ((double)nTotal / someArray.Count());

            return dblAverage;
        }

        static int EvenCount(int[] myArray)
        {
            int nCount = 0;

            foreach(int nItem in myArray)
            {
                if ((nItem % 2) == 0)
                    nCount++;
            }

            return nCount;
        }

        static void Main(string[] args)
        {
            int[] myArray = new int[500];
            System.Random rand = new Random(1);
            for (int nIx = 0; nIx < 500; nIx++)
            {
                myArray[nIx] = rand.Next(1, 1000);
                Console.WriteLine("Array index " + nIx + " is " + myArray[nIx]);
            }

            StandardDev(myArray);

            int nMin = 0;
            int nMax = 0;
            double dblAvg = 0.0;
            MinMaxAvg(myArray, ref nMin, ref nMax, ref dblAvg);

            int nEvenCount = EvenCount(myArray);

            Console.ReadLine();
        }
    }
}
