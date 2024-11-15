using System;
using System.Collections.Generic;


class Program {
    static void Main() {
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date" };

        Console.WriteLine("The number of fruits in the list: " + fruits.Count);

        fruits.Add("Elderberry");
        Console.WriteLine("Added Elderberry");

        Console.WriteLine("The updated number of fruits in the list: " + fruits.Count);
    }
}