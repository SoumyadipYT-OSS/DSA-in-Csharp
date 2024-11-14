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

        // Create a fixed-size wrapper around the ArrayList
        ArrayList fixedSizeList = ArrayList.FixedSize(myList);

        // Display elements of the fixed-size ArrayList
        Console.WriteLine("Elements in the fixed-size ArrayList:");
        foreach (var item in fixedSizeList) {
            Console.WriteLine(item);
        }

        // Try to modify an element in the fixed-size ArrayList
        fixedSizeList[1] = 20;
        Console.WriteLine("\nAfter modifying, elements in the fixed-size ArrayList:");
        foreach (var item in fixedSizeList) {
            Console.WriteLine(item);
        }

        // Try to add a new element to the fixed-size ArrayList (will throw exception)
        try {
            fixedSizeList.Add(4);
        } catch (NotSupportedException ex) {
            Console.WriteLine("\nException caught: Cannot add elements to a fixed-size ArrayList" + ex);
        }
    }
}
