using System;

/*  EndsWith: Checks if the string ends with a specified substring.  */

class Program {
    static void Main() {
        string str = "features";
        bool check = str.EndsWith("es");

        Console.WriteLine(check);
    }
}