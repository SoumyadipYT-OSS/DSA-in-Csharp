
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        var dict = new Dictionary<int, string>()
        {
            { 1, "One" },
            { 2, "Two" },
            { 3, "Three" }
        };

        // Capacity
        Console.WriteLine($"Capacity: {dict.Capacity}");

        // Count
        Console.WriteLine($"Count: {dict.Count}");

        // Comparer - EqualityComparer<TKey>.Default
        Console.WriteLine($"Comparer: {dict.Comparer}");

        // Keys
        Console.WriteLine("Keys");
        foreach (var k in dict.Keys)
            Console.Write($" {k}");
        Console.WriteLine();

        // Item (Indexer) - access value by key
        Console.WriteLine($"Item with key 2: {dict[2]}");

        // Demonstrating update via indexer
        dict[2] = "Two updated";
        Console.WriteLine($"Updated item with key 2: {dict[2]}");

        Console.ReadKey();
    }
}