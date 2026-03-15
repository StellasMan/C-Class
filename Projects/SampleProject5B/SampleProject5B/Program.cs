using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject5B
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] arrPersons =
            {
                new Person("Rodrigo", "Duterte", GENDER.MALE, DateTime.Parse("March 28, 1945")),
                new Person("Manny", "Pacquiao", GENDER.MALE, DateTime.Parse("December 17, 1978")),
                new Person("Lea", "Salonga", GENDER.FEMALE, DateTime.Parse("February 22, 1971")),
                new Person("Kim", "Dawson", GENDER.FEMALE, DateTime.Parse("April 12, 1975")),
                new Person("Kim", "Dawson", GENDER.MALE, DateTime.Parse("March 15, 1971")),
                new Person("Catriona", "Gray", GENDER.FEMALE, DateTime.Parse("January 6, 1994")),
                new Person("Bautista", "Christian", GENDER.MALE, DateTime.Parse("October 19, 1981")),
                new Person("Josette", "Biyo", GENDER.FEMALE, DateTime.Parse("March 19, 1958")),
                new Person("George", "Washington", GENDER.MALE, DateTime.Parse("February 22, 1732")),
                new Person("John", "Adams", GENDER.MALE, DateTime.Parse("October 30, 1735")),
                new Person("Thomas", "Jefferson", GENDER.MALE, DateTime.Parse("April 13, 1743")),
                new Person("James", "Madison", GENDER.MALE, DateTime.Parse("March 16, 1751"))
            };

            Console.WriteLine("***** Unsorted list *****");
            int nCount = 1;
            foreach(Person perItem in arrPersons)
            {
                Console.WriteLine($"{nCount++,2}) {perItem.Name,-30} Age: {perItem.Age,3}");
            }

            // Create a sorted linked list which will sort in descending order
            SortedLinkedList<Person> personList = new SortedLinkedList<Person>(SortedLinkedList<Person>.SLL_DIRECTION.SLL_DOWN);
            foreach (Person perItem in arrPersons)
            {
                personList.Add(perItem);
            }

            Console.WriteLine("\n***** Sorted list *****");
            nCount = 1;
            foreach(Person perItem in personList)
            {
                Console.WriteLine($"{nCount++,2}) {perItem.Name,-30} Age: {perItem.Age,3}");
            }

            Console.ReadLine();
        }
    }
}
