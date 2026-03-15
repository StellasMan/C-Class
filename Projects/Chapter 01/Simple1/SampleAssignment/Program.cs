using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAssignment
{
    public struct AvgMinMax
    {
        public double AvgValue;
        public int MinValue;
        public int MaxValue;
    }

    class Program
    {
        static AvgMinMax ArrAvgMinMax(int[] arrValues)
        {
            int nSum = 0;
            int MinValue = int.MaxValue;
            int MaxValue = int.MinValue;

            AvgMinMax avgMinMaxValues = new AvgMinMax();

            foreach (int nItem in arrValues)
            {
                nSum += nItem;

                if (nItem < MinValue)
                    MinValue = nItem;

                if (nItem > MaxValue)
                    MaxValue = nItem;
            }

            double Avg = ((double)nSum / arrValues.Length);

            avgMinMaxValues.AvgValue = Avg;
            avgMinMaxValues.MinValue = MinValue;
            avgMinMaxValues.MaxValue = MaxValue;

            return avgMinMaxValues;
        }

        static double ArrAverage(int[] arrValues)
        {
            int nSum = 0;
            foreach (int nItem in arrValues)
                nSum += nItem;
            double Avg = ((double)nSum / arrValues.Length);
            return Avg;
        }

        static int ArrMin(int[] arrValues)
        {
            int MinValue = int.MaxValue;
            foreach (int nItem in arrValues)
            {
                if (nItem < MinValue)
                    MinValue = nItem;
            }

            return MinValue;
        }

        static int ArrMax(int[] arrValues)
        {
            int MaxValue = int.MinValue;
            foreach (int nItem in arrValues)
            {
                if (nItem > MaxValue)
                    MaxValue = nItem;
            }

            return MaxValue;
        }


        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 5, 7, 15, -1, -5, 17, 3, 9, 12 };
            double Average = ArrAverage(intArray);
            int MinValue = ArrMin(intArray);
            int MaxValue = ArrMax(intArray);

            Console.WriteLine("Average of array is " + Average);
            Console.WriteLine("Minimum value of array is " + MinValue);
            Console.WriteLine("Maximum value of array is " + MaxValue);

            Console.WriteLine();
            AvgMinMax avgMinMax = ArrAvgMinMax(intArray);
            Console.WriteLine("Average of array is " + avgMinMax.AvgValue);
            Console.WriteLine("Minimum value of array is " + avgMinMax.MinValue);
            Console.WriteLine("Maximum value of array is " + avgMinMax.MaxValue);

            Console.ReadKey();
        }
    }
}
