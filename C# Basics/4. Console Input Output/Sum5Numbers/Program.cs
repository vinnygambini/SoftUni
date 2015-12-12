using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum5Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down 5 numbers.Hit \"Enter\" after each one.. ");

            int int1 = int.Parse(Console.ReadLine());
            int int2 = int.Parse(Console.ReadLine());
            int int3 = int.Parse(Console.ReadLine());
            int int4 = int.Parse(Console.ReadLine());
            int int5 = int.Parse(Console.ReadLine());
            int sum = int1 + int2 + int3 + int4 + int5; 
            Console.WriteLine("   Numbers  |  Sum  |");
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", int1,int2,int3,int4,int5,sum);

        }
    }
}
