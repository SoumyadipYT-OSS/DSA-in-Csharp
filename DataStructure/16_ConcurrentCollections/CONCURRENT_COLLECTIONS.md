# Concurrent Collections in .NET

## Table of Contents
1. [Introduction](#introduction)
2. [Overview of Concurrent Collections](#overview-of-concurrent-collections)
3. [ConcurrentDictionary](#concurrentdictionary)
4. [ConcurrentQueue](#concurrentqueue)
5. [ConcurrentStack](#concurrentstack)
6. [ConcurrentBag](#concurrentbag)
7. [BlockingCollection](#blockingcollection)
8. [Conclusion](#conclusion)
9. [References](#references)

---

## Introduction
Concurrent collections are data structures provided by the .NET framework to support safe and efficient data access in multi-threaded scenarios. Housed in the `System.Collections.Concurrent` namespace, these collections allow multiple threads to add, update, and remove items without explicit locks, improving simplicity and performance in concurrent applications.

---

## Overview of Concurrent Collections
.NET offers various concurrent collections to serve different needs:
- **ConcurrentDictionary<TKey, TValue>** – A thread-safe dictionary for key/value pairs.
- **ConcurrentQueue<T>** – A first-in-first-out (FIFO) collection.
- **ConcurrentStack<T>** – A last-in-first-out (LIFO) collection.
- **ConcurrentBag<T>** – An unordered, thread-safe collection.
- **BlockingCollection<T>** – Provides blocking and bounding functionality, ideal for producer-consumer scenarios.

These collections handle synchronization internally, which reduces the chance of race conditions and improves performance for concurrent operations.

---

## ConcurrentDictionary
`ConcurrentDictionary<TKey, TValue>` is a thread-safe dictionary that provides methods like `TryAdd`, `TryUpdate`, `TryRemove`, and `TryGetValue`—all without needing external locks.

### Example:
```csharp
using System;
using System.Collections.Concurrent;

public class Program
{
    public static void Main()
    {
        // Create a ConcurrentDictionary
        ConcurrentDictionary<int, string> dict = new ConcurrentDictionary<int, string>();

        // Adding elements using TryAdd.
        dict.TryAdd(1, "One");
        dict.TryAdd(2, "Two");
        dict.TryAdd(3, "Three");

        // Updating an element.
        dict[2] = "Two Updated";

        // Removing an element.
        if(dict.TryRemove(3, out string removedValue))
        {
            Console.WriteLine("Removed key 3 with value: " + removedValue);
        }

        // Retrieving an element.
        if(dict.TryGetValue(1, out string value))
        {
            Console.WriteLine("Key 1 has value: " + value);
        }

        // Enumerating through the dictionary.
        Console.WriteLine("Elements in ConcurrentDictionary:");
        foreach (var kvp in dict)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
```


## Conclusion
.NET’s concurrent collections enable safe, efficient, and scalable multi-threaded 
programming without the need to manually implement locking mechanisms. They simplify 
the development of thread-safe applications while ensuring high performance in 
concurrent scenarios.


## References
- [Microsoft Docs - Concurrent Collections](https://docs.microsoft.com/en-us/dotnet/standard/collections/concurrent/)
- [Concurrent Collections in .NET](https://docs.microsoft.com/en-us/dotnet/standard/collections/concurrent/)
- [Thread-Safe Collections in .NET](https://docs.microsoft.com/en-us/dotnet/standard/collections/thread-safe/)