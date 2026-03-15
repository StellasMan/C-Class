using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animals
{
	public partial class AnimalsForm : Form
	{
		public AnimalsForm()
		{
			InitializeComponent();
		}

		private void OnLoad(object sender, EventArgs e)
		{
			cmbAnimals.Items.Add("Tiger");
			cmbAnimals.Items.Add("Human");
			cmbAnimals.Items.Add("Snake");
			cmbAnimals.Items.Add("Frog");

			cmbAnimals.SelectedIndex = 0;
		}

		private Animal GetAnimal()
		{
			Animal aAnimal;		// NULL value

			switch(cmbAnimals.SelectedIndex)
			{
				case 0:
					aAnimal = new Tiger();
					break;

				case 1:
					aAnimal = new Human();
					break;

				/*
				case 2:
					aAnimal = new Snake();
					break;

				case 3:
					aAnimal = new Frog();
					break;
				*/

				default:
					aAnimal = new Animal();
					break;
			}

			return aAnimal;
		}

		private void OnGo(object sender, EventArgs e)
		{
			Animal myAnimal1 = GetAnimal();
			myAnimal1.IAmA();

			Animal myAnimal2 = myAnimal1;

			myAnimal1.AddLeg();

			// Compiler error - variable 'Leg' cannot be accessed 
			// outside of class Animal or one of the classes
			// derived from Animal.

			// myAnimal1.Leg++;	

			myAnimal1.IAmA();
			myAnimal2.IAmA();
		}
	}
}
