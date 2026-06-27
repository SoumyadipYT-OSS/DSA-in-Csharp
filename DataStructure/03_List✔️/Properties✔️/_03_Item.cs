using System;
using System.Collections.Generic;
using static System.Console;


class _03_Item
{
    static void Main() {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        WriteLine("Element at index 0: " + numbers[0]);
        WriteLine("Element at index 2: " + numbers[2]);


        numbers[1] = 25;
        WriteLine("Element at index 1 after setting it from 20 to 25 retrive data:" + numbers[1] + "\n");


        Console.WriteLine("All elements in the list:");
        for (int i=0; i<numbers.Count; i++) {
            WriteLine($"Element at index {i}: {numbers[i]}");
        }
    }
}