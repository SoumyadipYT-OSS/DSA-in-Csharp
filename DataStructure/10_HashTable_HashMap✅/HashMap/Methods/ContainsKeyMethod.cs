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

        // Check if the Dictionary contains specific keys using ContainsKey method
        Console.WriteLine("ContainsKey 'apple': " + hashmap.ContainsKey("apple")); // True
        Console.WriteLine("ContainsKey 'banana': " + hashmap.ContainsKey("banana")); // True
        Console.WriteLine("ContainsKey 'date': " + hashmap.ContainsKey("date")); // False

        // Display the number of elements in the Dictionary
        Console.WriteLine("Number of elements in the Dictionary: " + hashmap.Count);
    }
}