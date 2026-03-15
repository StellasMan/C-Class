using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void ShowIt(Person perObject)
        {
            Employee empObject = (Employee)perObject;
        }

        static void Main(string[] args)
        {
            List<Person> lstPerson = new List<Person>();

            lstPerson.Add(new Person("Rodrigo", "Duterte", DateTime.Parse("March 28, 1945")));
            lstPerson.Add(new Person("Manny", "Pacquiao", DateTime.Parse("December 17, 1978")));

            lstPerson.Add(new Person("Lea", "Salonga", DateTime.Parse("February 22, 1971")));
            lstPerson.Add(new Person("Jose", "Rizal", DateTime.Parse("June 19, 1861")));

            lstPerson.Add(new Person("Catriona", "Gray", DateTime.Parse("January 6, 1994")));
            lstPerson.Add(new Person("Kathryn", "Bernardo", DateTime.Parse("March 26, 1996")));

            lstPerson.Add(new Person("Corazon", "Aquino", DateTime.Parse("January 25, 1933")));
            lstPerson.Add(new Person("Isabel", "Preysler", DateTime.Parse("February 18, 1951")));

            lstPerson.Add(new Person("Lou Diamond", "Phillips", DateTime.Parse("February 17, 1962")));
            lstPerson.Add(new Person("Lapu", "Lapu", DateTime.Parse("Jan 1, 1491")));

            Console.WriteLine("====================================");
            Console.WriteLine("=========== Unsorted List ==========");
            Console.WriteLine("====================================\n");

            foreach (Person perItem in lstPerson)
            {
                Console.WriteLine($"Name: {perItem.Name}, Age: {perItem.Age}");
            }

            LinkedList<Person> llListPerson = new LinkedList<Person>();

            llListPerson.AddLast(new Person("Rodrigo", "Duterte", DateTime.Parse("March 28, 1945")));
            llListPerson.AddLast(new Person("Manny", "Pacquiao", DateTime.Parse("December 17, 1978")));

            llListPerson.AddLast(new Person("Lea", "Salonga", DateTime.Parse("February 22, 1971")));
            llListPerson.AddLast(new Person("Jose", "Rizal", DateTime.Parse("June 19, 1861")));

            llListPerson.AddLast(new Person("Catriona", "Gray", DateTime.Parse("January 6, 1994")));
            llListPerson.AddLast(new Person("Kathryn", "Bernardo", DateTime.Parse("March 26, 1996")));

            llListPerson.AddLast(new Person("Corazon", "Aquino", DateTime.Parse("January 25, 1933")));
            llListPerson.AddLast(new Person("Isabel", "Preysler", DateTime.Parse("February 18, 1951")));

            llListPerson.AddLast(new Person("Lou Diamond", "Phillips", DateTime.Parse("February 17, 1962")));
            llListPerson.AddLast(new Person("Lapu", "Lapu", DateTime.Parse("Jan 1, 1491")));

            Console.WriteLine("\n===========================================");
            Console.WriteLine("=========== Unsorted Linked List ==========");
            Console.WriteLine("===========================================\n");

            foreach (Person perItem in llListPerson)
            {
                Console.WriteLine($"Name: {perItem.Name}, Age: {perItem.Age}");
            }

            Console.WriteLine("\n***************** Using enumerator *****************");
            LinkedList<Person>.Enumerator enumPersonList = llListPerson.GetEnumerator();
            while (enumPersonList.MoveNext())
            {
                Person perItem = enumPersonList.Current;
                Console.WriteLine($"Name: {perItem.Name}, Age: {perItem.Age}");
            }

            Nullable<int> nulInt = null;
            int nValue = (int)nulInt;

            //SortedLinkedList<Person> sllSortedList = new SortedLinkedList<Person>();

            //foreach (Person perItem in llListPerson)
            //{
            //    sllSortedList.Add(perItem);
            //}

            //Console.WriteLine("\n===========================================");
            //Console.WriteLine("=============== Sorted List ===============");
            //Console.WriteLine("===========================================\n");

            //foreach (Person perItem in sllSortedList)
            //{
            //    Console.WriteLine($"Name: {perItem.Name}, Age: {perItem.Age}");
            //}

            Console.WriteLine("\n***************** Sorted Set *****************");

            Random rand = new Random(1);
            SortedSet<int> ssInts = new SortedSet<int>();
            for (int nIx=0; nIx<20; nIx++)
            {
                int nRand = rand.Next(1, 500);
                Console.WriteLine($"Adding {nRand}");
                ssInts.Add(nRand);
            }

            Console.WriteLine("\n***************** Outputting Sorted Set (foreach) *****************");
            int nItem = 1;
            foreach (int nVal in ssInts)
            {
                Console.WriteLine($"Item {nItem++} is {nVal}");
            }

            Console.WriteLine("\n***************** Outputting Sorted Set (Enumerator) *****************");
            nItem = 1;
            SortedSet<int>.Enumerator enumList = ssInts.GetEnumerator();
            while (enumList.MoveNext())
            {
                int nVal = enumList.Current;
                Console.WriteLine($"Item {nItem++} is {nVal}");
            }

            PersonComparer perComparer = new PersonComparer();
            SortedSet<Person> ssPersonSet = new SortedSet<Person>(perComparer);

            foreach (Person perItem in llListPerson)
            {
                ssPersonSet.Add(perItem);
            }

            nItem = 1;
            Console.WriteLine("\n************** Sorted Set of Persons ******************");
            foreach(Person perItem in ssPersonSet)
            {
                Console.WriteLine($"Item {nItem++}: {perItem.Name}");
            }

            int? nVal1 = null;
            int? nVal2 = 5;
            int? nVal3 = nVal1 + nVal2;

            Console.ReadLine();
        }
    } 
}

