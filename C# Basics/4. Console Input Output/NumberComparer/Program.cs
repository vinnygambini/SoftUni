using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Write down the first number(integer or double)");
            double FirstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write down the second number(integer or double)");
            double SecondNumber = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("The bigger number from both is: {0}", Math.Max(FirstNumber, SecondNumber));                  
        }
    }
}
