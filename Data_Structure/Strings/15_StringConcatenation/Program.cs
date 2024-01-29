using System;

namespace pr15
{
    class q15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_Example 1_");
            string firstName = "Soumyadip";
            string lastName = " Majumder";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            Console.WriteLine("\n_Example 2_");
            string brand = "HP";
            string series = " victus";
            string product = string.Concat(brand, series);
            Console.WriteLine(product + "\n");
        }
    }
}