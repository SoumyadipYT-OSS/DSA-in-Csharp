/*
    Method: ArrayList.TrimToSize
    The ArrayList.TrimToSize method is used to set the capacity 
    of an ArrayList to the actual number of elements it contains, 
    minimizing memory overhead.
*/



using System;
using System.Collections;

class Program {
    static void Main() {
        // Create a new ArrayList with an initial capacity
        ArrayList myList = new ArrayList(10);

        // Add some elements to the ArrayList
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);

        // Display the initial capacity of the ArrayList
        Console.WriteLine("Initial capacity: " + myList.Capacity);

        // Trim the ArrayList to its actual size
        myList.TrimToSize();

        // Display the capacity after trimming
        Console.WriteLine("Capacity after TrimToSize: " + myList.Capacity);
    }
}