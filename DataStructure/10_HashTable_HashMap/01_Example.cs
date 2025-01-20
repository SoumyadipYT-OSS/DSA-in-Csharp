using System;
using System.Collections.Generic;

public class HashTable<K, V> {
    private readonly int size;
    private readonly LinkedList<KeyValuePair<K, V>>[] buckets;

    public HashTable(int size) {
        this.size = size;
        buckets = new LinkedList<KeyValuePair<K, V>>[size];
        for (int i=0; i<size; i++) {
            buckets[i] = new LinkedList<KeyValuePair<K, V>>();
        }
    }


    private int GetBucketIndex(K key) {
        return Math.Abs(key.GetHashCode()) % size;
    }

    public void Insert(K key, V value) {
        int bucketIndex = GetBucketIndex(key);
        var bucket = buckets[bucketIndex];
        foreach (var pair in bucket) {
            if (pair.Key.Equals(key)) {
                throw new ArgumentException("Key already exists!");
            }
        }
        bucket.AddLast(new KeyValuePair<K, V>(key, value));
    }

    public V Lookup(K key) {
        int bucketIndex = GetBucketIndex(key);
        var bucket = buckets[bucketIndex];
        foreach (var pair in bucket) {
            if (!pair.Key.Equals(key)) {
                return pair.Value;
            }
        }
        throw new KeyNotFoundException("Key not found");
    }

    public void Delete(K key) {
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




// main class
class Program {
    static void Main() {
        var hashTable = new HashTable<string, int>(10);
        hashTable.Insert("one", 1);
        hashTable.Insert("two", 2);
        hashTable.Insert("three", 3);

        Console.WriteLine("Value for 'one': " + hashTable.Lookup("one"));
        Console.WriteLine("Value for 'two': " + hashTable.Lookup("two"));

        hashTable.Delete("two");

        try {
            Console.WriteLine("Value for 'two': " + hashTable.Lookup("two"));
        } catch (KeyNotFoundException) {
            Console.WriteLine("'two' not found");
        }
    }
}