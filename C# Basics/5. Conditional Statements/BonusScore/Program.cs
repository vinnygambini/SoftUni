using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down an int in the range [1…9] ");
            int a = int.Parse(Console.ReadLine());

            if (a >= 1 && a <= 3)
            {
                a *= 10;
                Console.WriteLine("Multilies \"a\" by 10",a);
            }
            else if (a >= 4 && a <= 6)
            {
                a *= 100;
                Console.WriteLine("Multilies \"a\" by 100", a);
            }
            else if (a >=7 && a <= 9)
            {
                a *= 1000;
                Console.WriteLine("Multilies \"a\" by 1000", a);
            }
            else 
            {
                Console.WriteLine("The \"0\" and numbers above 9 are invalid numbers");
            }
        }
    }
}
