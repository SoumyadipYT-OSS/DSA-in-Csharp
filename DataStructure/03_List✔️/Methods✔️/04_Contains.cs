using System;
using System.Collections.Generic;


class Program {
    static void Main() {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };


        int searchItem = 3;

        if (numbers.Contains(searchItem)) {
            Console.WriteLine($"{searchItem} is in the list.");
        } else {
            Console.WriteLine($"{searchItem} is not in the list.");
        }
    }
}