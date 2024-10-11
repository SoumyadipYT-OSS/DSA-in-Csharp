using System;
using System.Collections;

class Program {
    private static void PrintKeysAndValues(string[] myKeys, string[] myValues) {
        for (int i=0; i<myKeys.Length; i++) {
            Console.WriteLine("\t {0 - 10}: {1}", myKeys[i], myValues[i]);
        }
        Console.WriteLine();
    }

    protected class myReverserClass : IComparer {
        int IComparer.Compare(object x, object y) {
            return ( (new CaseInsensitiveComparer()).Compare(y, x) );
        }
    }


    // Main method
    static void Main(string[] args) {
        // Creates and initializes a new Array and a new custom comparer.
        String[] myKeys = { "red", "GREEN", "YELLOW", "BLUE", "purple", "black", "orange" };
        String[] myValues = { "strawberries", "PEARS", "LIMES", "BERRIES", "grapes", "olives", "cantaloupe" };
        IComparer myComparer = new myReverserClass();

        // Displays the values of the Array.
        Console.WriteLine("The Array initially contains the following values:");
        PrintKeysAndValues(myKeys, myValues);

        // Sorts a section of the Array using the default comparer.
        Array.Sort(myKeys, myValues, 1, 3);
        Console.WriteLine("After sorting a section of the Array using the default comparer:");
        PrintKeysAndValues(myKeys, myValues);

        // Sorts a section of the Array using the reverse case-insensitive comparer.
        Array.Sort(myKeys, myValues, 1, 3, myComparer);
        Console.WriteLine("After sorting a section of the Array using the reverse case-insensitive comparer:");
        PrintKeysAndValues(myKeys, myValues);

        // Sorts the entire Array using the default comparer.
        Array.Sort(myKeys, myValues);
        Console.WriteLine("After sorting the entire Array using the default comparer:");
        PrintKeysAndValues(myKeys, myValues);

        // Sorts the entire Array using the reverse case-insensitive comparer.
        Array.Sort(myKeys, myValues, myComparer);
        Console.WriteLine("After sorting the entire Array using the reverse case-insensitive comparer:");
        PrintKeysAndValues(myKeys, myValues);
    }
}