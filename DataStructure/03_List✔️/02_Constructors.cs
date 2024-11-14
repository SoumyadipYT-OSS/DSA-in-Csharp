using System;
using System.Collections.Generic;


class Program {
    private static void displayList<T>(List<T> l) {
        foreach (T item in l) {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }


    static void Main() {
        // 1. List<T> [Default Constructor]
        List<int> defaultList = new List<int>();
        defaultList.Add(15);
        defaultList.Add(22);
        Console.WriteLine("Default Constructor List:");
        displayList(defaultList);

        // 2. IEnumerable<T> Constructor
        List<int> collection = new List<int> { 30, 40, 50 };
        List<int> collectionList = new List<int>(collection);
        Console.WriteLine("\nIEnumerable<T> Constructor List:");
        displayList(collectionList);

        // 3. Capacity Constructor
        List<int> capacityList = new List<int>(5);
        capacityList.Add(85);
        capacityList.Add(88);
        Console.WriteLine("\nCapacity Constructor List:");
        displayList(capacityList);
    }
}
