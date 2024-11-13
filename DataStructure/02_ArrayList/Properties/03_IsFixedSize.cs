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

        // Check if the ArrayList has a fixed size
        bool isFixedSize = myList.IsFixedSize;
        Console.WriteLine("Is the ArrayList fixed size? " + isFixedSize);

        // Try to add another element to the ArrayList
        myList.Add(4);
        Console.WriteLine("After adding one more element, the number of elements in the ArrayList is: " + myList.Count);
    }
}
