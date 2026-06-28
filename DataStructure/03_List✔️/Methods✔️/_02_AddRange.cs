using System;
using System.Collections.Generic;
using static System.Console;


class _02_AddRange() 
{
    static void Main() 
    {
        List<int> integerList = new List<int>();

        int[] moreNumbers = { 3, 4, 5 };

        integerList.AddRange(moreNumbers);

        WriteLine(string.Join(", ", integerList));
    }
}