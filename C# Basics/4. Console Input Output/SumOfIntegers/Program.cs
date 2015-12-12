using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write down the first integer ");
            int int1 = int.Parse(Console.ReadLine());

            Console.Write("Write down the second integer ");
            int int2 = int.Parse(Console.ReadLine());
            
            Console.Write("Write down the third integer ");
            int int3 = int.Parse(Console.ReadLine());

            int sum = int1 + int2 + int3;
            Console.WriteLine("The sum of the three integers {0},{1},{2} ",int1,int2,int3 + " is " + sum);
        }
    }
}
