/*

    Method: ArrayList.LastIndexOf
    The ArrayList.LastIndexOf method is used to find the 
    index of the last occurrence of a specific object in 
    the ArrayList.
 
*/



using System;
using System.Collections;

class Program {
    // 1. LastIndexOf(Object): Finds the last occurrence of a specific object.
    protected static void Example1() {
        ArrayList myAl = new ArrayList { 10, 20, 30, 20, 40, 20 };

        int lastIndex = myAl.LastIndexOf(20);
        Console.WriteLine("Last index of 20: " + lastIndex);
    }

    // 2. LastIndexOf(Object, Int32): Finds the last occurrence of a specific object before a given index.
    protected static void Example2() {
        ArrayList myAl = new ArrayList { 10, 20, 30, 20, 40, 20 };

        int lastIndex = myAl.LastIndexOf(20, 3);
        Console.WriteLine("Last index of 20 before index 3: " + lastIndex);
    }

    // 3. LastIndexOf(Object, Int32, Int32): Finds the last occurrence of a specific object within a given range.
    protected static void Example3() {
        ArrayList myAl = new ArrayList { 10, 20, 30, 20, 40, 20 };

        int lastIndex = myAl.LastIndexOf(20, 4, 4);
        Console.WriteLine("Last index of 20 within the range 1 to 4: " + lastIndex);
    }



    static void Main() {
        Console.WriteLine("Example 1:");
        Example1();

        Console.WriteLine("Example 2:");
        Example2();

        Console.WriteLine("Example 3:");
        Example3();
    }
}