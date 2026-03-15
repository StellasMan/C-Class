using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public void Speak()
        {
            Console.WriteLine("Howdy! I'm an animal!");
        }
    }

    public class Mammal : Animal
    {
        public new void Speak()
        {
            Console.WriteLine("Howdy! I'm a mammal!");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Animal someAnimal = new Animal();
            someAnimal.Speak();

            Mammal someMammal = new Mammal();
            someMammal.Speak();

            someAnimal = someMammal;
            someAnimal.Speak();

            Console.Write("Number of times to loop >> ");
            string sCount = Console.ReadLine();
            int nCount;
            if (int.TryParse(sCount, out nCount))
            {
                for (int nIx=0; nIx<nCount; nIx++)
                {
                    Console.WriteLine(nIx+1);
                }

                Console.WriteLine("Done!");
            }

            Console.ReadKey();
        }
    }
}
