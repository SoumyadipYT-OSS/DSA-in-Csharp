using System;

/* Checks if the string is null, empty, or consists only of white-space characters  */


class Program {
    static void Main() {
        string str = "      ";
        bool check = string.IsNullOrWhiteSpace(str);
        Console.WriteLine(check);

        string str2 = "Hey developer    ";
        bool check2 = string.IsNullOrWhiteSpace(str2);
        Console.WriteLine(check2);

        string str3 = "program";
        bool check3 = string.IsNullOrWhiteSpace(str3);
        Console.WriteLine(check3);
    }
}