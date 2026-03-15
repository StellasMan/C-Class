using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsOne
{
    class Program
    {
        public static void SumAndAverage(int[] arrArray, out int nSum, out double dblAvg)
        {
            nSum = arrArray.Sum();
            dblAvg = arrArray.Average();

        }

        public static void SomeMethod(int[] arrArray, bool bShowAvg = false)
        {
            double Avg = arrArray.Average();
            if (bShowAvg)
                Console.WriteLine("Average is " + Avg);
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };

            int nLocalSum = 0;
            double dblLocalAvg = 0.0;
            SumAndAverage(myArray, out nLocalSum, out dblLocalAvg);

            string sLine = Console.ReadLine();
            Console.WriteLine("You typed '" + sLine + "'");

            int nInput = int.Parse(sLine);

            Console.WriteLine("Sum is " + nLocalSum + "; Average is " + dblLocalAvg + ";");

            //SomeMethod(myArray, true);

            Human person = new Human("Henry");
            person.Talk();

            Animal animal = person;
            animal.Talk();
            animal.MakeNoise();

            Console.ReadKey();
        }
    }
}
