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

        // Display the number of elements in the Hashtable
        Console.WriteLine("Number of elements in the Hashtable: " + hashtable.Count);

        // Clear all elements from the Hashtable
        hashtable.Clear();

        // Display the number of elements in the Hashtable after clearing
        Console.WriteLine("Number of elements in the Hashtable after clearing: " + hashtable.Count);
    }
}