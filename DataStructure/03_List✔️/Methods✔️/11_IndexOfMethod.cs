using System;
using System.Collections.Generic;


class Progarm {
    static void Main() {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };


        int index = numbers.IndexOf(30);

        if (index != -1) {
            Console.WriteLine($"The first occurrence of 30 is at index: {index}");
        } else {
            Console.WriteLine("30 is not in the list.");
        }
    }
}