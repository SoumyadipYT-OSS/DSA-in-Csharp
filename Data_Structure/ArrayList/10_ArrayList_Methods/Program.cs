using System;
using System.Collections;

namespace ArrayList_Properties {
    public class Solution {
        // Method to display ArrayList
        protected static void Display(ArrayList al) {
            foreach (var obj in al) {
                Console.Write(obj + "-->");
            }
            Console.WriteLine();
        }


        /*
            Capacity: Gets or sets the number of elements that the ArrayList can contain.
            - By default, the capacity is 4 in the ArrayList in C#.
            - If the number of elements added to the ArrayList is greater than its capacity, then the capacity is automatically increased.
            - The capacity of the ArrayList is the number of elements the ArrayList can hold.
            - You can set the capacity of the ArrayList using the Capacity property.

        */
        protected static void ArrayList_Capacity() {
            Console.WriteLine("_Capacity_");
            Console.WriteLine("\t - Example 1:");
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add(2);
            Display(al);
            Console.WriteLine("ArrayList capacity: " + al.Capacity);

            Console.WriteLine("\t - Example 2:");
            ArrayList al2 = new ArrayList();
            al2.Add(5);
            al2.Add(6);
            al2.Add(7);
            al2.Add(8);
            al2.Add(9);
            Display(al2);
            Console.WriteLine("ArrayList capacity: " + al2.Capacity);
        }



        // main method 
        static void Main(string[] args) {
            ArrayList_Capacity();
        }
    }
}