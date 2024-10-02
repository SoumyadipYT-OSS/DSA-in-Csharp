using System;

class Example {
    private static bool EndsWithSaurus(string s) {
        if ((s.Length > 5) && (s.Substring(s.Length - 6).ToLower() == "saurus")) {
            return true;
        } else {
            return false;
        }
    }


    // main method
    static int Main(string[] args) {
        string[] dinosaurs = { "Compsognathus",
            "Amargasaurus",   "Oviraptor",      "Velociraptor",
            "Deinonychus",    "Dilophosaurus",  "Gallimimus",
            "Triceratops" };

        Console.WriteLine();
        foreach (string d in dinosaurs) Console.Write(d + "  ");

        // Array.FindIndex<T>(T[], Predicate<T>)
        Console.WriteLine("\n\nArray.FindIndex(dinosaurs, EndsWithSaurus): {0}",
            Array.FindIndex(dinosaurs, EndsWithSaurus));

        // Array.FindIndex<T>(T[], Int32, Predicate<T>)
        Console.WriteLine("\nArray.FindIndex(dinosaurs, 2, EndsWithSaurus): {0}",
        Array.FindIndex(dinosaurs, 2, EndsWithSaurus));

        // Array.FindIndex<T>(T[], Int32, Int32, Predicate<T>)
        Console.WriteLine("\nArray.FindIndex(dinosaurs, 2, 3, EndsWithSaurus): {0}",
            Array.FindIndex(dinosaurs, 2, 3, EndsWithSaurus));
        return 0;
    }
}