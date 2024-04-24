using System;
using System.Text;

namespace DYNAMIC_VAR {
    class Solution {
        static void Main(string[] args) {
            dynamic dvar1 = 100;
            Console.WriteLine("Value: {0}, Type: {1}", dvar1, dvar1.GetType());

            dvar1 = "Hello C# Programmer";
            Console.WriteLine("Value: {0}, Type: {1}", dvar1, dvar1.GetType());

            dvar1 = true;
            Console.WriteLine("Value: {0}, Type: {1}", dvar1, dvar1.GetType());

            dvar1 = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", dvar1, dvar1.GetType());
        }
    }
}