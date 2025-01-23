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

        // Display the IsSynchronized property
        Console.WriteLine("Is the Hashtable synchronized? " + hashtable.IsSynchronized);

        // Synchronize access to the Hashtable
        lock (hashtable.SyncRoot) {
            // Add another element
            hashtable.Add("date", 4);

            // Display the updated number of elements in the Hashtable
            Console.WriteLine("Number of elements in the Hashtable: " + hashtable.Count);
        }

        // Remove an element
        hashtable.Remove("banana");

        // Display the updated number of elements in the Hashtable after removal
        Console.WriteLine("Number of elements in the Hashtable after removing an element: " + hashtable.Count);
    }
}