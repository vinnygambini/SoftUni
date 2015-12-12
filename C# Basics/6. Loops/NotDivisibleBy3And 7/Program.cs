using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDivisibleBy3And_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down an integer");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <=n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine("The numbers that are not devideble by 7 and 3 are " + i);
                }

            }
        }
    }
}
