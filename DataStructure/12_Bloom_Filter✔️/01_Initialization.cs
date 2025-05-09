using System;
using System.Collections.Generic;


public class BloomFilter {
    private readonly int size;
    private readonly bool[] bitArray;
    private readonly List<Func<string, int>> hashFunctions;

    public BloomFilter(int size, List<Func<string, int>> hashFunctions) {
        this.size = size;
        this.bitArray = new bool[size];
        this.hashFunctions = hashFunctions;
    }


    // Add an item to the Bloom Filter by marking bits at positions calculated by each function.
    public void Add(string item) {
        foreach (var hashFunc in hashFunctions) {
            int index = Math.Abs(hashFunc(item)) % size;
            bitArray[index] = true;
        }
    }

    // Check if an item is possibly in the set
    public bool Query(string item) {
        foreach (var hashFunc in hashFunctions) {
            int index = Math.Abs(hashFunc(item)) % size;
            if (!bitArray[index])
                return false;
        }

        return true;
    }
}


public class Program {
    static void Main() {
        var hashFunctions = new List<Func<string, int>>
        {
            s => s.GetHashCode()
        };


        int bitArraySize = 100;
        BloomFilter bloomFilter = new BloomFilter(bitArraySize, hashFunctions);

        // Add some elements to the Bloom Filter
        bloomFilter.Add("apple");
        bloomFilter.Add("banana");

        // Test membership queries
        Console.WriteLine("Contains 'apple'? " + bloomFilter.Query("apple"));   // Expected to be true
        Console.WriteLine("Contains 'banana'? " + bloomFilter.Query("banana")); // Expected to be true.
        Console.WriteLine("Contains 'cherry'? " + bloomFilter.Query("cherry")); // Expected to be false (or false positive in rare cases).

        // Keep the console window open
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}