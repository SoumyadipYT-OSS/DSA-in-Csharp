using System;
using System.Collections.Generic;


class Program {
    static void Main() {
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };


        fruits.Remove("Banana");

        Console.WriteLine("List after removal:");
        foreach (string i in fruits)
            Console.Write(i + " ");
    }
}