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

        // Check if the Dictionary contains specific values using ContainsValue method
        Console.WriteLine("ContainsValue 1: " + hashmap.ContainsValue(1)); // True
        Console.WriteLine("ContainsValue 2: " + hashmap.ContainsValue(2)); // True
        Console.WriteLine("ContainsValue 4: " + hashmap.ContainsValue(4)); // False

        // Display the number of elements in the Dictionary
        Console.WriteLine("Number of elements in the Dictionary: " + hashmap.Count);
    }
}