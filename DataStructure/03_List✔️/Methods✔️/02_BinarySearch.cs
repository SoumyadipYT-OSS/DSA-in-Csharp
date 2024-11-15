using System;
using System.Collections.Generic;

/*  
    Important!
    For BinarySearch the List, ArrayList, Array should be in sorted form.
*/

class Program {
    private static void displayList<T>(List<T> list) {
        foreach (T i in list) {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    private static bool IsSorted<T>(List<T> list) where T : IComparable<T> {
        for (int i=1; i<list.Count; i++) {
            if (list[i].CompareTo(list[i-1]) < 0) {
                return false;
            }
        }
        return true;
    }


    static void Main() {
        List<int> IntegerList = new List<int> { 5, 2, 3, 1, 4 };
        displayList(IntegerList);
        if (IsSorted(IntegerList)) {
            Console.WriteLine("The list is sorted");
        } else {
            Console.WriteLine("List is not sorted. Sorting...");
            IntegerList.Sort();
            Console.WriteLine("Sorted!");
        }
        displayList(IntegerList);


        Console.WriteLine("\nBinary Search");
        int index = IntegerList.BinarySearch(4);
        if (index >= 0) {
            Console.WriteLine($"The value 4 Found at index: {index}");
        } else {
            Console.WriteLine("Not found!");
        }
    }
}