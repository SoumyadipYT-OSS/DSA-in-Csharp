using System;
using System.Collections.Generic;


public class Example
{
    static void Main()
    {
        Dictionary<string, int> hashmap = new Dictionary<string, int>();

        hashmap.Add("Lava", 1);
        hashmap.Add("HCL", 2);
        hashmap.Add("Micromax", 3);

        Console.WriteLine("Value for 'Lava': " + hashmap["Lava"]);
        Console.WriteLine("Value for 'HCL': " + hashmap["HCL"]);
        Console.WriteLine("Value for Micromax: " + hashmap["Micromax"]);


        if (hashmap.ContainsKey("date"))
        {
            Console.WriteLine("Value for 'date': " + hashmap["date"]);
        } else
        {
            Console.WriteLine("'date' is not in the dictionary.");
        }


        hashmap.Remove("HCL");


        Console.WriteLine("Updated dictionary:");
        foreach (var kvp in hashmap)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}