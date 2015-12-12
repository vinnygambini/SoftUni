using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculation
{
    class AgeCalculation
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Aften 10 years you'll be {0} years old", age + 10);
        }
    }
}
