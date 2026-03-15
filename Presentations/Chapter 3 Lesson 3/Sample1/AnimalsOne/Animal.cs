using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsOne
{
    public abstract class Animal
    {
        public Animal()
        {
            m_sName = "Unknown Animal";
            Console.WriteLine("Animal created!");
        }

        public Animal(string sName)
        {
            m_sName = sName;
            Console.WriteLine("Animal created!");
        }

        public virtual void Talk()
        {
            Console.WriteLine("I am an Animal");
        }

        public abstract void MakeNoise();

        protected string m_sName;
    }

    public abstract class Mammal : Animal
    {
        public Mammal()
        {
            m_sName = "Unknown Mammal";
            Console.WriteLine("Mammal created!");
        }

        public Mammal(string sName)
            : base(sName)
        {
            Console.WriteLine("Mammal created!");
        }

        public override void Talk()
        {
            Console.WriteLine("I am a Mammal");
        }
    }

    public class Human : Mammal
    {
        public Human(string sName)
            : base(sName)
        {
            Console.WriteLine("Human created!");
        }

        public override void Talk()
        {
            Console.WriteLine("I am a Human");
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Making Human noises now");
        }
    }
}
