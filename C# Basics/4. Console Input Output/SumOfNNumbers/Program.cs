using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down random integer nmber");
            int n = int.Parse(Console.ReadLine());
            int sum = 0; 
            
            for (int i = 0; i < n; i++)
                {
                    Console.Write("Write down a number ", i + 1);
                    sum += int.Parse(Console.ReadLine());
                }

            Console.WriteLine("The sum of all numbers that you entered is: {0}", sum);



        }
    }
}
