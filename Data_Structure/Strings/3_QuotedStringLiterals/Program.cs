using System;
/*
    Quoted string literals start and end with a single double quote character (") on the same line. 
    Quoted string literals are best suited for strings that fit on a single line and don't include 
    any escape sequences. 

    to know about escape sequence more, please visit:
    https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/#string-escape-sequences
*/

namespace pr3
{
    class q3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("__Example 1__");
            string columns = "Column 1\tColumn 2\tColumn 3";
            //Output: Column 1        Column 2        Column 3

            string rows = "Row 1\r\nRow 2\r\nRow 3";
            /* Output:
                Row 1
                Row 2
                Row 3
            */

            string title = "\"The \u00C6olean Harp\", by Samuel Taylor Coleridge";
            Console.WriteLine(title + "\n");
            //Output: "The Æolean Harp", by Samuel Taylor Coleridge





            Console.WriteLine("__Exapme 2__");
            var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);
            Console.WriteLine($"{jh.firstName} {jh.lastName} was an African American poet born in {jh.born}.");
            Console.WriteLine($"He was first published in {jh.published} at the age of {jh.published - jh.born}.");
            Console.WriteLine($"He'd be over {Math.Round((2018d - jh.born) / 100d) * 100d} years old today.");

            // Output:
            // Jupiter Hammon was an African American poet born in 1711.
            // He was first published in 1761 at the age of 50.
            // He'd be over 300 years old today.



            Console.WriteLine("\n__Example 3__");
            int X = 2;
            int Y = 3;

            var pointMessage = $$"""The point {{{X}}, {{Y}}} is {{Math.Sqrt(X * X + Y * Y)}} from the origin.""";

            Console.WriteLine(pointMessage + "\n");
            // Output:
            // The point {2, 3} is 3.605551275463989 from the origin.
        }
    }
}