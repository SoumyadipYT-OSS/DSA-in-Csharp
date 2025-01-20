using System;
using System.Collections.Generic;

public class SimpleHashMap {
    private readonly int size;
    private readonly LinkedList<KeyValuePair<string, int>>[] buckets;

    public SimpleHashMap(int size) {
        this.size = size;
        buckets = new LinkedList<KeyValuePair<string, int>>[size];
        for (int i = 0; i < size; i++) {
            buckets[i] = new LinkedList<KeyValuePair<string, int>>();
        }
    }


    private int GetBucketIndex(string key) {
        return Math.Abs(key.GetHashCode()) % size;
    }

    public void Insert(string key, int value) {
        int bucketIndex = GetBucketIndex(key);
        var bucket = buckets[bucketIndex];
        foreach (var pair in bucket) {
            if (pair.Key.Equals(key)) {
                throw new ArgumentException("Key already exists");
            }
        }
        bucket.AddLast(new KeyValuePair<string, int>(key, value));
    }

    public int Lookup(string key) {
        int bucketIndex = GetBucketIndex(key);
        var bucket = buckets[bucketIndex];
        foreach (var pair in bucket) {
            if (pair.Key.Equals(key)) {
                return pair.Value;
            }
        }
        throw new KeyNotFoundException("Key not found");
    }

    public void Delete(string key) {
        int bucketIndex = GetBucketIndex(key);
        var bucket = buckets[bucketIndex];
        var node = bucket.First;
        while (node != null) {
            if (node.Value.Key.Equals(key)) {
                bucket.Remove(node);
                return;
            }
            node = node.Next;
        }
        throw new KeyNotFoundException("Key not found");
    }
}




// main program
public class Program {
    public static void Main() {
        var hashMap = new SimpleHashMap(10);
        hashMap.Insert("apple", 1);
        hashMap.Insert("banana", 2);
        hashMap.Insert("cherry", 3);

        Console.WriteLine("Value for 'apple': " + hashMap.Lookup("apple"));
        Console.WriteLine("Value for 'banana': " + hashMap.Lookup("banana"));

        hashMap.Delete("banana");

        try {
            Console.WriteLine("Value for 'banana': " + hashMap.Lookup("banana"));
        } catch (KeyNotFoundException) {
            Console.WriteLine("'banana' not found");
        }
    }
}