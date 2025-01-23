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

        // Access elements using the Item property (indexer)
        Console.WriteLine("Value for 'apple': " + hashtable["apple"]);
        Console.WriteLine("Value for 'banana': " + hashtable["banana"]);
        Console.WriteLine("Value for 'cherry': " + hashtable["cherry"]);

        // Update an element using the Item property
        hashtable["banana"] = 5;
        Console.WriteLine("Updated value for 'banana': " + hashtable["banana"]);

        // Add a new element using the Item property
        hashtable["date"] = 4;
        Console.WriteLine("Value for 'date': " + hashtable["date"]);

        // Display the number of elements in the Hashtable
        Console.WriteLine("Number of elements in the Hashtable: " + hashtable.Count);
    }
}