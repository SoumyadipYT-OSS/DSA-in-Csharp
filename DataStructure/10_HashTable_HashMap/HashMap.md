# Hash Table / Hash Map

A **Hash Table** (or **Hash Map**) is a data structure that provides fast insertion, deletion, and lookup operations. It uses a hash function to compute an index into an array of buckets or slots, from which the desired value can be found.

## Key Concepts

1. **Hash Function:** A function that converts a given key into an index in the hash table. A good hash function minimizes collisions (when two keys hash to the same index).
2. **Buckets:** Each index in the hash table array is called a bucket. Each bucket can store multiple key-value pairs in case of collisions.
3. **Collision Resolution:** Techniques to handle collisions include chaining (using linked lists) and open addressing (finding another open slot within the hash table).

## Operations

1. **Insertion:** Add a key-value pair to the hash table.
2. **Deletion:** Remove a key-value pair from the hash table.
3. **Lookup:** Retrieve the value associated with a given key.

## Example Implementation in C#

Here's a simple implementation of a hash table in C# using chaining for collision resolution:

```csharp
using System;
using System.Collections.Generic;

public class HashTable<K, V>
{
    private readonly int size;
    private readonly LinkedList<KeyValuePair<K, V>>[] buckets;

    public HashTable(int size)
    {
        this.size = size;
        buckets = new LinkedList<KeyValuePair<K, V>>[size];
        for (int i = 0; i < size; i++)
        {
            buckets[i] = new LinkedList<KeyValuePair<K, V>>();
        }
    }

    private int GetBucketIndex(K key)
    {
        return Math.Abs(key.GetHashCode()) % size;
    }

    public void Insert(K key, V value)
    {
        int bucketIndex = GetBucketIndex(key);
        var bucket = buckets[bucketIndex];
        foreach (var pair in bucket)
        {
            if (pair.Key.Equals(key))
            {
                throw new ArgumentException("Key already exists");
            }
        }
        bucket.AddLast(new KeyValuePair<K, V>(key, value));
    }

    public V Lookup(K key)
    {
        int bucketIndex = GetBucketIndex(key);
        var bucket = buckets[bucketIndex];
        foreach (var pair in bucket)
        {
            if (pair.Key.Equals(key))
            {
                return pair.Value;
            }
        }
        throw new KeyNotFoundException("Key not found");
    }

    public void Delete(K key)
    {
        int bucketIndex = GetBucketIndex(key);
        var bucket = buckets[bucketIndex];
        var node = bucket.First;
        while (node != null)
        {
            if (node.Value.Key.Equals(key))
            {
                bucket.Remove(node);
                return;
            }
            node = node.Next;
        }
        throw new KeyNotFoundException("Key not found");
    }
}
```


### Real-World Applications
*• Databases:* Hash tables are used in databases to index data. They allow for fast retrieval of records 
               by mapping keys (such as user IDs) to their corresponding data.

*• Caching:* Hash tables are used in caching mechanisms to store and quickly retrieve frequently accessed 
             data. For example, web browsers use hash tables to cache web pages and resources.

*• Symbol Tables in Compilers:* Compilers use hash tables to store information about variables, functions, 
                                and other symbols in a program. This allows for efficient lookup and management 
                                of these symbols during the compilation process.

*• Dictionaries:* In dictionaries, hash table concepts are used.

*• Routing Tables in Networks:* Hash tables are used in networking to store routing information. They help 
                                in quickly determining the next hop for a packet based on its destination 
                                address.

*• File Systems:* Some file systems use hash tables to manage file metadata, such as file names and their 
                  corresponding locations on disk. This allows for efficient file lookup and management.

*• Cryptographic Applications:* Hash tables are used in cryptographic applications to store and quickly 
                                retrieve cryptographic keys and other sensitive information.