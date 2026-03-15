using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    class Program
    {
        public struct Coords
        {
            public Coords(double xValue, double yValue)
            {
                m_xValue = xValue;
                m_yValue = yValue;
            }

            public double m_xValue;
            public double m_yValue;
        }

        static void TestOut(out int nValue)
        {
            // int SomeValue = nValue;
            nValue = 5;
        }

        static void ModArray(int[] arrayTest)
        {
            arrayTest[0] = 1000;
        }

        static double CalcAvg(Coords avgCoords)
        {
            double avgValue = (avgCoords.m_xValue + avgCoords.m_yValue) / 2;
            return avgValue;
        }

        static void ShowCoords(Coords cLocalTest)
        {
            Console.WriteLine("XValue is " + cLocalTest.m_xValue);
            Console.WriteLine("YValue is " + cLocalTest.m_yValue);

            double Average = CalcAvg(cLocalTest);
            Console.WriteLine("Average value is " + Average);
        }

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

        static double AvgArray(int[] arrTest, bool bDump=false)
        {
            int nTotal = 0;
            foreach (int nItem in arrTest)
                nTotal += nItem;

            if (bDump)
                DumpArray(arrTest);

            return (nTotal / arrTest.Length);
        }

        static int rectArea(int length, int width)
        {
            return length * width;
        }

        static int cubeVolume(int depth, int length, int width)
        {
            return length * width * depth;
        }

        static void Main(string[] args)
        {
            int area = rectArea(width: 50, length: 25);
            Console.WriteLine("Area of rectangle is " + area + " units");

            int volume = cubeVolume(15, width: 50, length: 25);
            Console.WriteLine("Volume  of cube is " + volume + " units");

            Console.ReadKey();
        }

        //static void Main(string[] args)
        //{
        //    int[] arrSample = { 1, 2, 3, 4, 5 };
        //    double dblAvg = AvgArray(arrSample, true);
        //    Console.WriteLine("Array average is " + dblAvg);

        //    Console.ReadKey();
        //}

        //static void Main(string[] args)
        //{
        //    //Coords coords = new Coords(3.5, 7.0);

        //    //ShowCoords(coords);

        //    int[] arrSample = { 1, 2, 3, 4, 5 };
        //    double dblAvg = AvgArray(arrSample, true);
        //    Console.WriteLine("Array average is " + dblAvg);

        //ModArray(arrSample);
        //DumpArray(arrSample);

        //int nTest;
        //TestOut(out nTest);

        //    Console.ReadKey();
        //}
    }
}
