/*

    # Array.SetValue Method in C# 12

    ## Overview
    The `Array.SetValue` method in C# 12 is used to set a value to a specific element in 
    a one-dimensional or multidimensional array. This method is part of the `System` namespace 
    and is essential for manipulating array elements.
 
*/
using System;

class Program {
    protected static void Overload1() {
        Console.WriteLine("SetValue(Object, Int32)");
        int[] num = new int[5];
        num.SetValue(42, 2);
        Console.WriteLine(num[2]);
        for (short i=0; i<num.Length; i++) {
            Console.Write(num[i] + " ");
        }
    }

    protected static void Overload2() {
        Console.WriteLine("SetValue(Object, Int32[])");
        int[,] matrix = new int[3, 3];  // 2D array
        matrix.SetValue(42, new int[] { 1, 2 });
        Console.WriteLine(matrix[1, 2]);
    }

    protected static void Overload3() {
        Console.WriteLine("SetValue(Object, Int64[]");
        int[,] matrix = new int[3, 3];
        matrix.SetValue(42, new long[] { 1, 2 });
        Console.WriteLine(matrix[1, 2]);
    }

    protected static void Overload4() {
        Console.WriteLine("SetValue(Object, Int32, Int32");
        int[,] matrix = new int[3, 3];
        matrix.SetValue(42, 1, 2);
        Console.WriteLine(matrix[1, 2]);
    }

    protected static void Overload5() {
        Console.WriteLine("SetValue(object, Int64, Int64)");
        int[,] matrix = new int[3, 3];
        matrix.SetValue(42, 1L, 2L);
        Console.WriteLine(matrix[1, 2]);
    }

    protected static void Overload6() {
        Console.WriteLine("SetValue(Object, Int32, Int32, Int32)");
        int[,,] cube = new int[3, 3, 3];
        cube.SetValue(42, 1, 2, 2);
        Console.WriteLine(cube[1, 2, 2]);
    }

    protected static void Overload7() {
        Console.WriteLine("SetValue(Object, Int64, Int64, Int64)");
        int[,,] cube = new int[3, 3, 3];
        cube.SetValue(42, 1L, 2L, 2L);
        Console.WriteLine(cube[1, 2, 2]);
    }

    protected static void Overload8() {
        Console.WriteLine("SetValue(Object, Int64)");
        int[] num = new int[5];
        num.SetValue(42, 2L);
        Console.WriteLine(num[2]);
    }



    // Main method
    static void Main() {
        Console.WriteLine("__Overload 1__");
        Overload1();
        Console.WriteLine("__Overload 2__");
        Overload2();
        Console.WriteLine("__Overload 3__");
        Overload3();
        Console.WriteLine("__Overload 4__");
        Overload4();
        Console.WriteLine("__Overload 5__");
        Overload5();
        Console.WriteLine("__Overload 6__");
        Overload6();
        Console.WriteLine("__Overload 7__");
        Overload7();
        Console.WriteLine("__Overload 8__");
        Overload8();
    }
}