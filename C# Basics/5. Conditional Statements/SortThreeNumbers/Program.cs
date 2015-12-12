using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down three numbers ");
            Console.Write("\"a\"= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("\"b\"= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("\"c\"= ");
            double c = double.Parse(Console.ReadLine());

            if (a > b)
            {
                if (b > c)
                {
                    Console.WriteLine("The right order is a{0} b{1} c{2}", a, b, c);
                }
                else if (a > c)
                {
                    Console.WriteLine("The right order is a{0} c{1} b{2}", a, c, b);
                }
                else
                {
                    Console.WriteLine("The right order is c{0} a{1} b{2}", c, a, b);
                }
            }
            else
            {
                if (a > c)
                {
                    Console.WriteLine("The right order is b{0} a{1} c{2}", b, a, c);
                }
                else if (c > b)
                {
                    Console.WriteLine("The right order is c{0} b{1} a{2}", c, b, a);
                }
                else
                {
                    Console.WriteLine("The right order is b{0} c{1} a{2}", b, c, a);
                }
            }
        }
    }
}