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

        // Get an enumerator for the Hashtable
        IDictionaryEnumerator enumerator = hashtable.GetEnumerator();

        // Iterate through the Hashtable using the enumerator
        Console.WriteLine("Elements in the Hashtable:");
        while (enumerator.MoveNext()) {
            Console.WriteLine($"{enumerator.Key}: {enumerator.Value}");
        }
    }
}