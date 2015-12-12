using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down the \"a\" coefficient ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Write down the \"b\" coefficient ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Write down the \"c\" coefficient ");
            int c = int.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;
            double result = (b * b) - (4 * a * c);
            
            double x1,x2;

            if (result == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("The Equation has real roots x1 = x2 {0}", x1);
            }
            else if (result > 0)
            {
                x1 = (-b + Math.Sqrt(d)/ 2 * a * c);
                x2 = (b + Math.Sqrt(d)/ 2 * a * c);
                Console.WriteLine("The Equation has 2 real roots x1 = {0} and x2 ={1}",x1 ,x2);
            }
            else
                Console.WriteLine("The Equation has no real roots ");
        }
    }
}
