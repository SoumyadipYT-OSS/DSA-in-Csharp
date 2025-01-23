using System;
using System.Collections.Generic;

/*      Item[TKey key] property     */

public class Example {
    public static void Main() {
        // Create a new Dictionary
        Dictionary<string, int> hashmap = new Dictionary<string, int>();

        // Add some key-value pairs to the Dictionary
        hashmap.Add("apple", 1);
        hashmap.Add("banana", 2);
        hashmap.Add("cherry", 3);

        // Access and display values by key using the Item property (indexer)
        Console.WriteLine("Value for 'apple': " + hashmap["apple"]);
        Console.WriteLine("Value for 'banana': " + hashmap["banana"]);
        Console.WriteLine("Value for 'cherry': " + hashmap["cherry"]);

        // Update a value using the Item property (indexer)
        hashmap["banana"] = 5;
        Console.WriteLine("Updated value for 'banana': " + hashmap["banana"]);

        // Add a new key-value pair using the Item property (indexer)
        hashmap["date"] = 4;
        Console.WriteLine("Value for 'date': " + hashmap["date"]);

        // Display the number of elements in the Dictionary
        Console.WriteLine("Number of elements in the Dictionary: " + hashmap.Count);
    }
}