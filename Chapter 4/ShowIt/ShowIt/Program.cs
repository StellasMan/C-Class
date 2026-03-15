using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowIt
{
    class Program
    {
        static void ShowIt(Person perObject)
        {
            Employee empObject = perObject as Employee;
            if (empObject != null)
            {
                Console.WriteLine($"Employee: Name: {empObject.Name}; Age: {empObject.Age}; Employee ID {empObject.EmployeeID}; Months Employed: {empObject.MonthsEmployed}");
            }
            else if (perObject is Person)
            {
                Console.WriteLine($"Person: Name: {perObject.Name}; Age: {perObject.Age}; Gender: {perObject.Gender}");
            }
        }

        static void Test(Object item)
        {
            Console.WriteLine($"{item}");
            int nItem = (int)item;
        }

        static void Main(string[] args)
        {
            Random rand = new Random(1);
            SortedSet<int> ssInts = new SortedSet<int>();
            for (int nIx = 0; nIx < 20; nIx++)
            {
                int nRand = rand.Next(1, 500);
                Console.WriteLine($"Adding {nRand}");
                ssInts.Add(nRand);
            }

            Console.WriteLine("\n***************** Outputting Sorted Integers *****************");
            int nItem = 1;
            foreach (int nVal in ssInts)
            {
                Console.WriteLine($"Item {nItem++} is {nVal}");
            }

            PersonComparer perComparator = new PersonComparer();
            SortedSet<Person> perSet = new SortedSet<Person>(perComparator);

            perSet.Add(new Person("Rodrigo", "Duterte", GENDER.MALE, DateTime.Parse("March 28, 1945")));
            perSet.Add(new Person("Manny", "Pacquiao", GENDER.MALE, DateTime.Parse("December 17, 1978")));
            perSet.Add(new Person("Lea", "Salonga", GENDER.FEMALE, DateTime.Parse("February 22, 1971")));
            perSet.Add(new Person("George", "Washington", GENDER.MALE, null));
            perSet.Add(new Person("Kim", "Dawson", GENDER.MALE, DateTime.Parse("March 15, 1971")));
            perSet.Add(new Person("Kim", "Dawson", GENDER.FEMALE, DateTime.Parse("April 12, 1975")));
            perSet.Add(new Person("George", "Washington", GENDER.MALE, null));
            perSet.Add(new Employee("Catriona", "Gray", GENDER.FEMALE, DateTime.Parse("January 6, 1994"), DateTime.Parse("Dec 31, 2021"), 1000));

            Console.WriteLine("\n***************** Outputting Sorted Persons *****************");
            foreach (Person perItem in perSet)
            {
                ShowIt(perItem);
            }

            SortedList<Person, int> sList = new SortedList<Person, int>(perComparator);

            int perID = 1000;
            foreach(Person perItem in perSet)
            {
                sList.Add(perItem, perID++);
            }

            Console.WriteLine("\n***************** Outputting Sorted List of Persons *****************");
            foreach (KeyValuePair<Person, int> kvPair in sList)
            {
                Console.WriteLine($"Name: {kvPair.Key.Name}, Gender: {kvPair.Key.Gender}, ID: {kvPair.Value}");
            }

            //double dblValue;
            //bool bTesting = double.TryParse("3.1415926", out dblValue);
            //bTesting = double.TryParse("31,415,926.53", out dblValue);
            //bTesting = double.TryParse("-31,415,926.53", out dblValue);

            double dblValue = double.Parse("3,141,592.63",
                            NumberStyles.AllowThousands |
                            NumberStyles.AllowDecimalPoint);

            bool bTesting = double.TryParse("$31,415,926.53-",
                            NumberStyles.AllowCurrencySymbol |
                            NumberStyles.AllowThousands |
                            NumberStyles.AllowDecimalPoint |
                            NumberStyles.AllowLeadingSign |
                            NumberStyles.AllowTrailingSign,
                            null,
                            out dblValue);

            
            Test(2);
            // Test(3.45);

            Console.ReadLine();
        }
    }
}
