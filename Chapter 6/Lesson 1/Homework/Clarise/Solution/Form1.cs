using System;
using System.Windows.Forms;

namespace Solution
{
    public partial class Form1 : Form
    {
        public delegate void SomeFuncDelegate(string param1, int param2);

        public Form1()
        {
            InitializeComponent();
        }

        private void OnDoIt(object sender, EventArgs e)
        {
            // item # 1: Calling one method using a delegate
            Console.WriteLine("Calling SomeFunc via delegate ");
            SomeFuncDelegate myDelegate = SomeFunc;
            myDelegate("Test delegate", 3);

            //item # 2: Calling two methods using one delegate
            Console.WriteLine("\n Calling SomeFunc and SomeFunc2 via one delegate");
            myDelegate = SomeFunc;
            myDelegate += SomeFunc2;
            myDelegate("Two methods one delegate", 5);

            // Calling MyFunc (Item #3) using 'myDelegate' as a parameter
            MyFunc(myDelegate, "Hello World", 25);

            //item # 4: Action template
            Console.WriteLine("\n Calling SomeFunc and SomeFunc2 via Action template");
            Action<string, int> myAction = SomeFunc;
            myAction("delegate action template", 7);
            Action<string, int> myAction2 = SomeFunc2;
            myAction2("delegate action template", 4);

            // Item #5:Create an anonymous method using the delegate(…) {  } syntax and assign it to an Action<int> variable. i.e., Action<int> actSimple = delegate….
            Action<int> myAnonMethod = delegate (int x) 
            {
                Console.WriteLine($"{x:#,###} squared is {x * x:#,###}");
            };

            // The above can be shortened to:
            Action<int> myAnonMethod2 = (x) => Console.WriteLine($"{x:#,###} squared is {x * x:#,###}");

            // Now we can call our anonymous methods via the delegate
            myAnonMethod(1024);
            myAnonMethod2(2048);
        }

        // Item 3: Create a method which takes 3 parameters, ‘SomeFuncDelegate’, a string, and an integer, and invokes the delegate passed in.
        private void MyFunc(SomeFuncDelegate someFuncDelegate, string sVal, int nVal)
		{
            someFuncDelegate(sVal, nVal);
		}

        // Method which matches
        // 1) delegate void SomeFuncDelegate(string param1, int param2) or
        // 2) Action<string, int>
        private void SomeFunc(string sVal, int nVal)
        {
            for (int nIx = 0; nIx < nVal; nIx++)
            {
                Console.WriteLine($"{nIx + 1,3}) {sVal}");

            }
        }

        // Method which matches
        // 1) delegate void SomeFuncDelegate(string param1, int param2) or
        // 2) Action<string, int>
        private void SomeFunc2(string sVal, int nVal)
        {
            string sResult = sVal;
            for (int nIx=0; nIx<nVal-1; nIx++)
            {
                sResult += sVal;
            }
            Console.WriteLine(sResult);
        }
    }
}
