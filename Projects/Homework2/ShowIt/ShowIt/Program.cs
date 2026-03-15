using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowIt
{
    class Program
    {
        static void ShowIt(Person perObject)
        {
            Console.WriteLine("==============================================================");
            if (perObject is Employee)
            {
                // Employee empObject = (Employee)perObject;    // This will work as well
                Employee empObject = perObject as Employee;
                Console.WriteLine($"Employee: Name: {empObject.Name}; Age: {empObject.Age}; Employee ID {empObject.EmployeeID}; Months Employed: {empObject.MonthsEmployed}");
            }
            else if (perObject is Person)
            {
                Console.WriteLine($"Person: Name: {perObject.Name}; Age: {perObject.Age}");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Person perDuterte = new Person("Rodrigo", "Duterte", DateTime.Parse("March 28, 1945"));
            Person perManny = new Person("Manny", "Pacquiao", DateTime.Parse("December 17, 1978"));
            Person perLea = new Person("Lea", "Salonga", DateTime.Parse("February 22, 1971"));

            Employee empCatriona = new Employee("Catriona", "Gray", DateTime.Parse("January 6, 1994"), DateTime.Parse("Dec 31, 2021"), 1000);

            ShowIt(perDuterte);
            ShowIt(perManny);
            ShowIt(perLea);
            ShowIt(empCatriona);

            Console.ReadLine();
        }
    }
}
