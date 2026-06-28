using System;
using System.Collections.Generic;
using static System.Console;

class _12_Insert 
{
    static void Main() 
    {
        List<string> cities = new List<string> { "Siliguri", "Bardwan", "Pune", "Vizag", "Mangalore", "Noida", "Hooghly", "Asansol" };

        cities.Insert(1, "Mohali");

        WriteLine(string.Join(", ", cities));
    }
}