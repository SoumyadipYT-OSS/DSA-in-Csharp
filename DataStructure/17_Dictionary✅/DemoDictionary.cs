using System;
using static System.Console;
using System.Collections.Generic;

class DemoDictionary 
{
    static void Main()
    {
        Dictionary<string, int> demoDictionary = new Dictionary<string, int>();

        demoDictionary.Add("First Page", 01);
        demoDictionary.Add("Second Page", 02);
        demoDictionary.Add("Third Page", 03);
        demoDictionary.Add("Fourth Page", 04);
        demoDictionary.Add("Fift Page", 05);

        WriteLine(demoDictionary);
        WriteLine("Print Key Value pair of dictionary");
        foreach(KeyValuePair<string, int> kvp in demoDictionary) 
        {
            WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        try
        {
            demoDictionary.Add("Fourth Page", 4);       // throws an exception because TKey exists
        } catch (ArgumentException ex) 
        {
            WriteLine($"An element with key \"Fourth Page\" already exists {ex.Message}");
        }
    }
}