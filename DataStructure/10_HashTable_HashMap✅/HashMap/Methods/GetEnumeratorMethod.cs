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

        // Get an enumerator for the Dictionary
        IEnumerator<KeyValuePair<string, int>> enumerator = hashmap.GetEnumerator();

        // Iterate through the Dictionary using the enumerator
        Console.WriteLine("Elements in the Dictionary:");
        while (enumerator.MoveNext()) {
            var kvp = enumerator.Current;
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}