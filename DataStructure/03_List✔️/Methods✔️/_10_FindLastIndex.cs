using System;
using System.Collections.Generic;
using static System.Console;

class _10_FindLastIndex 
{
    static void Main() 
    {
        List<string> cities = new List<string> { "New Delhi", "Noida", "London", "Moscow", "Singapore" };

        // Find the last index of a city name longer than 8 characters
        int lastIndex = cities.FindLastIndex(n => n.Length > 8);

        Console.WriteLine($"Last city with > 8 letters is at index: {lastIndex}");
        Console.WriteLine($"City name: {cities[lastIndex]}");
    }
}