using System;

/*  Trim: Removes all leading and trailing white-space characters from the string.  */

class Program {
    static void Main() {
        string str = "  cloud platform    ";
        string trimmed = str.Trim();    // "cloud platform"

        Console.WriteLine(trimmed);
    }
}