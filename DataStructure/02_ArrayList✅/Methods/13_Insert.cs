using System;
using System.Collections;

class Program {
    protected static void PrintArrayList(ArrayList al) {
        Console.WriteLine("ArrayList:");
        foreach (object i in al) {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }


    static void Main() {
        ArrayList myAL = new ArrayList();

        myAL.Insert(0, "Hey");
        myAL.Insert(1, "C#");
        myAL.Insert(2, "Developer");

        PrintArrayList(myAL);
    }
}