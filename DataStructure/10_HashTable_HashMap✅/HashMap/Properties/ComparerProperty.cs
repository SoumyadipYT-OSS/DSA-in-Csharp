using System;
using System.Collections.Generic;

public class Example {
    public static void Main() {
        // Create a custom equality comparer
        IEqualityComparer<string> customComparer = StringComparer.OrdinalIgnoreCase;

        // Create a new Dictionary with the custom equality comparer
        Dictionary<string, int> hashmap = new Dictionary<string, int>(customComparer);

        // Add some key-value pairs to the Dictionary
        hashmap.Add("apple", 1);
        hashmap.Add("banana", 2);
        hashmap.Add("cherry", 3);

        // Display the elements in the Dictionary
        Console.WriteLine("Elements in the Dictionary:");
        foreach (var kvp in hashmap) {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        // Display the comparer used by the Dictionary
        Console.WriteLine("Comparer: " + hashmap.Comparer);
    }
}