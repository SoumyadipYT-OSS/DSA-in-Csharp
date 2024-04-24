using System;
using System.Text;

namespace DYNAMIC_TYPE_CONVERSION {
    class Solution {
        static void Main(string[] args) {

            dynamic d1 = 100;
            int i = d1;

            d1 = "Hello C# Programmer";
            string greet = d1;

            d1 = DateTime.Now;
            DateTime dt = d1;
        }
    }
}