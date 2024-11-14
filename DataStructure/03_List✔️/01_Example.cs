using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        // Create a new List of integers
        List<int> numbers = new List<int>();

        // Add elements to the list
        numbers.Add(5);
        numbers.Add(3);
        numbers.Add(8);
        numbers.Add(1);
        numbers.Add(2);

        // Display the initial list
        Console.WriteLine("Initial list:");
        foreach (int number in numbers) {
            Console.WriteLine(number);
        }

        // Sort the list
        numbers.Sort();

        // Display the sorted list
        Console.WriteLine("\nSorted list:");
        foreach (int number in numbers) {
            Console.WriteLine(number);
        }

        // Remove an element from the list
        numbers.Remove(3);

        // Display the list after removal
        Console.WriteLine("\nList after removing 3:");
        foreach (int number in numbers) {
            Console.WriteLine(number);
        }

        // Check if a specific element exists in the list
        bool containsFive = numbers.Contains(5);
        Console.WriteLine("\nList contains 5: " + containsFive);

        // Get the count of elements in the list
        int count = numbers.Count;
        Console.WriteLine("\nNumber of elements in the list: " + count);
    }
}