using System;
using System.Collections;


class SimpleHashTable {
    static void Main() {
        // Create a hashtable
        Hashtable ht = new Hashtable();

        // Insert key-value pairs
        ht["apple"] = 1;
        ht["banana"] = 2;
        ht["cherry"] = 3;

        // Lookup values
        Console.WriteLine("Value for 'apple': " + ht["apple"]);
        Console.WriteLine("Value for 'banana': " + ht["banana"]);

        // Check if a key exists
        if (ht.ContainsKey("cherry")) {
            Console.WriteLine("Cherry exists in the hastable!");
        }

        // Remove a key-value pair
        ht.Remove("banana");

        // Iterate over the Hashtable
        foreach (DictionaryEntry entry in ht) {
            Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
        }
    }
}