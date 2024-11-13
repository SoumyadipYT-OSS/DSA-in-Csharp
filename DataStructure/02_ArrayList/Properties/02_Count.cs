using System;
using System.Collections;

class Program {
    protected static void countArrayList(ArrayList arrAl) {
        Console.Write("Elements of ArrayList:  ");
        foreach (var i in arrAl) {
            Console.Write(i + ", ");
        }
        Console.WriteLine("\nCounting the elements in the ArrayList: " + arrAl.Count);
        Console.WriteLine();
    }

    // Main method
    static void Main() {
        ArrayList myList = new ArrayList();

        myList.Add(25);
        myList.Add("C#");
        myList.Add(".NET Aspire");
        myList.Add(44.68);
        countArrayList(myList);

        myList.Add(9.8f);
        countArrayList(myList);
    }
}
