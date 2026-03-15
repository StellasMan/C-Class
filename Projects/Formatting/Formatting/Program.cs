using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            double dblValue = 31415926.53589;
            for (int nIx=1; nIx<100; nIx++)
            {
                Console.Write(nIx % 10);
            }
            Console.WriteLine();

            CultureInfo daDK = CultureInfo.CreateSpecificCulture("da-DK");
            CultureInfo frFR = CultureInfo.CreateSpecificCulture("fr-FR");
            Console.WriteLine($"{dblValue,25:$000,000.00}");
            Console.WriteLine(String.Format("{0:C}", dblValue, daDK));
            Console.WriteLine(String.Format("{0:F}", dblValue, frFR));
            Console.WriteLine($"{dblValue,25:$000,000.00}", daDK);
            //Console.WriteLine($"{dblValue,25:$000,000.00}");
            //Console.WriteLine($"{dblValue,25:$000,000.00}");
            //Console.WriteLine($"{dblValue,25:$000,000.00}");
            Console.WriteLine(String.Format(daDK, "{0,25:$000,000.00}", dblValue));
            Console.WriteLine($"{dblValue,25:$000,000.00}", frFR);

            for (int nIx=0; nIx<10; nIx++)
            {
                Console.WriteLine($"{nIx:D2}");
            }

            string sDate = Console.ReadLine();
            DateTime dtDate;
            if (DateTime.TryParse(sDate, out dtDate))
            {
                DateTime dtWeekFromNow = dtDate + new TimeSpan(7, 0, 0, 0);
                String sWeekFromNow = $"{dtWeekFromNow.Month:D2}/{dtWeekFromNow.Day:D2}/{dtWeekFromNow.Year:D4}";
                Console.WriteLine($"{sWeekFromNow,25}");
            }
            Console.ReadLine();
        }
    }
}
