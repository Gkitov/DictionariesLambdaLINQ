﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        string input = Console.ReadLine();

        Dictionary<char, int> charCount = CountCharacters(input);

        foreach (var kvp in charCount)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }

    static Dictionary<char, int> CountCharacters(string input)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (c != ' ')
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
        }

        return charCount;
    }
}
