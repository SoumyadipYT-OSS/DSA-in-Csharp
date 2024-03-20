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

            Console.WriteLine("\t - Example 3:");
            ArrayList al3 = new ArrayList(10);  // Set capacity to 10
            al3.Add(11);
            al3.Add(12);
            al3.Add(13);
            al3.Add(14);
            al3.Add(15);
            al3.Add(16);
            al3.Add(17);
            al3.Add(18);
            al3.Add(19);
            al3.Add(20);
            Display(al3);
            Console.WriteLine("ArrayList capacity: " + al3.Capacity);

            /*
                Now you can see that in the 'al3' ArrayList, we have set the capacity to 10.
                But if we want to add more than 10 elements, then the capacity will be automatically
                increased. The new capacity will be double the current capacity, that is, 20.
                Now if you do not want to increase the capacity doubled rather than you want to 
                increase as per your new added elements, then you can use the TrimToSize() method.
                In the example we will see how to use the TrimToSize() method.
            */
        }



        // main method 
        static void Main(string[] args) {
            ArrayList_Capacity();
        }
    }
}