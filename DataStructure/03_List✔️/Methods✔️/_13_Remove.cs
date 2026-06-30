using System;
using System.Collections.Generic;
using static System.Console;


class _13_Remove 
{
    static void Main() 
    {
        List<string> cities = new List<string> { "New Delhi", "London", "Jaipur", "Noida" };

        cities.Remove("London");

        WriteLine(string.Join(", ", cities));
    }
}