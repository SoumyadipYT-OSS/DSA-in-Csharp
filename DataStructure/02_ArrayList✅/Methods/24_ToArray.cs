/*
    Method: ArrayList.ToArray
    Certainly! The ArrayList.ToArray method is used to create an array 
    containing all the elements in the ArrayList. 
    This method can return an array of type Object[] by default or you can 
    specify the type of array you want.
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

        // Convert the ArrayList to an array of type Object[]
        object[] array = myList.ToArray();

        // Display the elements of the array
        Console.WriteLine("Elements in the Object array:");
        foreach (var item in array) {
            Console.Write(item + " ");
        }

        // Convert the ArrayList to an array of a specific type (int[])
        int[] intArray = (int[])myList.ToArray(typeof(int));

        // Display the elements of the int array
        Console.WriteLine("\nElements in the int array:");
        foreach (var item in intArray) {
            Console.Write(item + " ");
        }
    }
}