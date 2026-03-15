using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutSample
{
    public struct MINMAXAVG
    {
        public int m_Min;
        public int m_Max;
        public double m_Avg;
    }

    class Program
    {
        static void DumpArray(int[] someArray)
        {
            Console.WriteLine("\n**** Dumping Array ****\n");

            int nCount = 0;
            foreach (int item in someArray)
            {
                Console.WriteLine("Value " + (++nCount) + " of array is " + item);
            }

            Console.WriteLine();
        }

        public static double AvgArray(int[] arrTest, bool bDump = false)
        {
            int nTotal = 0;
            foreach (int nItem in arrTest)
                nTotal += nItem;

            if (bDump)
                DumpArray(arrTest);

            return (nTotal / arrTest.Length);
        }

        public static void SumAndAverage(int[] arrArray, int nMethodSum, double dblMethodAvg)
        {
            nMethodSum = arrArray.Sum();
            dblMethodAvg = arrArray.Average();

            Console.WriteLine("Sum is " + nMethodSum + "; Average is " + dblMethodAvg);
        }

        static void Avg(int[] mmMyArray, double dblAvg)
        {
            double sum = 0;
            foreach (int item in mmMyArray)
                sum += item;

            dblAvg = sum / mmMyArray.Length;
            Console.WriteLine("Average is " + dblAvg);
        }

        static MINMAXAVG GetMinMaxAvg(int[] mmArray)
        {
            MINMAXAVG mmAvg;
            mmAvg.m_Min = int.MaxValue;
            mmAvg.m_Max = int.MinValue;
            mmAvg.m_Avg = 0.0;
            double dTotal = 0.0;

            foreach(int item in mmArray)
            {
                if (item < mmAvg.m_Min)
                    mmAvg.m_Min = item;

                if (item > mmAvg.m_Max)
                    mmAvg.m_Max = item;

                dTotal += item;
            }

            mmAvg.m_Avg = (dTotal / mmArray.Length);

            return mmAvg;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            double dblAvg = 0;
            Avg(myArray, dblAvg);
            Console.WriteLine("Average is " + dblAvg + "\n");

            int nSum = 0;
            dblAvg = 0.0;
            SumAndAverage(myArray, nMethodSum: nSum, dblMethodAvg: dblAvg);
            Console.WriteLine("Sum is " + nSum + "; Average is " + dblAvg);

            Console.ReadKey();
        }
    }
}
