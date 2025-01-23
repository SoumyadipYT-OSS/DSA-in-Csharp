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

        // Display the keys in the Dictionary using the Keys property
        Console.WriteLine("Keys in the Dictionary:");
        foreach (var key in hashmap.Keys) {
            Console.WriteLine(key);
        }

        // Add another key-value pair
        hashmap.Add("date", 4);

        // Display the updated keys in the Dictionary
        Console.WriteLine("Updated keys in the Dictionary:");
        foreach (var key in hashmap.Keys) {
            Console.WriteLine(key);
        }
    }
}