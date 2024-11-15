using System;
using System.Collections.Generic;


class Program {
    static void Main() {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        Console.WriteLine("Element at index 0: " + numbers[0]);
        Console.WriteLine("Element at index 2: " + numbers[2]);


        numbers[1] = 25;
        Console.WriteLine("Element at index 1 after setting it to 25:" + numbers[1]);


        Console.WriteLine("All elements in the list:");
        for (int i=0; i<numbers.Count; i++) {
            Console.WriteLine($"Element at index {i}: {numbers[i]}");
        }
    }
}