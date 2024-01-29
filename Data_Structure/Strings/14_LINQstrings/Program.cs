using System;

namespace pr14
{
    class q14
    {
        static void Main(string[] args)
        {
            string str = "ABCDE99F-J74-12-89A";

            // select only those characters that are numbers
            IEnumerable<char> stringQuery =
                from ch in str
                where Char.IsDigit(ch)
                select ch;

            // execute the query
            foreach (char c in stringQuery)
                Console.Write(c+ " ");

            // call the 'Count' method on the existing query.
            int count = stringQuery.Count();
            Console.WriteLine("Count = {0}", count);

            // select all characters before the first '-'
            IEnumerable<char> stringQuery2 = str.TakeWhile(c => c != '-');

            // execute the second query
            foreach (char c in stringQuery2)
                Console.Write(c);

            Console.WriteLine(System.Environment.NewLine + "Press any key to exit");
            Console.ReadKey();
        }
    }
}