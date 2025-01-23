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

        // Display the number of elements in the Dictionary using the Count property
        Console.WriteLine("Number of elements in the Dictionary: " + hashmap.Count);

        // Add another key-value pair
        hashmap.Add("date", 4);

        // Display the updated number of elements in the Dictionary
        Console.WriteLine("Updated number of elements in the Dictionary: " + hashmap.Count);
    }
}