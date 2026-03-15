using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    class MathFuncs
    {
        public void AddNoReturn(int Value1, int Value2)
        {
            int result = Value1 + Value2;
            Console.WriteLine($"Adding {Value1} and {Value2}: Result = {result}");
        }

        public void MultNoReturn(int Value1, int Value2)
        {
            int result = Value1 * Value2;
            Console.WriteLine($"Multiplying {Value1} and {Value2}: Result = {result}");
        }

        public void ModNoReturn(int Value1, int Value2)
        {
            int result = Value1 % Value2;
            Console.WriteLine($"Getting {Value1} mod {Value2}: Result = {result}");
        }

        public int Add(int Value1, int Value2)
        {
            int result = Value1 + Value2;
            Console.WriteLine($"Adding {Value1} and {Value2}: Result = {result}");
            return result;
        }

        public int Mod(int Value1, int Value2)
        {
            int result = Value1 % Value2;
            Console.WriteLine($"Getting {Value1} mod {Value2}: Result = {result}");
            return result;
        }

        public int Mult(int Value1, int Value2)
        {
            int result = Value1 * Value2;
            Console.WriteLine($"Multiplying {Value1} and {Value2}: Result = {result}");
            return result;
        }

        public int PerformFunc(MethodDelegate funcDelegate, int nValue1, int nValue2)
        {
            return funcDelegate(nValue1, nValue2);
        }

        public void PerformAction(Action<int, int> funcDelegate, int nValue1, int nValue2)
        {
            funcDelegate(nValue1, nValue2);
        }
    }
}
