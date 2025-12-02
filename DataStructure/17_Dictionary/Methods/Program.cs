
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var dict = new Dictionary<int, string>();

        // Add
        dict.Add(1, "One");
        dict.Add(2, "Two");

        PrintDictionary(dict);

        // ContainsKey
        Console.WriteLine($"Contains key 1? {dict.ContainsKey(1)}");

        // ContainsValue
        Console.WriteLine($"Contains value 'Two'? {dict.ContainsValue("Two")}");

        // TryAdd
        bool added = dict.TryAdd(3, "Three");
        Console.WriteLine($"TryAdd key 3: {added}");

        // TryGetValue
        if (dict.TryGetValue(2, out string value))
            Console.WriteLine($"TryGetValue for key 2: {value}");

        // EnsureCapacity
        int ensuredCapacity = dict.EnsureCapacity(10);
        Console.WriteLine($"Capacity ensured: {ensuredCapacity}");

        // GetEnumerator
        Console.WriteLine("Enumerating dictionary");
        var enumerator = dict.GetEnumerator();
        while (enumerator.MoveNext())
            Console.WriteLine($"Key={enumerator.Current.Key}, Value={enumerator.Current.Value}");

        // Remove
        dict.Remove(1);
        Console.WriteLine("Removed key 1");

        // TrimExcess
        dict.TrimExcess();
        Console.WriteLine("Trimmed excess capacity");

        // Clear
        dict.Clear();
        Console.WriteLine("Dictionary cleared");
    }


    protected static void PrintDictionary(Dictionary<int, string> dictionary)
    {
        foreach(var kvp in dictionary)
            Console.WriteLine($"{kvp.Key} : {kvp.Value}");
    }
}