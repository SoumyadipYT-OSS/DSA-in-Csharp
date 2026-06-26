# Dictionary Properties in C#

This file demonstrates the main properties of the `Dictionary<TKey,TValue>` data structure with short code examples.

---

## 🗂 Capacity
Represents the number of elements the dictionary can hold before resizing.

```csharp
var dict = new Dictionary<string, int>(50); // initial capacity
Console.WriteLine($"Capacity: {dict.Capacity}");
```

⚖️ Comparer
Gets the equality comparer used to determine key equality.
```csharp
var dict = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
Console.WriteLine($"Comparer: {dict.Comparer}");
```

🔢 Count
Gets the number of key/value pairs contained in the dictionary.
```csharp
var dict = new Dictionary<string, int>
{
    ["apple"] = 1,
    ["banana"] = 2
};
Console.WriteLine($"Count: {dict.Count}"); // 2
```

📌 Item[]
Indexer to get or set the value associated with a specified key.
```csharp
var dict = new Dictionary<string, int>();
dict["apple"] = 10; // add via indexer
Console.WriteLine($"Apple => {dict["apple"]}");
```

🔑 Keys
Gets a collection containing the keys in the dictionary.
```csharp
var dict = new Dictionary<string, int>
{
    ["apple"] = 1,
    ["banana"] = 2
};
foreach (var key in dict.Keys)
{
    Console.WriteLine($"Key: {key}");
}
```

📦 Values
Gets a collection containing the values in the dictionary.
```csharp
var dict = new Dictionary<string, int>
{
    ["apple"] = 1,
    ["banana"] = 2
};
foreach (var value in dict.Values)
{
    Console.WriteLine($"Value: {value}");
}
```


### ⚡ Quick takeaway
- **Capacity** → memory allocation detail (not core DSA, but good to know).  
- **Comparer** → defines how keys are compared (important for uniqueness).  
- **Count** → tells you how many elements are stored.  
- **Item[]** → the indexer, core for insert/update.  
- **Keys** and **Values** → let you iterate over just the keys or just the values.  

