using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3D
{
    public abstract class Animal
    {
        public Animal()
        {
            Name = "John";
        }

        public Animal(string nameParam)
        {
            Name = nameParam;
        }

        public abstract void Talk();

        protected string Name;
    }

    public class Mammal : Animal
    {
        public Mammal()
        {
        }

        public Mammal(string nameParam)
            : base(nameParam)
        {
            Talk();
        }

        public override void Talk()
        {
            Console.WriteLine("I am a Mammal");
        }
    }
}
