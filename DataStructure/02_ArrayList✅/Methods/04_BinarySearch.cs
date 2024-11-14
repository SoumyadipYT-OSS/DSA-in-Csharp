/*

    Methods: ArrayList.BinarySearch
    Uses a binary search algorithm to locate a specific 
    element in the sorted ArrayList or a portion of it.   
 
*/

using System;
using System.Collections;

class Sample {
    protected static void PrintValues(IEnumerable myList) {
        foreach (object obj in myList) {
            Console.Write("\t{0}", obj);
        }
        Console.WriteLine();
    }

    protected static void FindMyObject(ArrayList myList, object myObject) {
        int myIndex = myList.BinarySearch(myObject);
        if (myIndex < 0)
            Console.WriteLine("The object to search for ({0}) is not found. The next larger object is at index {1}.", myObject, ~myIndex);
        else
            Console.WriteLine("The object to search for ({0}) is at index {1}.", myObject, myIndex);
    }

    
    static void Main() {
        ArrayList myAl = new ArrayList();

        // For BinarySearch we need sorted ArrayList or sorted Array.
        for (int i=0; i<=4; i++) {
            myAl.Add(i * 2);
        }

        Console.WriteLine("The int ArrayList contains the following:");
        PrintValues(myAl);

        object myObjectOdd = 3;
        FindMyObject(myAl, myObjectOdd);

        object myObjectEven = 6;
        FindMyObject(myAl, myObjectEven);
    }
}