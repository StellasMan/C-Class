using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3E
{
    class Program
    {
        public static void Swap<T>(ref T var1, ref T var2)
        {
            T Temp = var1;
            var1 = var2;
            var2 = Temp;
        }

        static void Main(string[] args)
        {
            Person perJack = new Person("Arnold", "Jack");
            Console.WriteLine(String.Format("The person's last name is {0}", perJack.LName));
            Console.WriteLine($"The person's last name is {perJack.LName}");

            double grade2 = perJack[1];
            Console.WriteLine($"His 2nd grade is {grade2}");

            int nVar1 = 1;
            int nVar2 = 2;
            Swap<int>(ref nVar1, ref nVar2);

            double dblVar1 = 1.0;
            double dblVar2 = 1.0;
            Swap<double>(ref dblVar1, ref dblVar2);

            GenericStack<int> intStack = new GenericStack<int>(100);
            intStack.Push(100);
            intStack.Push(200);
            intStack.Push(300);
            intStack.Push(400);
            intStack.Push(500);

            int nValue = intStack.Pop();
            Console.WriteLine($"Popped {nValue}");

            nValue = intStack.Pop();
            Console.WriteLine($"Popped {nValue}");

            nValue = intStack.Pop();
            Console.WriteLine($"Popped {nValue}");

            nValue = intStack.Pop();
            Console.WriteLine($"Popped {nValue}");


            GenericStackM<int> intStackM = new GenericStackM<int>();
            intStackM.Push(100, 200);
            intStackM.Push(300, 400);
            intStackM.Push(500);

            Console.ReadLine();
        }
    }
}
