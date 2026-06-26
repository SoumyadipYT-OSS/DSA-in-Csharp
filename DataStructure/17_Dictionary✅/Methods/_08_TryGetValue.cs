using System;
using System.Collections.Generic;
using static System.Console;

class _08_TryGetValue 
{
    static void Main() 
    {
        var dict = new Dictionary<string, int> {
            ["apple"] = 10,
            ["banana"] = 20
        };

        // Try to get value for "apple"
        if (dict.TryGetValue("apple", out int value)) {
            Console.WriteLine($"Found apple => {value}");
        } else {
            WriteLine("Apple not found");
        }

        // Try to get value for "cherry"
        if (!dict.TryGetValue("cherry", out int missing)) {
            WriteLine($"Cherry not found {missing}");
        }
    }
}
