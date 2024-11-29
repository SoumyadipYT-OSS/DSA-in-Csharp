/* 
    String.Chars[Int32] Property

    Gets the `Char` object at a specified position in the current
    `String` object.
*/
using System;


class Program {
    static void Main() {
        Console.Write("Type a string: ");
        string myString = Console.ReadLine();
        for (int i=0; i<myString.Length; i++) {
            if (Uri.IsHexDigit(myString[i]))
                Console.WriteLine("{0} is a hexadecimal digit.", myString[i]);
            else
                Console.WriteLine("{0} is not a hexadecimal digit.", myString[i]);
        }


        string str1 = "Test";
        for (int ctr = 0; ctr <= str1.Length - 1; ctr++)
            Console.Write("{0} ", str1[ctr]);
    }
}