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

        // Check if the Hashtable contains specific keys
        Console.WriteLine("Contains 'apple': " + hashtable.Contains("apple")); // True
        Console.WriteLine("Contains 'banana': " + hashtable.Contains("banana")); // True
        Console.WriteLine("Contains 'date': " + hashtable.Contains("date")); // False

        // Display the number of elements in the Hashtable
        Console.WriteLine("Number of elements in the Hashtable: " + hashtable.Count);
    }
}