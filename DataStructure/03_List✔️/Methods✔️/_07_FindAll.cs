using System;
using System.Collections.Generic;
using static System.Console;


class _07_FindAll 
{
    static void Main() 
    {
        List<string> countries = new List<string> { "Singapore", "India", "Russia", "Finland", "France" };

        List<string> longCountryNames = countries.FindAll(x => x.Length > 6);

        WriteLine("Country names more than 6 characters");
        foreach (var lcn in longCountryNames)
            Write($"{lcn} ");
        WriteLine();
    }
}