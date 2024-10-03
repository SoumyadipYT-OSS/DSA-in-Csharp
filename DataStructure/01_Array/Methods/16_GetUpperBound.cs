using System;

class Program {
    static void Main() {
        // Create a one-dimensional array
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Get the lower bound of the array
        int upperBound = numbers.GetUpperBound(0);  // 0 is the dimension of the array, in the parentheses

        // Display the lower bound
        Console.WriteLine($"The upper bound of the array is: {upperBound}");

        // Create a two-dimensional array
        int[,] matrix = new int[3, 4]
        {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

        // Get the lower bounds of the two-dimensional array
        int upperBound0 = matrix.GetUpperBound(0);
        int upperBound1 = matrix.GetUpperBound(1);

        // Display the lower bounds
        Console.WriteLine($"The upper bound of the first dimension is: {upperBound0}");
        Console.WriteLine($"The upper bound of the second dimension is: {upperBound1}");
    }
}