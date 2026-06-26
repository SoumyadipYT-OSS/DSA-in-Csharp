using System;
using System.Collections.Generic;
using static System.Console;

class _05_GetEnumerator
{
    static void Main() 
    {
        var dict = new Dictionary<string, int> 
        {
            ["apple"] = 10,
            ["banana"] = 20,
            ["mango"] = 30
        };

        var enumerator = dict.GetEnumerator();      // GetEnumerator() method

        while (enumerator.MoveNext()) 
        {
            var kvp = enumerator.Current;
            WriteLine($"{kvp.Key} --> {kvp.Value}");
        }
    }
}