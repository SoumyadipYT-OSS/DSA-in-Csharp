using System;
using System.Collections;

/*      CopyTo(Array arr, int index)        */

public class Example {
    public static void Main() {
        // Create a new Hashtable
        Hashtable hashtable = new Hashtable();

        // Add some elements to the Hashtable
        hashtable.Add("apple", 1);
        hashtable.Add("banana", 2);
        hashtable.Add("cherry", 3);

        // Create an array to copy the elements to
        DictionaryEntry[] array = new DictionaryEntry[hashtable.Count];

        // Copy the elements of the Hashtable to the array starting at index 0
        hashtable.CopyTo(array, 0);

        // Display the elements in the array
        Console.WriteLine("Elements in the array:");
        foreach (DictionaryEntry entry in array) {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}