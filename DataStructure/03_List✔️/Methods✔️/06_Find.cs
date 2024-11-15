using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Define a condition (predicate) to find the first element greater than 3
        Predicate<int> condition = x => x > 3;

        // Use Find method to get the first element matching the condition
        int result = numbers.Find(condition);

        if (result != 0) {
            Console.WriteLine($"The first element greater than 3 is: {result}");
        } else {
            Console.WriteLine("No element greater than 3 found.");
        }
    }
}