using System;
using System.Collections.Generic;


class Program {
    static void Main() {
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Dates" };


        fruits.RemoveAt(1);


        Console.WriteLine("List after removing element at index 1:");
        foreach (string i in fruits) {
            Console.Write(i + "\t");
        }
    }
}