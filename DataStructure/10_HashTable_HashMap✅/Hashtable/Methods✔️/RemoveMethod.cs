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

        // Display the elements in the Hashtable
        Console.WriteLine("Elements in the Hashtable before removal:");
        foreach (DictionaryEntry entry in hashtable) {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        // Remove an element with the specified key
        hashtable.Remove("banana");

        // Display the elements in the Hashtable after removal
        Console.WriteLine("Elements in the Hashtable after removal:");
        foreach (DictionaryEntry entry in hashtable) {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}