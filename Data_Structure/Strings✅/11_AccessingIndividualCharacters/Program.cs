using System;

namespace pr11
{
    class q11
    {
        static void Main(string[] args)
        {
            string str = "Printing backwards";
            // access individual characters
            for (int i=0; i<str.Length; i++)
            {
                System.Console.Write(str[str.Length - i - 1]);
            } 
            Console.WriteLine();
        }
    }
}