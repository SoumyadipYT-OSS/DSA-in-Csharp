using System;
using System.Collections.Generic;


class Program {
    private static void displayElements<T>(List<T> list) {
        foreach (T i in list) {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }


    static void Main() {
        List<string> fruits = new List<string>();

        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Cherry");

        displayElements(fruits);

        fruits.Add("Dates");
        Console.WriteLine("\nAfter adding another fruit:");

        foreach (string fruit in fruits) {
            Console.WriteLine(fruit);
        }
    }
}