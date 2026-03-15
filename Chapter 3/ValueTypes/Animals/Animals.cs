using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animals
{
	// Derives from 'Object'
	class Animal
	{
		public Animal()
		{
			Legs = 4;
			IsInAZoo = true;
		}

		public virtual void IAmA()
		{
			MessageBox.Show(String.Format("I am an Animal, and I have " + Legs + " legs\nand you can {0}find me in a zoo", IsInAZoo ? "" : "not "));
		}

		public void AddLeg()
		{
			Legs++;
		}

		// *********** Protected section *********** 
		protected int Legs;

		// *********** Private section *********** 
		private bool IsInAZoo;
	}

	class Mammal : Animal
	{
		public Mammal()
		{
		}

		public override void IAmA()
		{
			MessageBox.Show(String.Format("I am a mammal, and I have " + Legs + " legs"));
		}
	}

	class Tiger : Mammal
	{
		public Tiger()
		{
		}

		public override void IAmA()
		{
			MessageBox.Show(String.Format("I am a Tiger, and I have " + Legs + " legs"));
		}
	}

	class Human : Mammal
	{
		public Human()
		{
			Legs = 2;

			// --------------- Compiler error ---------------
			// Variable 'IsInAZoo' is PRIVATE to class Animal
			// IsInAZoo = false;
		}

		public override void IAmA()
		{
			MessageBox.Show(String.Format("I am a Human, and I have " + Legs + " legs"));
		}
	}
}
