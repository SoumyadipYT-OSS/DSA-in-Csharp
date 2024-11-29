using System;

/*  StartsWith: Checks if the string starts with a specified substring  */

class Program {
    static void Main() {
        string str = "services";
        bool check = str.StartsWith("se");  // true

        Console.WriteLine(check);
    }
}