using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLink
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueHash<Person> uniqueHash = new UniqueHash<Person>();
            Person perRodrigo = new Person("Manny", "Pacquiao", DateTime.Parse("December 17, 1978"));
            uniqueHash.Add(perRodrigo);
            uniqueHash.Add(perRodrigo);

            Console.ReadLine();
        }
    }
}

//UniqueHash<Person> uniqueHash = new UniqueHash<Person>();

//Person perRodrigo = new Person("Manny", "Pacquiao", DateTime.Parse("December 17, 1978"));
//IComparable<Person> comparable = perRodrigo as IComparable<Person>;
//comparable.CompareTo(new Person("Manny", "Pacquiao", DateTime.Parse("December 17, 1978")));

