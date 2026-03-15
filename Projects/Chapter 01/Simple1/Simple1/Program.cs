using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple1
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

            public double Average()
            {
                return (m_xValue + m_yValue) / 2;
            }

            public double m_xValue;
            public double m_yValue;
        }

        static void DumpArray(int[] someArray)
        {
            Console.WriteLine();

            int nCount = 0;
            foreach (int item in someArray)
            {
                Console.WriteLine("Value " + (++nCount) + " of array is " + item);
            }
        }

        static double CalcAvg(Coords avgCoords)
        {
            double avgValue = (avgCoords.m_xValue + avgCoords.m_yValue) / 2;
            return avgValue;
        }

        static void ShowCoords(Coords cLocalTest, double Average)
        {
            Console.WriteLine("XValue is " + cLocalTest.m_xValue);
            Console.WriteLine("YValue is " + cLocalTest.m_yValue);

            Average = CalcAvg(cLocalTest);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            int[] myArray1 = { 10, 20, 30, 40, 50 };

            int[] myArray2 = myArray1;
            Console.WriteLine("\nDumping 'myArray1'");
            DumpArray(myArray1);

            Console.WriteLine("\nDumping 'myArray2'");
            DumpArray(myArray2);

            Console.WriteLine("\n********** Modifying 'myArray1' **********");

            myArray1[0] = 500;
            Console.WriteLine("\nDumping 'myArray1'");
            DumpArray(myArray1);

            Console.WriteLine("\nDumping 'myArray2'");
            DumpArray(myArray2);
            Console.ReadKey();
        }
    }
}
