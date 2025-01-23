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

        // Display the number of elements in the Dictionary
        Console.WriteLine("Number of elements in the Dictionary: " + hashmap.Count);

        // Clear all elements from the Dictionary
        hashmap.Clear();

        // Display the number of elements in the Dictionary after clearing
        Console.WriteLine("Number of elements in the Dictionary after clearing: " + hashmap.Count);
    }
}