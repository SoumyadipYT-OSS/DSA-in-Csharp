using System;
using System.Collections;


public class Example {
    public static void Main() {
        // Create a new Hashtable
        Hashtable hashtable = new Hashtable();

        // Add some elements to the Hashtable
        hashtable.Add("apple", 1);
        hashtable.Add("banana", 2);
        hashtable.Add("cherry", 3);

        // Display the keys in the Hashtable using the Keys property
        Console.WriteLine("Keys in the Hashtable:");
        foreach (var key in hashtable.Keys) {
            Console.WriteLine(key);
        }

        // Add another element
        hashtable.Add("date", 4);

        // Display the updated keys in the Hashtable
        Console.WriteLine("Updated keys in the Hashtable:");
        foreach (var key in hashtable.Keys) {
            Console.WriteLine(key);
        }
    }
}