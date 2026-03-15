using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3DHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Student leah = new Student("Salonga", "Lea", 'C', GENDER.FEMALE, 145, 3.7);
            leah.Talk();

            Professor profCanlas = new Professor("Canlas", "Dante", 'B', GENDER.MALE, 165, true);
            profCanlas.Talk();

            Administrator admCorkery = new Administrator("Corkery", "Mike", ' ', GENDER.MALE, 185, "Business");
            admCorkery.Talk();

            Console.ReadLine();
        }
    }
}
