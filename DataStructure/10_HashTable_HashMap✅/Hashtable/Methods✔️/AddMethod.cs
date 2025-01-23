using System;
using System.Collections;


public class Example {
    public static void Main() {
        // Create a new Hashtable
        Hashtable hashtable = new Hashtable();

        // Add some elements to the Hashtable using the Add method
        hashtable.Add("apple", 1);
        hashtable.Add("banana", 2);
        hashtable.Add("cherry", 3);

        // Display the elements in the Hashtable
        Console.WriteLine("Elements in the Hashtable:");
        foreach (DictionaryEntry entry in hashtable) {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        // Try to add an element with a duplicate key (this will throw an exception)
        try {
            hashtable.Add("apple", 4);
        } catch (ArgumentException e) {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}