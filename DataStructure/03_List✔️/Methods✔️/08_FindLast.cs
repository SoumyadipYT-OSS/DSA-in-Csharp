using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 3, 2, 1 };

        // Define a condition (predicate) to find the last element greater than 3
        Predicate<int> condition = x => x > 3;

        // Use FindLast method to get the last element matching the condition
        int result = numbers.FindLast(condition);

        if (result != 0) {
            Console.WriteLine($"The last element greater than 3 is: {result}");
        } else {
            Console.WriteLine("No element greater than 3 found.");
        }
    }
}