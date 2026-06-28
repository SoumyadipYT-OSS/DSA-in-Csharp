using System;
using System.Collections.Generic;
using static System.Console;

class _09_FindLast 
{
    static void Main() 
    {
        List<int> numbers = new List<int> { 12, 16, 10, 20, 22 };

        int findLastValue = numbers.FindLast(y => y > 20);
        bool isLastValueGreaterThanTwenty = findLastValue > 20;

        WriteLine($"{isLastValueGreaterThanTwenty}");
        WriteLine($"{findLastValue}");
    }
}