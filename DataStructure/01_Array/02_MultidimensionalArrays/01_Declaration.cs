using System;

class Program {
    public void TwoDimensionalArray() {
        // declaration of 2D array
        int[,] multiArr1 = new int[2, 3];   // 2 rows and 3 columns without initialization
        int[,] multiArr2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };  // 2 rows and 3 columns with initialization
        int[,] multiArr3 = { { 1, 2, 3 }, { 4, 5, 6 } };  // 2 rows and 3 columns with initialization

        Console.WriteLine("2D Array 1");
        for (int i = 0; i < multiArr1.GetLength(0); i++) {
            for (int j = 0; j < multiArr1.GetLength(1); j++) {
                Console.Write(multiArr1[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("2D Array 2");
        for (int i = 0; i < multiArr2.GetLength(0); i++) {
            for (int j = 0; j < multiArr2.GetLength(1); j++) {
                Console.Write(multiArr2[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("2D Array 3");
        for (int i = 0; i < multiArr3.GetLength(0); i++) {
            for (int j = 0; j < multiArr3.GetLength(1); j++) {
                Console.Write(multiArr3[i, j] + " ");
            }
            Console.WriteLine();
        }
    }


    public void ThreeDimensionalArray() {
        // declaration of 3D array
        int[,,] multiArr1 = new int[2, 3, 4];   // 2 rows, 3 columns and 4 depth without initialization
        int[,,] multiArr2 = new int[2, 3, 4] { { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } }, { { 13, 14, 15, 16 }, { 17, 18, 19, 20 }, { 21, 22, 23, 24 } } };  // 2 rows, 3 columns and 4 depth with initialization
        int[,,] multiArr3 = { { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } }, { { 13, 14, 15, 16 }, { 17, 18, 19, 20 }, { 21, 22, 23, 24 } } };  // 2 rows, 3 columns and 4 depth with initialization

        Console.WriteLine("3D Array 1");
        for (int i = 0; i < multiArr1.GetLength(0); i++) {
            for (int j = 0; j < multiArr1.GetLength(1); j++) {
                for (int k = 0; k < multiArr1.GetLength(2); k++) {
                    Console.Write(multiArr1[i, j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        Console.WriteLine("3D Array 2");
        for (int i = 0; i < multiArr2.GetLength(0); i++) {
            for (int j = 0; j < multiArr2.GetLength(1); j++) {
                for (int k = 0; k < multiArr2.GetLength(2); k++) {
                    Console.Write(multiArr2[i, j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        Console.WriteLine("3D Array 3");
        for (int i = 0; i < multiArr3.GetLength(0); i++) {
            for (int j = 0; j < multiArr3.GetLength(1); j++) {
                for (int k = 0; k < multiArr3.GetLength(2); k++) {
                    Console.Write(multiArr3[i, j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
}


    // main method
    static void Main(string[] args) {
        Console.WriteLine("----Multidimensional Arrays----");
        Console.WriteLine("1. Two Dimensional Array");
        Program twoDimension = new Program();
        twoDimension.TwoDimensionalArray();

        Console.WriteLine("\n\n\n2. Three Dimensional Array");
        Program threeDimension = new Program();
        threeDimension.ThreeDimensionalArray();
    }
}