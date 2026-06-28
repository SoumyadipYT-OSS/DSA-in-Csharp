using System;
using System.Collections.Generic;
using static System.Console;


class _03_BinarySearch 
{
    static void Main() 
    {
        List<int> numbers = new List<int> { 10, 30, 40, 60 };

        int index = numbers.BinarySearch(30);

        if (index >= 0)
            WriteLine($"Found 30 at index: {index}");
        else
            WriteLine($"30 not found.");

        int missingIndex = numbers.BinarySearch(25);
        WriteLine($"Result for 25: {missingIndex}");
    }
}