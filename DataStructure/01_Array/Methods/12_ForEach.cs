/*
    Array.ForEach<T>(T[], Action<T>) Method

    public static void ForEach<T> (T[] array, Action<T> action);
*/

using System;

class Example {
    // Main method
    static int Main() {
        int[] myArr = new int[] { 2, 3, 4 };
        Action<int> action = new Action<int>(ShowSquares);
        Array.ForEach(myArr, action);

        return 0;
    }

    private static void ShowSquares(int val) {
        Console.WriteLine("{0:d} squared = {1:d}", val, val*val);
    }
}