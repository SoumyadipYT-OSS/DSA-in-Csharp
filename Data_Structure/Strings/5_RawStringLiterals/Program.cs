using System;
/*
     Refer this link for know more about raw string literals...
    https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
*/


namespace pr5
{
    class q5
    {
        static void Main(string[] args)
        {
            string singleLine = """Friends say "hello" as they pass by.""";
            Console.WriteLine($"SingleLine: {singleLine}");


            string multiLine = """
                "Hello World!" is typically the first program someone writes.
                """;
            Console.WriteLine($"\nMultiLine: {multiLine}");


            string embeddedXML = """
                <element attr = "content">
                    <body style="normal">
                        Here is the main text.
                    </body>
                    <footer>
                        Excerpts from "An amazing story"
                    </footer>
                </element>
                """;
            Console.WriteLine($"\nEmbeddedXML: \n{embeddedXML}");



            // The line "<element attr = "content">" starts in the first column.
            // All whitespace left of that column is removed from the string.

            string raw_String_Literal_Delimiter = """"
                Raw string literals are delimited
                by a string of at least three double quotes,
                like this:  """
                """";
            Console.WriteLine($"\nRaw String Literals: {raw_String_Literal_Delimiter}\n");

        }
    }
}