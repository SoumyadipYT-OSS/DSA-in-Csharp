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

        // Display the values in the Dictionary using the Values property
        Console.WriteLine("Values in the Dictionary:");
        foreach (var value in hashmap.Values) {
            Console.WriteLine(value);
        }

        // Add another key-value pair
        hashmap.Add("date", 4);

        // Display the updated values in the Dictionary
        Console.WriteLine("Updated values in the Dictionary:");
        foreach (var value in hashmap.Values) {
            Console.WriteLine(value);
        }
    }
}