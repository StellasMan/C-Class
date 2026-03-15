using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // checked
            {
                Int32 nMax = Int32.MaxValue;
                short nShort = (short)nMax;
            }

            checked
            {
                double dblMax = double.MaxValue;
                float flTest = (float)dblMax;

                if (float.IsInfinity(flTest))
                    Console.WriteLine($"Float Overflow! {flTest}");

                double dblValue = 10.0;
                double dblResult = dblValue / 0.0;

                // Check result using IsInfinity() Method
                if (Double.IsInfinity(dblResult))
                    Console.WriteLine($"Double Overflow {dblResult}");
            }

            Person perDuterte = new Person("Rodrigo", "Duterte", DateTime.Parse("24 March 1944"));
            Employee empDuterte = perDuterte as Employee;

            if (perDuterte is Employee)
            {
                Console.WriteLine("We will never get here!");
            }

            Employee[] empArray = new Employee[10];
            DateTime dtBirth = new DateTime(1944, 3, 24);
            DateTime dtStart = new DateTime(2000, 1, 1);
            for (int nIx=0; nIx<10; nIx++)
            {

                empArray[nIx] = new Employee("Rodrigo", "Duterte" + (nIx + 1), dtBirth, dtStart);
                dtBirth += TimeSpan.FromDays(365);
                dtStart += TimeSpan.FromDays(365);

                Console.WriteLine($"Employee {nIx + 1} Info: {empArray[nIx].Info}");
            }

            TimeSpan tsTest = TimeSpan.Parse("9.10:11:12.1345");    // 9 days, 10 hours, 11 minutes, 12.1345 seconds
            Console.WriteLine(tsTest.ToString());

            Person[] arrPerson = empArray as Person[];

            // arrPerson[0] = new Person("Arnold", "Schwartzenegger", DateTime.Parse("15 Oct 1953"));

            double dblCurrency = double.Parse("$123,456.78-", 
                NumberStyles.AllowCurrencySymbol |
                NumberStyles.AllowThousands | 
                NumberStyles.AllowDecimalPoint | 
                NumberStyles.AllowLeadingSign |
                NumberStyles.AllowTrailingSign);

            Console.WriteLine($"{dblCurrency}");

            byte[] byNumbers = { 0, 1, 2, 33, 34, 35, 36, 37, 38, 39 };
            string szNumbers = System.Convert.ToBase64String(byNumbers);

            int nValue = System.Convert.ToInt32("100");
            nValue = System.Convert.ToInt32(100.123);

            byte[] byA = System.BitConverter.GetBytes('A');

            int nAVal = System.BitConverter.ToChar(byA, 0);

            System.Int32? n32 = null;
            Console.WriteLine($"n32 Value is {n32}");

            Console.ReadLine();
        }
    }
}
