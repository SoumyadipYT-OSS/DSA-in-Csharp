using System;
/*
    The (String.Format) utilizes placeholders in braces to create a format string. 
    This example results in similar output to the string interpolation method used.
*/

namespace pr9
{
    class q9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_String Composite Formatting_");
            var pw = (Family1: "Angiras", Family2: "Kanva", Verses: "10,600", Hymns: "1,028", Year: 1700, Time: "BC", BookName: "Rig Veda", Granthas: "Mandalas", Region: "Indo-European");
            Console.WriteLine("The {0} is divided into ten books whifh are knows as {1}", pw.BookName, pw.Granthas);
            Console.WriteLine("It is a collection of {0} and {1} hymns", pw.Verses, pw.Hymns);
            Console.WriteLine("It is the oldest text in any {0} language", pw.Region);
            Console.WriteLine("It has originated from early as {0} {1}", pw.Year, pw.Time);
            Console.WriteLine("The {0} (rishi family) has composed 35% of the hymns and the {1} family who has composed 25% of Rig Veda.\n", pw.Family1, pw.Family2);
        }
    }
}