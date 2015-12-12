using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndMaxOfNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write down an integer");   
            int num = int.Parse(Console.ReadLine());
            int biggestNum = 0;
            int smallestNum = 0;
            int sum = 0;
            float averageSum;

            for (int i = 1; i <= num; i++)
            {
                Console.Write("Number {0}: ", i);
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (i == 1)
                {
                    biggestNum = number;
                    smallestNum = number;
                }
                else
                {
                    if (number > biggestNum)
                    {
                        biggestNum = number;
                    }
                    else if (number < smallestNum)
                    {
                        smallestNum = number;
                    }
                }
            }

            averageSum = (float)sum / num;
            Console.WriteLine("Biggest: {0}\nSmallest: {1}", biggestNum, smallestNum);            
            Console.WriteLine("The sum is number is " + sum);
            Console.WriteLine("The average number is " + averageSum);
        }
    }
}
