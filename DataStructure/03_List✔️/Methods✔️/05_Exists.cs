using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Define a condition (predicate) to check if an element is greater than 3
        Predicate<int> condition = x => x > 3;

        // Check if any element in the list matches the condition
        if (numbers.Exists(condition)) {
            Console.WriteLine("There is an element in the list greater than 3.");
        } else {
            Console.WriteLine("No elements in the list are greater than 3.");
        }
    }
}