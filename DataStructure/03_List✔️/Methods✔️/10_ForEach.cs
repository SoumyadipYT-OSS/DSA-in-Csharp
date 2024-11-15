using System;
using System.Collections.Generic;


class Program {
    static void Main() {
        List<string> fruits = new List<string>();
        fruits.Add("Apple");
        fruits.Add("Orange");
        fruits.Add("Pomegranate");
        fruits.Add("Kiwi");


        fruits.ForEach(Print);  // Display the contents of the list using the Print method.


        fruits.ForEach(delegate (string name) {
            Console.WriteLine(name);
        });


        void Print(string s) {
            Console.WriteLine(s);
        }
    }
}