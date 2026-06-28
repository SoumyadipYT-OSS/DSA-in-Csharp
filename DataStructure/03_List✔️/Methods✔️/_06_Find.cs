using System;
using System.Collections.Generic;
using static System.Console;

class _06_Find 
{
    static void Main() 
    {
        List<string> cities = new List<string> { "New Delhi", "Kolkata", "Mumbai", "Chennai" };

        string? foundCity = cities.Find(val => val == "Kolkata");

        if (foundCity != null)
            Console.WriteLine("Kolkata exists in the list");
        else
            Console.WriteLine("Kolkata not found");
    }
}