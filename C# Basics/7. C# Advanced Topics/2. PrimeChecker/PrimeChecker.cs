using System;

class PrimeChecker
{
    static void Main(string[] args)
    {

        double input = double.Parse(Console.ReadLine());
        if (input <= 1)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine(IsPrime(input));
        }
    }
    static Boolean IsPrime(double number)
    {
        Boolean Prime = true;
        for (double i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                Prime=false;
            }
        }
        return Prime;
    }
}