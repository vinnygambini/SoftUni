using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOfThreeNumbers
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

                if (a > b && a > c )
                {
                    Console.WriteLine("The bisgest number is " +a);
                }
                else if (b > a && b > c)
                {         
                    Console.WriteLine("The bisgest number is " +b); 
                }
                else if (c > a && c > b)
        	    {
                    Console.WriteLine("The bisgest number is " +c);
        	    }
                else
            	{
                    Console.WriteLine("The numbers are equal");
	            }
            
        }
    }
}
