using System;
using System.Collections.Generic;


class Program 
{
    static void Main() 
    {
        Example1();
    }


    protected static void Example1() 
    {
        Dictionary<string, string> wordDictionary = new();

        wordDictionary["Algorithm"] = "A step-by-step procedure for solving problems.";
        wordDictionary["Compiler"] = "A program that translates source code to machine code";
        wordDictionary["Encapsulation"] = "The bundling of data with the methods that operate on that data";

        Console.WriteLine("Dictionary contents:\n");
        foreach (KeyValuePair<string, string> entry in wordDictionary)
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        Console.WriteLine();
    }
}