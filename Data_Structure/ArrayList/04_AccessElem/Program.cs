using System;
using System.Collections;

/*
    The ArrayList class implements the IList interface. So, elements can be accessed using indexer, 
    in the same way as an array. Index starts from zero and increases by one for each subsequent element.
    An explicit casting to the appropriate types is required, or use the var variable
*/

namespace AccessElements_of_ArrayList {
    class Solution {
        protected static void printArrayList(ArrayList al) {
            foreach (var item in al) {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        // Main Method
        static void Main(string[] args) {
            var al = new ArrayList() {
                1, ".NET platform", 300, 8.8f
            };
            printArrayList(al);
            // Access individual item using indexer
#pragma warning disable CS8600, CS8605
            int firstElement = (int) al[0];     // returns 1
            string secondElement = (string) al[1];      // returns string value
#pragma warning restore CS8600, CS8605
            // int secondElement = (int) arlist[1]; //Error: cannot cover string to int

            // using var keyword without explicit casting
            var firstElement1 = al[0];
            var secondElement1 = al[1];
            // var fifthElement = al[5]; //Error: IndexOutOfRangeException

            // update elements
            al[0] = "Coding";
            al[1] = 100;
            printArrayList(al);
            // al[5] = 500; //Error: IndexOutOfRangeException
        }
    }
}