/*
    ArrayList.Capacity 
    Gets or sets the number of elements that the 
    ArrayList can contain.
*/

using System;
using System.Collections;

class Program {
    protected static void printArrayList(ArrayList arrAl) {
        Console.Write("Elements in the ArrayList -> ");
        foreach (var item in arrAl) {
            Console.Write(item + ", ");
        }
        Console.WriteLine("\nCapacity of the ArrayList: " + arrAl.Capacity);
        Console.WriteLine();
    }

    // Main method
    static void Main() {
        ArrayList myAL = new ArrayList();
        Console.WriteLine("Initial Capacity: " +  myAL.Capacity);

        myAL.Add(10);
        printArrayList(myAL);

        myAL.Add(56);
        printArrayList(myAL);

        myAL.Add(144);
        printArrayList(myAL);

        myAL.Add(12);
        printArrayList(myAL);

        myAL.Add("C#");
        printArrayList(myAL);

        myAL.Add(".NET is fun!");
        printArrayList(myAL);

        myAL.Add(25 + 65);
        printArrayList(myAL);

        myAL.Add('A');
        printArrayList(myAL);

        myAL.Add(455.887);
        printArrayList(myAL);

        myAL.Add("Visual Studio");
        printArrayList(myAL);
    }
}
