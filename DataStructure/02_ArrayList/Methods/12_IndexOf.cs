/*
    Method: IndexOf
*/



using System;
using System.Collections;

class Program {

    // IndexOf(Object): Finds the index of the first occurrence of a specific object.
    protected static void Example1() {
        ArrayList myList = new ArrayList { 10, 20, 30, 40, 50 };

        // Find the index of the first occurrence of 30
        int index = myList.IndexOf(30);
        Console.WriteLine("Index of 30: " + index);
    }

    // IndexOf(Object, Int32): Finds the index of the first occurrence of a specific object starting from a specified index.
    protected static void Example2() {
        ArrayList myList = new ArrayList { 10, 20, 30, 40, 30, 50 }; 
        
        // Find the index of the first occurrence of 30 starting from index 3
        int index = myList.IndexOf(30, 3); 
        Console.WriteLine("Index of 30 starting from index 3: " + index);
    }

    // IndexOf(Object, Int32, Int32): Finds the index of the first occurrence of a specific object within a specified range.
    protected static void Example3() {
        ArrayList myList = new ArrayList { 10, 20, 30, 40, 30, 50, 30 }; 
        
        // Find the index of the first occurrence of 30 within the range 2 to 5
        int index = myList.IndexOf(30, 2, 4); 
        Console.WriteLine("Index of 30 within the range 2 to 5: " + index);
    }


    static void Main() {
        Console.WriteLine("Example 1:");
        Example1();

        Console.WriteLine("\nExample 2:");
        Example2();

        Console.WriteLine("\nExample 3:");
        Example3();
    }
}