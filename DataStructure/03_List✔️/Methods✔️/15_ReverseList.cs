using System;
using System.Collections.Generic;

class Example {
    static void Main() {
        List<string> dinosaurs = new List<string>();

        dinosaurs.Add("Pachycephalosaurus");
        dinosaurs.Add("Parasauralophus");
        dinosaurs.Add("Mamenchisaurus");
        dinosaurs.Add("Amargasaurus");
        dinosaurs.Add("Coelophysis");
        dinosaurs.Add("Oviraptor");


        Console.WriteLine();
        foreach (string d in dinosaurs)
            Console.Write(d + ", ");
        Console.WriteLine();


        // Reverse built-in method for List
        dinosaurs.Reverse();

        foreach (string d in dinosaurs)
            Console.Write(d + ", ");
        Console.WriteLine();


        // Reverse with a ranged elements
        dinosaurs.Reverse(1, 4);

        foreach (string d in dinosaurs)
            Console.Write(d + ", ");
    }
}