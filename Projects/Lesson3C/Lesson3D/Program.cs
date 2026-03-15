using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal myMammal = new Mammal();
            myMammal.Talk();

            Animal myAnimal2 = new Mammal();
            myAnimal2.Talk();

            Console.ReadLine();
        }
    }
}
