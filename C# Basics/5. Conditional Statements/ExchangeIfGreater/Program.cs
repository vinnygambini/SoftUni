using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeIfGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down two integers:");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            double BiggerOne;
            if (a > b)
            {
                Console.WriteLine("The intager exchanges their values");
                BiggerOne = b;
                b = a;
                Console.WriteLine("a = {0} and b = {1} ",BiggerOne,b  );
            }
                
            else
            {
               if (a == b)
               {
                   Console.WriteLine("The numbers are equel a{0} = b{1} ",a , b);
               }
                else 
               {
                   Console.WriteLine("b {0} > a {1}...Nothing has changed",b ,a);
               }
                    
            } 
        }    
    }   
}
