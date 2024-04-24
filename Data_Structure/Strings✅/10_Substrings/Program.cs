using System;

namespace pr10
{
    class q10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("__Substring__");
            string s3 = "Visual C# Express";
            System.Console.WriteLine(s3.Substring(7, 2));

            System.Console.WriteLine(s3.Replace("C#", "Basic"));

            int index = s3.IndexOf("C");
            System.Console.WriteLine(index + "\n");

        }
    }
}