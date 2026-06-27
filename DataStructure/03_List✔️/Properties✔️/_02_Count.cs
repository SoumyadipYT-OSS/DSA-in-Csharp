using System;
using System.Collections.Generic;
using static System.Console;


class _02_Count 
{
    static void Main() {
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date" };

        WriteLine("The number of fruits in the list: " + fruits.Count);

        fruits.Add("Elderberry");
        WriteLine("Added Elderberry");

        WriteLine("The updated number of fruits in the list: " + fruits.Count);
    }
}