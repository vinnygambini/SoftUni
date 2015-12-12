using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 0 || n == 1)
        {
            Console.WriteLine(1);
        }
        else
        {
            int fib0 = 1;
            int fib1 = 1;
            int fibn = 0;
            for (int i = 1; i < n; i++)
            {
                fibn = fib0 + fib1;
                fib0 = fib1;
                fib1 = fibn;
            }
            Console.WriteLine(fibn);
        }
    }
}