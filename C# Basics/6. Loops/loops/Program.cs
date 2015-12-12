using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 0;
            //while (x < 10)
            //{
            //    Console.WriteLine("Nomer : {0}", x);
            //    x++;
            //}

            int n = Convert.ToInt32(Console.ReadLine());
            // Calculate n! = 1 * 2 * ... * n
            int result = 1;
            while (true)
            {
                if (n == 1)
                    break;
                result *= n;
                n--;
            }
            Console.WriteLine("n! = " + result); 

        }
    }
}
