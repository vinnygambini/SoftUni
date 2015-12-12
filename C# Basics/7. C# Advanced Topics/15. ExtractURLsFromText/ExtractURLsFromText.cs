using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string sampleText = Console.ReadLine();
        string pattern = @"([htpw]+)([://\.]+)([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})";
        MatchCollection results = Regex.Matches(sampleText, pattern);
        for (int i = 0; i < results.Count; i++)
        {
            Console.WriteLine(results[i]);
        }

    }
}