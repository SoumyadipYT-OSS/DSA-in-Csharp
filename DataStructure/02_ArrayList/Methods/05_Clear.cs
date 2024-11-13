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

        // Display the initial number of elements
        Console.WriteLine("The number of elements in the ArrayList is: " + myList.Count);

        // Clear the ArrayList
        myList.Clear();

        // Display the number of elements after clearing
        Console.WriteLine("After clearing, the number of elements in the ArrayList is: " + myList.Count);
    }
}
