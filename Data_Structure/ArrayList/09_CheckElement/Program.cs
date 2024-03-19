using System;
using System.Collections;

/*
    Use the Contains() method to determine whether the specified element exists in the ArrayList or not. 
    It returns true if exists otherwise returns false.
*/

namespace CheckElement_ArrayList {
    public class Solution {
        // method to display ArrayList
        protected static void Display(ArrayList al) {
            foreach (var obj in al) {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

        // main method
        static void Main(string[] args) {
            ArrayList al = new ArrayList() {
                "A1", "B2", "C3", "D4", "E5", "F6"
            };

            Display(al);
            Console.WriteLine("Does 'A1' exist in ArrayList? " + al.Contains("A1"));
            Console.WriteLine("Does 'Z9' exist in ArrayList? " + al.Contains("Z9"));
        }
    }
}