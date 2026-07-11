# HashMap Data Structure in C#

## 📖 Overview
In C#, the equivalent of Java's **HashMap** or Python's **dict** is the **`Dictionary<TKey, TValue>`** class in the `System.Collections.Generic` namespace.  
It is a collection of **key–value pairs** optimized for fast lookups using hashing.

---

## 🔎 Key Features
- **Generic:** Type-safe (`Dictionary<int, string>`).
- **Unique Keys:** Each key must be unique; values can repeat.
- **Fast Operations:** Average **O(1)** for insert, lookup, and delete.
- **Unordered:** Elements are not stored in insertion order.
- **Modern Choice:** Preferred over legacy `Hashtable` (non-generic, slower).

---

## ⚡ Syntax
```csharp
Dictionary<TKey, TValue> dict = new Dictionary<TKey, TValue>();
```

---

## Example
```csharp
using System;
using System.Collections.Generic;

class DemoDictionary
{
    static void Main()
    {
        // Create dictionary
        Dictionary<string, string> capitals = new Dictionary<string, string>();

        // Add key-value pairs
        capitals["India"] = "New Delhi";
        capitals["Singapore"] = "Singapore";
        capitals["Russia"] = "Moscow";

        // Access value by key
        Console.WriteLine("Capital of India: " + capitals["India"]);

        // Check if key exists
        if (capitals.ContainsKey("Russia"))
        {
            Console.WriteLine("Russia is present in dictionary.");
        }

        // Iterate through dictionary
        foreach (var kvp in capitals)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}
```

---


## 🔧 Common Operations

Below are the most frequently used operations with `Dictionary<TKey, TValue>` in C#:

| Operation                | Example Code                          | Complexity | Notes |
|---------------------------|---------------------------------------|------------|-------|
| **Add key-value pair**    | `dict.Add("India", "New Delhi");`     | O(1) avg   | Throws exception if key already exists. |
| **Insert / Update value** | `dict["USA"] = "Washington DC";`      | O(1) avg   | Adds if key doesn’t exist, updates if it does. |
| **Access value by key**   | `var capital = dict["UK"];`           | O(1) avg   | Throws exception if key not found. |
| **Safe access**           | `dict.TryGetValue("UK", out var val);`| O(1) avg   | Returns `false` if key not found, avoids exception. |
| **Check key existence**   | `dict.ContainsKey("USA")`             | O(1) avg   | Useful before accessing values. |
| **Remove key-value pair** | `dict.Remove("India");`               | O(1) avg   | Returns `true` if removal succeeded. |
| **Iterate over dictionary** | `foreach (var kvp in dict) { ... }` | O(n)       | Iterates through all key-value pairs. |
| **Count elements**        | `dict.Count`                          | O(1)       | Returns number of key-value pairs. |
| **Clear dictionary**      | `dict.Clear();`                       | O(n)       | Removes all entries. |

---
