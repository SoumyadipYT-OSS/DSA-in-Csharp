using System;
using System.Collections.Generic;

/*      Add(TKey key, TValue value)     */


public class Example {
    public static void Main() {
        // Create a new Dictionary
        Dictionary<string, int> hashmap = new Dictionary<string, int>();

        // Add some key-value pairs to the Dictionary using the Add method
        hashmap.Add("apple", 1);
        hashmap.Add("banana", 2);
        hashmap.Add("cherry", 3);

        // Display the elements in the Dictionary
        Console.WriteLine("Elements in the Dictionary:");
        foreach (var kvp in hashmap) {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        // Try to add an element with a duplicate key (this will throw an exception)
        try {
            hashmap.Add("apple", 4);
        } catch (ArgumentException e) {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}