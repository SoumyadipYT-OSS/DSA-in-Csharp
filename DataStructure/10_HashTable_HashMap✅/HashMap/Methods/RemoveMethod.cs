using System;
using System.Collections.Generic;


public class Example {
    public static void Main() {
        // Create a new Dictionary
        Dictionary<string, int> hashmap = new Dictionary<string, int>();

        // Add some key-value pairs to the Dictionary
        hashmap.Add("apple", 1);
        hashmap.Add("banana", 2);
        hashmap.Add("cherry", 3);

        // Display the elements in the Dictionary
        Console.WriteLine("Elements in the Dictionary before removal:");
        foreach (var kvp in hashmap) {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        // Remove an element with the specified key
        hashmap.Remove("banana");

        // Display the elements in the Dictionary after removal
        Console.WriteLine("Elements in the Dictionary after removal:");
        foreach (var kvp in hashmap) {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}