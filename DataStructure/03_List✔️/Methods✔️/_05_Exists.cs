using System;
using System.Collections.Generic;
using static System.Console;


class _05_Exists 
{
    static void Main() 
    {
        List<int> integerList = new List<int> { 10, 20, 30, 40 };

        bool hasGreaterThan25 = integerList.Exists(n => n > 25);
        bool hasNegativeNumber = integerList.Exists(n => n < 0);

        WriteLine($"Integer List contains greater than 25 values? {hasGreaterThan25}");
        WriteLine($"Integer List contains negative values? {hasNegativeNumber}");
    }
}