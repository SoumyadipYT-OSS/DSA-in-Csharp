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

    // Adds an item to the Bloom Filter by setting bits at indices computed by each hash function.
    public void Add(string item) {
        foreach (var hashFunc in hashFunctions) {
            int index = Math.Abs(hashFunc(item)) % size;
            bitArray[index] = true;
        }
    }

    // Checks if an item is possibly in the set.
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
    public static void Main() {
        // Define multiple hash functions for improved accuracy.
        var hashFunctions = new List<Func<string, int>>
        {
            s => s.GetHashCode(),           // built-in hash code
            s => s.Length * 17              // a simple secondary hash based on string length
        };

        int bitArraySize = 1000;  // Size of the bit array
        BloomFilter bloomFilter = new BloomFilter(bitArraySize, hashFunctions);

        // Insert a large number of elements.
        int totalInserted = 200;
        for (int i = 0; i < totalInserted; i++) {
            bloomFilter.Add("element_" + i);
        }

        // Test membership for elements that were NOT inserted.
        int totalTests = 300;
        int falsePositiveCount = 0;
        for (int i = totalInserted; i < totalInserted + totalTests; i++) {
            if (bloomFilter.Query("element_" + i)) {
                falsePositiveCount++;
            }
        }

        // Calculate empirical false positive rate.
        double empiricalFalsePositiveRate = falsePositiveCount / (double)totalTests;

        Console.WriteLine("Inserted elements: " + totalInserted);
        Console.WriteLine("Tested absent elements: " + totalTests);
        Console.WriteLine("False positives found: " + falsePositiveCount);
        Console.WriteLine("Empirical false positive rate: " + empiricalFalsePositiveRate);

        // Compute the theoretical false positive probability.
        int k = hashFunctions.Count;
        double theoreticalFalsePositiveRate = Math.Pow(1 - Math.Exp(-k * (double)totalInserted / bitArraySize), k);
        Console.WriteLine("Theoretical false positive rate: " + theoreticalFalsePositiveRate);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
