using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three real numbers ");

            Console.WriteLine("\"a\" = ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("\"b\" = ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("\"c\" = ");
            float c = float.Parse(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("Result is +");
            }
            else if (a < 0 && b < 0 && c < 0)
	        {
                Console.WriteLine("Result is -");       
            }
            else
            {
                Console.WriteLine("Result is 0 ");    
            }
        }
    }
}
