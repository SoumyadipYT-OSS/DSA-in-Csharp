using System;
using System.Collections.Concurrent;

public class Program {
    public static void Main() {
        // Create a ConcurrentDictionary with int keys and string values.
        ConcurrentDictionary<int, string> dict = new ConcurrentDictionary<int, string>();

        // Add entries using TryAdd.
        dict.TryAdd(1, "One");
        dict.TryAdd(2, "Two");
        dict.TryAdd(3, "Three");

        // Update an entry (this is thread-safe).
        dict[2] = "Two updated";

        // Remove an entry using TryRemove.
        string removedValue;
        bool removed = dict.TryRemove(3, out removedValue);

        // Retrieve an entry using TryGetValue.
        string value;
        bool exists = dict.TryGetValue(1, out value);
        Console.WriteLine("Value for key 1: " + value);

        // Enumerate through the dictionary.
        Console.WriteLine("Elements in ConcurrentDictionary:");
        foreach (var kvp in dict) {
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
