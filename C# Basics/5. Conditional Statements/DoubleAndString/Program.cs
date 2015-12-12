using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleAndString
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int userChoice = int.Parse(Console.ReadLine());
        switch (userChoice)
        {
            case 1:
                Console.Write("Please enter an int: ");
                int inputInt = int.Parse(Console.ReadLine());
                int outputInt = inputInt + 1;
                Console.WriteLine(outputInt);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double inputDouble = double.Parse(Console.ReadLine());
                double outputDouble = inputDouble + 1;
                Console.WriteLine(outputDouble);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string inputString = Console.ReadLine();
                string outputString = inputString + "*";
                Console.WriteLine(outputString);
                break;
        }
    }
}
