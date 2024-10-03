using System;

class Program {
    static void Main() {
        // Create a one-dimensional array
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Get the lower bound of the array
        int lowerBound = numbers.GetLowerBound(0);  // 0 is the dimension of the array, in the parentheses

        // Display the lower bound
        Console.WriteLine($"The lower bound of the array is: {lowerBound}");

        // Create a two-dimensional array
        int[,] matrix = new int[3, 4]
        {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

        // Get the lower bounds of the two-dimensional array
        int lowerBound0 = matrix.GetLowerBound(0);
        int lowerBound1 = matrix.GetLowerBound(1);

        // Display the lower bounds
        Console.WriteLine($"The lower bound of the first dimension is: {lowerBound0}");
        Console.WriteLine($"The lower bound of the second dimension is: {lowerBound1}");
    }
}