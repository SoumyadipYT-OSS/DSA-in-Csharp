using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Define a condition (predicate) to find the index of the first element greater than 3
        Predicate<int> condition = x => x > 3;

        // Use FindIndex method to get the index of the first element matching the condition
        int index = numbers.FindIndex(condition);

        if (index != -1) {
            Console.WriteLine($"The first element greater than 3 is at index: {index}");
        } else {
            Console.WriteLine("No element greater than 3 found.");
        }
    }
}