using System;
using static System.Console;
using System.Collections.Generic;


class Program 
{
    static void Main() 
    {
        Dictionary<string, string> capitals = new Dictionary<string, string>();

        // Add key-value pairs
        capitals["India"] = "New Delhi";
        capitals["Singapore"] = "Singapore";
        capitals["Denmark"] = "Copenhagen";

        foreach (var kvp in capitals)
            WriteLine($"Capital of {kvp.Key} => {kvp.Value}");
    }
}