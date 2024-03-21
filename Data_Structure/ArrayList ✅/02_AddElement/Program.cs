using System;
using System.Collections;

namespace AddNewElement_ArrayList {
    public class Solution {
        // Display ArrayList
        protected static void displayArrL(ArrayList al) {
            foreach (var item in al) {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        // Adding Elements in ArrayList
        protected static void AddElem_in_ArrayList() {
            var al1 = new ArrayList();
            al1.Add(1);
            al1.Add("Harinath");
            al1.Add(" ");
            al1.Add(true);
            al1.Add(4.5);
            al1.Add(null);


            // adding elements using object initializer syntax
            var al2 = new ArrayList() {
                        2, "Sridip", " ", true, 9.8, null
            };

            displayArrL(al1);
            displayArrL(al2);
        }


        // Main Method
        static void Main(string[] args) {
            AddElem_in_ArrayList();
        }
    }
}