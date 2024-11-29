using System;

/* Split: Splits the string into an array of substrings based on a delimeter   */

class Program {
    static void Main() {
        string str = "hello world";
        string[] words = str.Split(' ');    // ["hello", "world"]


        foreach (string i in words)
            Console.Write(i + ", ");
    }
}