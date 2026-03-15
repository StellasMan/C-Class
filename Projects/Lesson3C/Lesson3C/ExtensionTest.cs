using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3C
{
    public static class ExtensionTest
    {
        public static int Square(this int num)
        {
            return num * num;
        }
    }
}
