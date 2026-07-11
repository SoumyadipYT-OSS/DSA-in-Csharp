# Hashtable Data Structure in C#

## 📖 Overview
A **Hashtable** in C# is a collection of key–value pairs that are organized based on the hash code of the key.  
It is part of the **System.Collections** namespace and was introduced before generics.  
Although it is now considered **legacy** (replaced by `Dictionary<TKey, TValue>`), it is still useful for understanding the evolution of hash-based collections in .NET.

---

## 🔎 Key Features
- **Non-generic:** Stores keys and values as `object`.
- **Unique Keys:** Each key must be unique.
- **Mixed Types:** Keys and values can be of different types.
- **Performance:** Average **O(1)** for insert, lookup, and delete.
- **Unordered:** Elements are not stored in insertion order.
- **Legacy:** Superseded by `Dictionary<TKey, TValue>` in modern C#.

---

## ⚡ Syntax
```csharp
Hashtable table = new Hashtable();
```

---

## Example
```csharp
using System;
using System.Collections;

class HTExample
{
    static void Main()
    {
        Hashtable table = new Hashtable();

        // Add key-value pairs
        table["Motherboard"] = "Gigabyte";
        table["Model"] = "B450";
        table[1] = 'v';              // int key, char value
        table["SubId"] = "123XYZ";
        table["Price"] = 6599.99;    // double value

        // Access value by key
        Console.WriteLine("Model: " + table["Model"]);

        // Check if key exists
        if (table.ContainsKey("Price"))
        {
            Console.WriteLine("Price key exists.");
        }

        // Iterate through hashtable
        foreach (DictionaryEntry entry in table)
        {
            Console.WriteLine($"{entry.Key} -> {entry.Value}");
        }
    }
}
```

---

## 🔧 Common Operations (Hashtable)

Below are the most frequently used operations with `Hashtable` in C#:

| Operation                | Example Code                          | Complexity | Notes |
|---------------------------|---------------------------------------|------------|-------|
| **Add key-value pair**    | `table["Key"] = "Value";`             | O(1) avg   | Adds or updates value for the key. |
| **Access value by key**   | `var val = table["Key"];`             | O(1) avg   | Returns `null` if key not found. |
| **Check key existence**   | `table.ContainsKey("Key")`            | O(1) avg   | Useful before accessing values. |
| **Remove key-value pair** | `table.Remove("Key");`                | O(1) avg   | Removes entry if key exists. |
| **Iterate over entries**  | `foreach (DictionaryEntry e in table)`| O(n)       | Iterates through all entries. |
| **Count elements**        | `table.Count`                         | O(1)       | Returns number of entries. |
| **Clear hashtable**       | `table.Clear();`                      | O(n)       | Removes all entries. |

---

## 🆚 Hashtable vs Dictionary

| Feature        | Hashtable                  | Dictionary<TKey, TValue> |
|----------------|----------------------------|---------------------------|
| **Type Safety**| ❌ Non-generic (stores `object`) | ✅ Generic, type-safe |
| **Performance**| ⚠️ Slower (boxing/unboxing overhead) | ✅ Faster (no boxing) |
| **Modern Usage**| ⚠️ Legacy, rarely used today | ✅ Recommended for new code |
| **Introduced** | .NET 1.0                   | .NET 2.0 (Generics)       |
| **Iteration**  | `foreach (DictionaryEntry e in table)` | `foreach (var kvp in dict)` |
| **Flexibility**| Allows mixed key/value types | Enforces consistent key/value types |

---

### ✅ Summary
- **Hashtable** is the older, non-generic hash-based collection in C#.  
- It is **conceptually DSA-relevant** for learning hashing, but **not recommended** for modern applications.  
- Use **`Dictionary<TKey, TValue>`** instead for type safety, performance, and cleaner code.

---
