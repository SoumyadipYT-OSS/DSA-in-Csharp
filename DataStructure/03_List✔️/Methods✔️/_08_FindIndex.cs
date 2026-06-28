using System;
using System.Collections.Generic;
using static System.Console;

class _08_FindIndex 
{
    static void Main() 
    {
        List<string> programmingLanguages = new List<string> { "C#", "Python", "C++", "TypeScript", "GoLang", "Rust" };

        int index = programmingLanguages.FindIndex(x => x == "C#");

        WriteLine($"Index: {index}");
        WriteLine($"Value at that index: {programmingLanguages[index]}");
    }
}