using System;
using System.Windows.Forms;

namespace DelegateDisplay
{
    public partial class DelegateDisplayForm : Form
    {
        public delegate void MySimpleDelegate(int nValue1, double dblValue2);
        public delegate long MyOtherDelegate(int nValue1, double dblValue2);

        public void SomeMethod(int nParam1, double dblParam2)
        {
            double result = nParam1 * dblParam2;
            Console.WriteLine($"{"SomeMethod", -20} {nParam1} times {dblParam2} = {result}");
        }

        public void AnotherMethod(int nParam1, double dblParam2)
        {
            double result = nParam1 + dblParam2;
            Console.WriteLine($"{"AnotherMethod",-20} {nParam1} plus {dblParam2} = {result}");
        }

        public long SomeOtherMethod(int nParam1, double dblParam2)
        {
            double result = nParam1 * dblParam2;
            Console.WriteLine($"{"SomeOtherMethod",-20} {nParam1} times {dblParam2} = {result}");

            return (long)result;
        }

        public long SomeOtherMethod2(int nParam1, double dblParam2)
        {
            double result = nParam1 * dblParam2;
            Console.WriteLine($"{"SomeOtherMethod2",-20} {nParam1} times {dblParam2} = {result}");

            return (long)result;
        }

        public DelegateDisplayForm()
        {
            InitializeComponent();
        }

        private void OnDoIt(object sender, EventArgs e)
        {
            // Here we are assigning delegate 'myDelegate' a reference to method 'SomeMethod'
            MySimpleDelegate myDelegate = SomeMethod;

            Console.WriteLine("Calling method via delegate");
            myDelegate(5, 3.1415);

            Console.WriteLine("Calling method directly");
            SomeMethod(5, 3.1415);

            // The following will cause ‘SomeMethod’ to be invoked twice, followed by ‘AnotherMethod’
            myDelegate += SomeMethod;
            myDelegate += AnotherMethod;
            myDelegate(5, 3.1415);

            // The following removes one reference to ‘SomeMethod’.
            // Invoking ‘myDelegate’ will cause ‘SomeMethod’ to be called once only,
            // followed by ‘AnotherMethod’.
            myDelegate -= SomeMethod;
            myDelegate(5, 3.1415);

            Console.WriteLine("Calling method via Action template");
            Action<int, double> myAction = SomeMethod;
            myAction(5, 3.1415);

            // Here we are assigning a delegate with a return type to method 'SomeOtherMethod'
            Console.WriteLine("Calling method which returns a 'long' via delegate");
            MyOtherDelegate myOtherDelegate = SomeOtherMethod;
            long lValue = myOtherDelegate(5, 3.1415);

            // Using a Func template in place of a delegate declaration and assignment
            Console.WriteLine("Calling method which returns a 'long' via Func template");
            Func<int, double, long> myOtherFunc = SomeOtherMethod;
            lValue = myOtherFunc(5, 3.1415);

            // Create an anonymous method which squares a number
            Func<double, double> funcSquare = delegate (double x) { return x * x; };

            Console.WriteLine("Calling anonymous method which returns the square of a number");
            double dblSquared = funcSquare(3.1415);
            Console.WriteLine($"Pi squared is {dblSquared}");

            // Create a Lambda statement
            Console.WriteLine("Calling lambda statement via a Func template");
            Func<double, double> funcLambda = (x) => x * x;
            dblSquared = funcLambda(3.1415);
            Console.WriteLine($"Pi squared is {dblSquared}");

            // Create a Lambda expression
            Console.WriteLine("Calling lambda expression via a Func template");
            Func<double, double> funcLambdaExp = (x) => 
            {
                Console.WriteLine($"Squaring {x}");    
                return x * x; 
            } ;
            dblSquared = funcLambdaExp(3.1415);

            Console.WriteLine($"Pi squared is {dblSquared}");
        }
    }
}
