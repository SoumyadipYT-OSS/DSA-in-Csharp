using System;
using System.Collections.Generic;
using static System.Console;

class DemoList 
{
    static void Main() 
    {
        List<int> list = new List<int>();

        list.Add(10);
        list.Add(20);
        list.Add(30);

        // printing the list
        foreach (var item in list)
            Write($"{item} ");
        WriteLine();

        // Accessing index
        WriteLine($"Element at index 1: {list[1]}");

        // Check any element contains
        bool hasThirty = list.Contains(30);
        WriteLine($"Does the value 30 contains in the list? {hasThirty}");

        // Remove any element
        var remove = list.Remove(20);
        WriteLine($"After removing the value 20 from the list: {remove}");

        for (int i = 0; i < list.Count; i++)
            Write($"{list[i]}, ");
        WriteLine();
    }
}