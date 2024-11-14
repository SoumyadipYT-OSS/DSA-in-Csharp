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
        ArrayList myAl = new ArrayList();

        myAl.Add("Apple");
        myAl.Add("Banana");
        myAl.Add("Cherry");
        myAl.Add("Dates");
        myAl.Add("Dates");

        Console.WriteLine("Initial ArrayList:");
        displayArrayList(myAl);

        myAl.Remove("Banana");

        Console.WriteLine("\nArrayList after removing 'Banana':");
        displayArrayList(myAl);

        myAl.Sort();

        Console.WriteLine("Sorted ArrayList");
        displayArrayList(myAl);
    }
}