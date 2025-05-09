using System;
using System.Collections.Generic;


public class CountingBloomFilter {
    private readonly int size;
    private readonly int[] counterArray;
    private readonly List<Func<string, int>> hashFunctions;


    public CountingBloomFilter(int size, List<Func<string, int>> hashFunctions) {
        this.size = size;
        this.counterArray = new int[size];
        this.hashFunctions = hashFunctions;
    }


    // Adds an item by incrementing each counter for each hash function's index.
    public void Add(string item) {
        foreach (var hashFunc in hashFunctions) {
            int index = Math.Abs(hashFunc(item)) % size;
            counterArray[index]++;
        }
    }

    // Removes an item by decrementing each counter; ensure counters don't drop below zero.
    public void Remove(string item) {
        foreach (var hashFunc in hashFunctions) {
            int index = Math.Abs(hashFunc(item)) % size;
            if (counterArray[index] > 0)  // Prevent negative counts
            {
                counterArray[index]--;
            }
        }
    }

    // Query to check if the item might be in the set (all counters > 0).
    public bool Query(string item) {
        foreach (var hashFunc in hashFunctions) {
            int index = Math.Abs(hashFunc(item)) % size;
            if (counterArray[index] <= 0)
                return false;
        }
        return true;
    }
}



public class Program 
{
    public static void Main() {
        var hashFunctions = new List<Func<string, int>>
        {
            s => s.GetHashCode(),            // First hash function
            s => s.Length * 17               // A second, simple hash
        };

        int bitArraySize = 1000;
        CountingBloomFilter cbf = new CountingBloomFilter(bitArraySize, hashFunctions);

        // Adding elements
        cbf.Add("apple");
        cbf.Add("banana");
        cbf.Add("cherry");

        // Testing membership queries
        Console.WriteLine("Query 'apple': " + cbf.Query("apple"));   // Expected: True
        Console.WriteLine("Query 'banana': " + cbf.Query("banana")); // Expected: True
        Console.WriteLine("Query 'durian': " + cbf.Query("durian")); // Expected: False (or false positive)

        // Remove an element and test its presence again
        cbf.Remove("banana");
        Console.WriteLine("After removal, query 'banana': " + cbf.Query("banana"));

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
