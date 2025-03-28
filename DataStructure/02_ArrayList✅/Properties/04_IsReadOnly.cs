using System;
using System.Collections;

class SamplesArrayList {
    static void Main() {
        ArrayList myAL = new ArrayList();
        myAL.Add("red");
        myAL.Add("orange");
        myAL.Add("yellow");

        // Creates a read-only copy of the ArrayList.
        ArrayList myReadOnlyAL = ArrayList.ReadOnly(myAL);

        // Displays whether the ArrayList is read-only or writable.
        Console.WriteLine("myAL is {0}.", myAL.IsReadOnly ? "read-only" : "writable");
        Console.WriteLine("myReadOnlyAL is {0}.", myReadOnlyAL.IsReadOnly ? "read-only" : "writable");

        // Displays the contents of both collections.
        Console.WriteLine("\nInitially,");
        Console.WriteLine("The original ArrayList myAL contains:");
        foreach (string myStr in myAL)
            Console.WriteLine("   {0}", myStr);
        Console.WriteLine("The read-only ArrayList myReadOnlyAL contains:");
        foreach (string myStr in myReadOnlyAL)
            Console.WriteLine("   {0}", myStr);

        // Adding an element to a read-only ArrayList throws an exception.
        Console.WriteLine("\nTrying to add a new element to the read-only ArrayList:");
        try {
            myReadOnlyAL.Add("green");
        } catch (Exception myException) {
            Console.WriteLine("Exception: " + myException.ToString());
        }

        // Adding an element to the original ArrayList affects the read-only ArrayList.
        myAL.Add("blue");

        // Displays the contents of both collections again.
        Console.WriteLine("\nAfter adding a new element to the original ArrayList,");
        Console.WriteLine("The original ArrayList myAL contains:");
        foreach (string myStr in myAL)
            Console.WriteLine("   {0}", myStr);
        Console.WriteLine("The read-only ArrayList myReadOnlyAL contains:");
        foreach (string myStr in myReadOnlyAL)
            Console.WriteLine("   {0}", myStr);
    }
}
