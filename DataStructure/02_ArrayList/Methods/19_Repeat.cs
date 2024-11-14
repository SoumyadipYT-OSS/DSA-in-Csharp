/*

    Method: ArrayList.Repeat
    The ArrayList.Repeat method is a bit of a misnomer because there isn’t 
    an ArrayList.Repeat method directly in the ArrayList class in C#. However, 
    you can create an ArrayList that repeats a specific value a certain number 
    of times using a different approach.
 
*/


using System;
using System.Collections;
public class SamplesArrayList {

    public static void Main() {

        // Creates a new ArrayList with five elements and initialize each element with a null value.
        ArrayList myAL = ArrayList.Repeat(null, 5);

        // Displays the count, capacity and values of the ArrayList.
        Console.WriteLine("ArrayList with five elements with a null value");
        Console.WriteLine("   Count    : {0}", myAL.Count);
        Console.WriteLine("   Capacity : {0}", myAL.Capacity);
        Console.Write("   Values:");
        PrintValues(myAL);

        // Creates a new ArrayList with seven elements and initialize each element with the string "abc".
        myAL = ArrayList.Repeat("abc", 7);

        // Displays the count, capacity and values of the ArrayList.
        Console.WriteLine("ArrayList with seven elements with a string value");
        Console.WriteLine("   Count    : {0}", myAL.Count);
        Console.WriteLine("   Capacity : {0}", myAL.Capacity);
        Console.Write("   Values:");
        PrintValues(myAL);
    }

    public static void PrintValues(IEnumerable myList) {
        foreach (Object obj in myList)
            Console.Write("   {0}", obj);
        Console.WriteLine();
    }
}

/*
This code produces the following output.

ArrayList with five elements with a null value
   Count    : 5
   Capacity : 16
   Values:
ArrayList with seven elements with a string value
   Count    : 7
   Capacity : 16
   Values:   abc   abc   abc   abc   abc   abc   abc

*/