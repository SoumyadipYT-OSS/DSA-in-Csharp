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

        // Check if the Hashtable contains specific values using ContainsValue method
        Console.WriteLine("ContainsValue 1: " + hashtable.ContainsValue(1)); // True
        Console.WriteLine("ContainsValue 2: " + hashtable.ContainsValue(2)); // True
        Console.WriteLine("ContainsValue 4: " + hashtable.ContainsValue(4)); // False

        // Display the number of elements in the Hashtable
        Console.WriteLine("Number of elements in the Hashtable: " + hashtable.Count);
    }
}