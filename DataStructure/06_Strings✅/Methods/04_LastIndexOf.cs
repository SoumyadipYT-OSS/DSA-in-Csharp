using System;

/* LastIndexOf: Finds the index of the last occurrence of a character of substring.*/

class Program {
    static void Main() {
        string str = "Csharp";
        int index = str.LastIndexOf('r');
        Console.WriteLine(index);


        string str2 = "Umbrealla";
        int index2 = str2.LastIndexOf('a');
        Console.Write(index2);
    }
}