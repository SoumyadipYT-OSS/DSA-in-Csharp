using System;
using System.Collections.Generic;
using static System.Console;


class _06_Remove 
{
    static void Main() 
    {
        var dict = new Dictionary<string, int> 
        {
            ["apple"] = 10,
            ["banana"] = 20,
            ["cherry"] = 30
        };

        Console.WriteLine("Before removal:");
        foreach (var kvp in dict)
            WriteLine($"{kvp.Key} => {kvp.Value}");

        // Remove an element
        bool removed = dict.Remove("banana");
        WriteLine($"\nBanana removed? {removed}");

        Console.WriteLine("\nAfter removal:");
        foreach (var kvp in dict)
            WriteLine($"{kvp.Key} => {kvp.Value}");
    }
}
