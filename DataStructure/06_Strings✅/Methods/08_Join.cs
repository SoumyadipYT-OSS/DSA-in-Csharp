using System;

/*  Join: Concatenates an array of strings into a single string with a specified separator  */

class Program {
    static void Main() {
        string[] words = { "C", "and", "C#" };
        string joined = string.Join(" ", words);    // C and C#

        Console.WriteLine(joined);
    }
}