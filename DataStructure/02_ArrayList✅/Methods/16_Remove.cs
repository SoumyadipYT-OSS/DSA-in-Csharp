using System;
using System.Collections;


class Program {
    private static void displayArrayList(ArrayList al) {
        foreach (object i in al) {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    protected static void Example1() {
        ArrayList myAl = new ArrayList();

        myAl.Add("Apple");
        myAl.Add("Banana");
        myAl.Add("Cherry");
        myAl.Add("Date");

        displayArrayList(myAl);

        // Remove an element
        myAl.Remove("Banana");

        Console.WriteLine("\nArrayList after removing 'Banana':");
        displayArrayList(myAl);
    }

    protected static void Example2() {
        ArrayList mixedList = new ArrayList();
        mixedList.Add(1);
        mixedList.Add("Hey C# developer");
        mixedList.Add(3.14f);
        mixedList.Add(true);
        mixedList.Add(456.236);

        displayArrayList(mixedList);

        // Remove an element
        mixedList.Remove(456.236);

        Console.WriteLine("\nAfter removing the element, updated ArrayList:");
        displayArrayList(mixedList);
    }


    static void Main() {
        Example1();
        Example2();
    }
}