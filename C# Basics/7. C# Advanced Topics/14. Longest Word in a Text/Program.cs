using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your sentence");
        string input = Console.ReadLine();
        string inputTrim = input.Trim('.');
        string[] sentence = input.Split(' ');
        string longestWord = sentence[0];
        foreach (string word in sentence)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }     
        }
        Console.WriteLine("The longest word is: {0}",  longestWord);
    }
}