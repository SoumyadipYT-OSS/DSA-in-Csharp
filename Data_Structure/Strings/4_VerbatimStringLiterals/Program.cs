using System;

/*
    Verbatim string literals are more convenient for multi-line strings, strings 
    that contain backslash characters, or embedded double quotes. Verbatim 
    strings preserve new line characters as part of the string text.
*/

namespace pr4
{
    class q4
    {
        static void Main(string[] args)
        {
            string title = "\"The \u00C6olean Harp\", by Samuel Taylor Coleridge";
            //Output: "The Æolean Harp", by Samuel Taylor Coleridge
            Console.WriteLine(title);

            string filePath = @"C:\Users\scoleridge\Documents\";
            //Output: C:\Users\scoleridge\Documents\
            Console.WriteLine(filePath);

            string text = @"My pensive SARA ! thy soft cheek reclined
                Thus on mine arm, most soothing sweet it is
                To sit beside our Cot,...";
            /* Output:
            My pensive SARA ! thy soft cheek reclined
                Thus on mine arm, most soothing sweet it is
                To sit beside our Cot,...
            */
            Console.WriteLine(text);

            string quote = @"Her name was ""Sara.""";
            //Output: Her name was "Sara."
            Console.Write(quote);
        }
    }
}