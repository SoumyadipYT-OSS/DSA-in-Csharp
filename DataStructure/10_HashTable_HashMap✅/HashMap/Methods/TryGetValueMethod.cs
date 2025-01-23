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

        // Try to get the value associated with the key "banana"
        if (hashmap.TryGetValue("banana", out int value)) {
            Console.WriteLine("Value for 'banana': " + value);
        } else {
            Console.WriteLine("'banana' not found in the dictionary.");
        }

        // Try to get the value associated with the key "date"
        if (hashmap.TryGetValue("date", out value)) {
            Console.WriteLine("Value for 'date': " + value);
        } else {
            Console.WriteLine("'date' not found in the dictionary.");
        }
    }
}