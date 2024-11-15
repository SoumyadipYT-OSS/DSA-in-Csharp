using System;
using System.Collections.Generic;

class Program {
    private static void displayList<T>(List<T> list) {
        foreach (T i in list) {
            Console.Write(i + "\t");
        }
        Console.WriteLine();
    }


    static void Main() {
        List<object> mixedList = new List<object> { 12, "C#", "Developer!", 563.22, 13.66f };
        displayList(mixedList);

        mixedList.Add('C');

        Console.WriteLine("\nNew item added in the list");
        displayList(mixedList);
    }
}