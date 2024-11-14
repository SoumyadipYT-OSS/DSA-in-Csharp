using System;
using System.Collections.Generic;


class Program {
    private static void displayList<T>(List<T> l) {
        foreach (T i in l) {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }


    // 1. List<T>()
    protected static void Example1() {
        List<string> dinosaurs = new List<string>();

        Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);

        // adding some dinosaurs names
        dinosaurs.Add("Tyrannosaurus");
        dinosaurs.Add("Amargasaurus");
        dinosaurs.Add("Mamenchisaurus");
        dinosaurs.Add("Deinonychus");
        dinosaurs.Add("Compsognathus");
        Console.WriteLine();

        displayList(dinosaurs);


        Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);
        Console.WriteLine("Count: {0}", dinosaurs.Count);

        Console.WriteLine("\nContains(\"Deinonychus\": {0}", dinosaurs.Contains("Deinonychus"));

        Console.WriteLine("\nInsert(2, \"Compsognathus\")");
        dinosaurs.Insert(2, "Compsognathus");

        Console.WriteLine();
        displayList(dinosaurs);


        dinosaurs.TrimExcess();
        Console.WriteLine("\nTrimExcess()");
        Console.WriteLine("Capacity: {0}", dinosaurs.Capacity);
        Console.WriteLine("Count: {0}", dinosaurs.Count);

        dinosaurs.Clear();
        Console.WriteLine("\nTrimExcess()");
        Console.WriteLine("Capacity: {0}", dinosaurs.Capacity);
        Console.WriteLine("Count: {0}", dinosaurs.Count);

        dinosaurs.Clear();
        Console.WriteLine("\nClear()");
        Console.WriteLine("Capacity: {0}", dinosaurs.Capacity);
        Console.WriteLine("Count: {0}", dinosaurs.Count);
    }



    static void Main() {
        Example1();
    }
}