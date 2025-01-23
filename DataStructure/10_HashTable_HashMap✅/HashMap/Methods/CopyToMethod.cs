using System;
using System.Collections.Generic;

/*      CopyTo(KeyValuePair<TKey, TValue>[] array, int index)       */

public class Example {
    public static void Main() {
        // Create a new Dictionary
        Dictionary<string, int> hashmap = new Dictionary<string, int>();

        // Add some key-value pairs to the Dictionary
        hashmap.Add("apple", 1);
        hashmap.Add("banana", 2);
        hashmap.Add("cherry", 3);

        // Create an array to copy the elements to
        KeyValuePair<string, int>[] array = new KeyValuePair<string, int>[hashmap.Count];

        // Copy the elements of the Dictionary to the array starting at index 0
        hashmap.CopyTo(array, 0);

        // Display the elements in the array
        Console.WriteLine("Elements in the array:");
        foreach (var kvp in array) {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}