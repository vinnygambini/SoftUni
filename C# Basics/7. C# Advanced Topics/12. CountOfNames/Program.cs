using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string ch = Console.ReadLine();
        string[] abv = ch.Split(' ');
        List<string> letters = new List<string>();
        foreach (var name in abv)
        {
            letters.Add(name);
        }
        letters.Sort();
        int count = 1;
        for (int i = 0; i < abv.Length - 1; i++)
        {
            if (letters[i] == letters[i + 1])
            {
                count++;
            }
            else
            {
                Console.WriteLine(letters[i] + " -> " + count);
                count = 1;
            }
            if (i == abv.Length - 2)
            {
                Console.WriteLine(letters[i + 1] + " -> " + count);
                count = 1;
            }
        }
        if (abv.Length == 1)
        {
            Console.WriteLine(letters[0] + " -> " + 1);
        }
    }
}
