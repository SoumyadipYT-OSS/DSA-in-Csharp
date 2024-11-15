using System;
using System.Collections.Generic;


class Program {
    static void Main() {
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };

        fruits.Insert(1, "Mango");

        Console.WriteLine("Updated list");
        foreach (string i in fruits) {
            Console.Write(i + " ");
        }
    }
}