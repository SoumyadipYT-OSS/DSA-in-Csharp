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

        // Display the elements in the original Hashtable
        Console.WriteLine("Original Hashtable:");
        foreach (DictionaryEntry entry in hashtable) {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        // Clone the Hashtable
        Hashtable clonedHashtable = (Hashtable)hashtable.Clone();

        // Display the elements in the cloned Hashtable
        Console.WriteLine("Cloned Hashtable:");
        foreach (DictionaryEntry entry in clonedHashtable) {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}