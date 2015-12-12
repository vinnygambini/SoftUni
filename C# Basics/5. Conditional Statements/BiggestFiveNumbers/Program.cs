using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestFiveNumbers
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
            Console.Write("\"d\"= ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("\"e\"= ");
            double e = double.Parse(Console.ReadLine());
            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine("The bisgest number is " + a);
            }
            else if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine("The bisgest number is " + b);
            }
            else if (c > a && c > b && c > d && c > e)
            {
                Console.WriteLine("The bisgest number is " + c);
            }
            else if (d > a && d > b && d > c && d > e)
            {
                Console.WriteLine("The bisgest number is " + d);
            }
            else
            {
                Console.WriteLine("The bisgest number is " + e);
            }
        }
    }
}
