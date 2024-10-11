using System;

class Program {
    // Main Method
    static void Main() {
        int[,] matrix = new int[3, 4] {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

        // Get no. of rows (dimension 0)
        int rows = matrix.GetLength(0);
        // Get no. of columns (dimension 1)
        int columns = matrix.GetLength(1);

        // Display the dimensions
        Console.WriteLine($"Number of rows: {rows}");
        Console.WriteLine($"Number of columns: {columns}");

        // Display the elements of the array
        Console.WriteLine("Elements of the array: ");
        for (int i=0; i<rows; i++) {
            for (int j=0; j<columns; j++) {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}