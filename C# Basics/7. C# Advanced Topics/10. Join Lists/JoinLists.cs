using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class JoinLists
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
        List<string> result1 = result.Concat(names1).ToList();
        result1.Sort();
        foreach (var name in result1)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
}