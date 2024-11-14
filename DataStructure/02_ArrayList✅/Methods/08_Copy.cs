/*
 
    Method: ArrayList.Copy
    ArrayList to a one-dimensional array. Here's a simple C# 12 
    program that demonstrates how to use the Copy method.
 
*/


using System;
using System.Collections;

class Program {
    static void Main() {
        // Create a new ArrayList
        ArrayList myList = new ArrayList();

        // Add some elements to the ArrayList
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);

        // Create an array to copy the elements into
        int[] myArray = new int[myList.Count];

        // Copy elements from ArrayList to the array
        myList.CopyTo(myArray);

        // Display elements of the array
        Console.WriteLine("Elements in the array:");
        foreach (var item in myArray) {
            Console.WriteLine(item);
        }
    }
}