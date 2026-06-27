using System;
using System.Collections.Generic;
using static System.Console;


class ConstructorExamples 
{
    static void Main() 
    {
        // 1. Default Constructor: empty list
        List<int> list1 = new List<int>();
        WriteLine($"List count: {list1.Count}");
        WriteLine($"List capacity: {list1.Capacity}");

        WriteLine();

        // 2. Constructor with capacity: preallocate space
        List<int> list2 = new List<int>(10);
        WriteLine($"List count: {list2.Count}");
        WriteLine($"List capacity: {list2.Capacity}");

        WriteLine();

        // 3. Constructor with collectioin: initialization from array
        int[] arr = { 1, 2, 3, 4 };
        List<int> list3 = new List<int>(arr);
        WriteLine($"List count: {list3.Count}");
        WriteLine($"List capacity: {list3.Capacity}");

        foreach (var n in list3)
            Write($"{n} ");
        WriteLine();
    }
}