//static void OverflowMethod(long lValue)
//{
//    int nValue = (int)lValue;
//}

//static void OverflowFloat(double dblValue)
//{
//    float flValue = (float)dblValue;
//    if (float.IsInfinity(flValue))
//    {
//        Console.WriteLine("Overflow!");
//    }
//}

//static void IsPersonOrEmployee(Object objItem)
//{
//    if (objItem is null)
//    {
//        Console.WriteLine("Object is <null>");
//    }
//    else if (objItem is Employee)
//    {
//        Console.WriteLine($"Object '{(objItem as Employee).Name}' is an Employee");
//    }
//    else if (objItem is Person)
//    {
//        Console.WriteLine($"Object '{(objItem as Person).Name}' is a Person");
//    }
//    else
//    {
//        Console.WriteLine($"Object '{objItem.ToString()}' is an unknown type");
//    }
//}

//LinkedList<Person>.Enumerator enumList = llListPerson.GetEnumerator();
//while (enumList.MoveNext())
//{
//    Person perItem = enumList.Current;
//    Console.WriteLine($"Name: {perItem.Name}; Age: {perItem.Age}");
//}

//PersonComparer perComparer = new PersonComparer();
//SortedList<Person, int> slstPerInt = new SortedList<Person, int>(perComparer);

//int nCount = 0;
//foreach (Person perItem in llListPerson)
//{
//    slstPerInt.Add(perItem, ++nCount);
//}

//Console.WriteLine("Person\tInteger");
//foreach (KeyValuePair<Person, int> kvPair in slstPerInt)
//{
//    Console.WriteLine($"{kvPair.Key.Name}\t{kvPair.Value}");
//}

//SortedLinkedList<Person> sllList = new SortedLinkedList<Person>(perComparer);

//foreach (Person perItem in llListPerson)
//{
//    sllList.Add(perItem);
//}


//Nullable<int> nullInt = 0;
//nullInt++;
//int nVal = nullInt.Value;

//Console.WriteLine("Person");
//foreach (Person perItem in sllList)
//{
//    Console.WriteLine($"{perItem.Name}");
//}

