using System;
using System.Collections.Generic;

class Example {
    static void Main() {
        string[] input = { 
            "Brachiosaurus",
            "Amargasaurus",
            "Mamenchisaurus"
        };

        List<string> dinosaurus = new List<string>(input);

        Console.WriteLine("\nCapacity: {0}", dinosaurus.Capacity);

        Console.WriteLine();
        foreach (string d in dinosaurus)
            Console.WriteLine(d + ", ");

        Console.WriteLine("\nAddRange(dinosaurus)");
        dinosaurus.AddRange(dinosaurus);

        Console.WriteLine();
        foreach (string d in dinosaurus)
            Console.Write(d + ", ");


        Console.WriteLine("\nRemoveRange(2, 2)");
        dinosaurus.RemoveRange(2, 2);

        Console.WriteLine();
        foreach (string d in dinosaurus)
            Console.WriteLine(d + ", ");



        input = new string[] {
            "Tyrannosaurus",
            "Deinonychus",
            "Velociraptor"
        };

        Console.WriteLine("\nInsertRange(3, input");
        dinosaurus.InsertRange(3, input);

        Console.WriteLine();
        foreach (string d in dinosaurus)
            Console.Write(d + ", ");


        Console.WriteLine("\noutput = dinosaurus.GetRange(2, 3).ToArray()");
        string[] output = dinosaurus.GetRange(2, 3).ToArray();

        Console.WriteLine();
        foreach (string d in dinosaurus)
            Console.WriteLine(d + ", ");
    }
}