using System;
using System.Collections;


public class SimpleHashtable {
    public static void Main() {
        // Create a Hashtable
        Hashtable hashtable = new Hashtable();

        // Insert key-value pairs
        hashtable["apple"] = 1;
        hashtable["banana"] = 2;
        hashtable["cherry"] = 3;

        // Lookup values
        Console.WriteLine("Value for 'apple': " + hashtable["apple"]);
        Console.WriteLine("Value for 'banana': " + hashtable["banana"]);

        // Check if a key exists
        if (hashtable.Contains("cherry")) {
            Console.WriteLine("Cherry exists in the Hashtable.");
        }

        // Remove a key-value pair
        hashtable.Remove("banana");

        // Iterate over the Hashtable
        foreach (DictionaryEntry entry in hashtable) {
            Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
        }
    }
}