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

        static void Main(string[] args)
        {
            PersonComparerDesc perComparator = new PersonComparerDesc();
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

            Console.ReadLine();
        }
    }
}
