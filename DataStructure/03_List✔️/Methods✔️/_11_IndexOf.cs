using System;
using System.Collections.Generic;
using static System.Console;

class _11_IndexOf 
{
    static void Main() 
    {
        List<string> cities = new List<string> { "Kolkata", "New Delhi", "Bangalore", "Mumbai", "Siliguri", "Pune", "Kolkata", "Chennai" };

        int firstIndex = cities.IndexOf("Kolkata");
        int notFound = cities.IndexOf("Gurugram");

        WriteLine($"First Index of Kolkata: {firstIndex}");
        WriteLine($"Index of Gurugram: {notFound}");
    }
}