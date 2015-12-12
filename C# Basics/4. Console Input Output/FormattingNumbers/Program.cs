using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down an integer from 0 to 500");
            int a = int.Parse(Console.ReadLine());
            while (a < 0 && a > 500)
            {
                Console.WriteLine("Invalid Number...Please try again ");
                a = int.Parse(Console.ReadLine());
                
            }

         Console.WriteLine("Write down first flating-point number");
         float b = float.Parse(Console.ReadLine());
         Console.WriteLine("Write down second flating-point number");
         float c = float.Parse(Console.ReadLine());
         string binary = Convert.ToString(a, 2);   
        
          Console.WriteLine();
          
          Console.WriteLine("{0,-10:X}|{1}|{2,10:F2}|{3,-10:0.000}|", a, binary.PadLeft(10, '0'), b, c);
  
            
        }
    }
}
