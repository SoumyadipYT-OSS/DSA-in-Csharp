using System;
using System.Collections.Generic;


public class SimpleHashMap {
    public static void Main() {
        // Create a Dictionary (HashMap)
        Dictionary<string, int> hashMap = new Dictionary<string, int>();

        // Insert key-value pairs
        hashMap["apple"] = 1;
        hashMap["banana"] = 2;
        hashMap["cherry"] = 3;

        // Lookup values
        Console.WriteLine("Value for 'apple': " + hashMap["apple"]);
        Console.WriteLine("Value for 'banana': " + hashMap["banana"]);

        // Check if a key exists
        if (hashMap.ContainsKey("cherry")) {
            Console.WriteLine("Cherry exists in the HashMap.");
        }

        // Remove a key-value pair
        hashMap.Remove("banana");

        // Iterate over the HashMap
        foreach (var kvp in hashMap) {
            Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        }
    }
}