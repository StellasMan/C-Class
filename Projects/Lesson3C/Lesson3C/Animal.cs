using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3C
{
    public class Animal
    {
        public Animal()
        {
            Name = "John";
            AnimalCost = 1000.00;
        }

        public Animal(string nameParam)
        {
            Name = nameParam;
            AnimalCost = 2000.00;
        }

        public void Talk()
        {
            Console.WriteLine("Hello. My name is " + Name + " and I cost " + AnimalCost);
        }

        public virtual void Talk(string intro)
        {
            Console.WriteLine(intro + ". My name is " + Name + " and I cost " + AnimalCost);
        }

        public string GetName()
        {
            return Name;
        }

        protected string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        protected string name;

        private readonly double AnimalCost;
    }

    public class Mammal : Animal
    {
        public Mammal()
        {
            Talk();
        }

        public Mammal(string nameParam)
            : base(nameParam)
        {
            Talk("Howdy");
        }

        public override void Talk(string intro)
        {
            Console.WriteLine(intro + ". My name is " + Name + "; I am a mammal.");
        }
    }
}
