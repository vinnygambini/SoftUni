using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

class RemoveNames
{
    static void Main(string[] args)
    {   
        string input = Console.ReadLine();
        string[] forbidden = input.Split(' ');
        List<string> names = new List<string>();
        foreach (var name in forbidden)
        {
            names.Add(name);
        }
        string input1 = Console.ReadLine();
        string[] forbidden1 = input1.Split(' ');
        List<string> names1 = new List<string>();
        foreach (var name in forbidden1)
        {
            names1.Add(name);
        }

        List<string> result = names.Except(names1).ToList();
        foreach (var name in result)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
 }
