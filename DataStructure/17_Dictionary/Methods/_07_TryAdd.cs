using System;
using System.Collections.Generic;
using static System.Console;

class _07_TryAdd 
{
    static void Main() 
    {
        var dict = new Dictionary<string, int>();

        // TryAdd returns true if successful
        bool added1 = dict.TryAdd("apple", 10);
        WriteLine($"Added apple? {added1}"); // true

        // TryAdd returns false if key already exists
        bool added2 = dict.TryAdd("apple", 20);
        WriteLine($"Added apple again? {added2}"); // false

        WriteLine($"Final value for apple: {dict["apple"]}");
    }
}
