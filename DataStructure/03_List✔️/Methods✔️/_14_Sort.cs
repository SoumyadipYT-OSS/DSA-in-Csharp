using System;
using System.Collections.Generic;
using static System.Console;


class _14_Sort 
{
    static void Main() 
    {
        List<int> intNumbers = new List<int> { 5, 1, 8, 2, 3 };

        intNumbers.Sort();

        WriteLine(string.Join(", ", intNumbers));
    }
}