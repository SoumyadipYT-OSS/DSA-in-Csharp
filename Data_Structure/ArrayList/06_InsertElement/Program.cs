using System;
using System.Collections;

namespace Insert_Element_ArrayList {
    public class Solution {
        // method to display the ArrayList
        protected static void printArrayList(ArrayList al) {
            foreach (var val in al) {
                Console.WriteLine(val);
            }
        }


        // Main method
        static void Main(string[] args) {
            ArrayList al = new ArrayList() {
                10,
                "HP model:",
                15200,
                "4X02F"
            };

            printArrayList(al);
            al.Insert(1, 1);
            printArrayList(al);
        }
    }
}