using System;
using System.Collections.Generic;


class Program {
    private static void displayList<T>(List<T> list) {
        foreach (T i in list) {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }



    static void Main() {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine("Original List:");
        displayList(numbers);

        numbers.Clear();    // Clear method;

        if (numbers.Count == 0)
            Console.WriteLine("The list is now empty");
    }
}