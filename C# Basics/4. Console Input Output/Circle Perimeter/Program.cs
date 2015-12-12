using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            Console.WriteLine("Write down the radius ");            
            double radius = double.Parse(Console.ReadLine());
            double area = pi * radius * radius; 

            Console.WriteLine("The area of the cyrcle is {0:0.00} ", area );
            double perimeter = 2 * (pi * radius);
            Console.WriteLine("The perimeter of the cyrcle is {0:0:00} ", perimeter);
        }
    }
}
