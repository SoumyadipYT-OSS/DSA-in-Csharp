using System;
using System.Collections;


class Program {
    private static void displayArrayList(ArrayList al) {
        foreach (object i in al) {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }


    static void Main() {
        ArrayList myAl = new ArrayList { "Apple", "Banana", "Cherry", "Pomegranate" };

        ArrayList newElements = new ArrayList { "Dates", "Elderberry", "Guava" };

        Console.WriteLine("Initial ArrayList:");
        displayArrayList(myAl);

        // Set the range of elements in myAl starting at index 1
        myAl.SetRange(1, newElements);

        // Display the ArrayList after setting the range
        Console.WriteLine("\nArrayList after SetRange:");
        displayArrayList(myAl);
    }
}