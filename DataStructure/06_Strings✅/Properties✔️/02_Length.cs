/*

    String.Length Property
    
    Gets the number of characters in the current `String` object.
 
*/
using System;


class Program {
    static void Main() {
        string str = "abcdefg";
        Console.WriteLine("1) The length of '{0}' is {1}", str, str.Length);
        Console.WriteLine("2) The length of '{0}' is {1}", "xyz", "xyz".Length);

        int length = str.Length;
        Console.WriteLine("3) The length of '{0}' is {1}", str, length);


        string characters = "abc\u0000def";     // \u0000 is a null character, so it will be counted
        Console.WriteLine(characters.Length);   // Displays 7
    }
}