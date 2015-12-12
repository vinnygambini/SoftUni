using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class PrimesInGivenRange
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        List<int> primes = FindPrimesInRange(n, m);
        primes.ForEach(Print);
        Console.WriteLine();
    }
        private static void Print(int s)
            {
                Console.Write(s+", ");
            }
 
    static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            if (startNum == 0)
            {
                startNum += 2;
            }
            if (startNum == 1)
            {
                startNum += 1;
            }
            if (startNum > endNum)
            {
                Console.WriteLine("(empty list)");
            }
        List<int> primesList = new List<int>();
        for (int num = startNum; num <= endNum; num++)
        {
            bool prime = true;
            double numSqrt = Math.Sqrt(num);
            for (int div = 2; div <= numSqrt; div++)
        {
        if (num % div == 0)
        {
            prime = false;
            break;
        }
        }
        if (prime)
        {
            primesList.Add(num);
        }
        }
        return primesList;
    }
}