using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
	class CRefTest
	{
		public CRefTest()
		{
			Value = 0;
		}

		public CRefTest(int ValueIn)
		{
			Value = ValueIn;
		}

		public int Value = 0;
	};

	public struct StructTest
	{
		public int Value;
	};

	class Program
	{
		static void Main(string[] args)
		{
			// ********************** 'Boxing' Int16 values **********************
			Object obj1 = new System.Int16();
			obj1 = 100;

			Object obj2 = obj1;
			obj1 = 200;

			Console.WriteLine("Object obj1 value: {0}; Object obj2 value: {1}", obj1, obj2);
			Console.ReadKey();
			Console.WriteLine();

			// ********************** Testing 'struct' referencing **********************
			StructTest tstStruct1, tstStruct2;
			tstStruct1.Value = 100;
			tstStruct2 = tstStruct1;
			tstStruct1.Value = 200;

			Console.WriteLine("Value1: {0}; Value2: {1}", tstStruct1.Value, tstStruct2.Value);
			Console.ReadKey();
			Console.WriteLine();

			// ********************** Testing 'class' **********************
			CRefTest refTest1 = new CRefTest(25);
			CRefTest refTest2 = refTest1;
			refTest1.Value = 200;

			Console.WriteLine("Reference Value 1: {0}; Reference Value 2: {1}", refTest1.Value, refTest2.Value);
			Console.ReadKey();
			Console.WriteLine();
		}
	}
}
