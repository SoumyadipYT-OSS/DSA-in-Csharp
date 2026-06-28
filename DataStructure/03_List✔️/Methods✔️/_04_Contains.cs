using System;
using System.Collections.Generic;
using static System.Console;

class _04_Contains 
{
    static void Main() 
    {
        List<string> programmingLanguages = new List<string>();

        string[] details = { "C#", "C++", "Python", "Rust", "GoLang", "TypeScript" };
        programmingLanguages.AddRange(details);

        bool hasCSharp = programmingLanguages.Contains("C#");
        bool hasPython = programmingLanguages.Contains("Python");

        WriteLine($"List contains C#: {hasCSharp}");
        WriteLine($"List contains Python: {hasPython}");
    }
}