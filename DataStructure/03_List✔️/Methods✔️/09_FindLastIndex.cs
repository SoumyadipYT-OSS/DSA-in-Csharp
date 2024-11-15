using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 3, 2, 1 };

        // Define a condition (predicate) to find the index of the last element greater than 3
        Predicate<int> condition = x => x > 3;

        // Use FindLastIndex method to get the index of the last element matching the condition
        int lastIndex = numbers.FindLastIndex(condition);

        if (lastIndex != -1) {
            Console.WriteLine($"The last element greater than 3 is at index: {lastIndex}");
        } else {
            Console.WriteLine("No element greater than 3 found.");
        }
    }
}