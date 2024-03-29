﻿using System;
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
            Console.WriteLine(" - Example 1:");
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add(2);
            Display(al);
            Console.WriteLine("ArrayList capacity: " + al.Capacity);

            Console.WriteLine(" - Example 2:");
            ArrayList al2 = new ArrayList();
            al2.Add(5);
            al2.Add(6);
            al2.Add(7);
            al2.Add(8);
            al2.Add(9);
            Display(al2);
            Console.WriteLine("ArrayList capacity: " + al2.Capacity);

            Console.WriteLine(" - Example 3:");
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
            Console.WriteLine(" - Example 4:");
            ArrayList al4 = new ArrayList(5);  // Set capacity to 5
            al4.Add(21);
            al4.Add(22);
            al4.Add(23);
            al4.Add(24);
            al4.Add(25);
            al4.Add(26);
            al4.Add(27);
            al4.Add(28);

            // now the capacity will be increased to 10 because we have added 8 elements
            // and the capacity will be doubled. (from 5 to 10)
            // But we want to ensure that the capacity should be 8 only.
            al4.TrimToSize();   // Now the capacity will be 8
            Display(al4);
            Console.WriteLine("ArrayList capacity: " + al4.Capacity);

            // The TrimToSize() method is used to optimize the memory of the ArrayList.
            // If we want to see the memory byte size of the ArrayList, then we can use the
            // Capacity property and the sizeof() operator.
            // If we put 'byte' in the sizeof() operator, then it will return the size of the ArrayList in bytes.
            // If we put 'int' in the sizeof() operator, then it will return the size of the ArrayList in integers.
            Console.WriteLine("Size of ArrayList(Byte): " + sizeof(byte) * al4.Capacity + " bytes.");
            Console.WriteLine("Size of ArrayList(Int): " + sizeof(int) * al4.Capacity + " integers.");
        }



        /*
            Count: Gets the number of elements actually contained in the ArrayList. 
        */
        protected static void ArrayList_Count() {
            Console.WriteLine("_Count_");
            Console.WriteLine(" - Example 1:");
            ArrayList al = new ArrayList();
            al.Add(11);
            al.Add(24);
            al.Add(38);
            
            Display(al);
            Console.WriteLine("ArrayList count: " + al.Count);
        }



        /*
            IsFixedSize: Gets a value indicating whether the ArrayList has a fixed size.
            - If the ArrayList has a fixed size, then it returns true otherwise returns false.
            - If the ArrayList has a fixed size, then you cannot add or remove elements from the ArrayList.
            - By default, the ArrayList does not have a fixed size.
            - You can set the fixed size of the ArrayList using the IsFixedSize property.
            - If the ArrayList has a fixed size, then you cannot change the capacity of the ArrayList.
        */
        protected static void ArrayList_IsFixedSize_Property() {
            Console.WriteLine("_IsFixedSize_");
            ArrayList al = new ArrayList();
            al.Add("Banana");
            al.Add("Apple");
            al.Add("Mango");
            al.Add("Grapes");
            al.Add("Orange");

            bool checkFixedSize = al.IsFixedSize;
            Console.WriteLine("Is ArrayList fixed size? " + checkFixedSize);


            ArrayList al2 = new ArrayList(5);
            al.Add("Pineapple");
            al.Add("Papaya");
            al.Add("Guava");
            al.Add("Watermelon");
            al.Add("Kiwi");
            bool checkFixedSize2 = al2.IsFixedSize;
            Console.WriteLine("Is ArrayList fixed size? " + checkFixedSize2);

            ArrayList myFixedSizeAL = ArrayList.FixedSize(al);
            Console.WriteLine("myAL {0}.", myFixedSizeAL.IsFixedSize ? "is fixed size" : "is not fixed size");
        }




        /*
            IsReadOnly: Gets a value indicating whether the ArrayList is read-only.
            - If the ArrayList is read-only, then it returns true otherwise returns false.
            - If the ArrayList is read-only, then you cannot edit the ArrayList.
            - By default, the ArrayList is not read-only.
            - You can set the read-only of the ArrayList using the IsReadOnly property.
            - If the ArrayList is read-only, then you cannot change the capacity of the ArrayList.
        */
        protected static void ArrayList_IsReadOnly_Property() {
            Console.WriteLine("_IsReadOnly_");
            ArrayList al = new ArrayList();
            al.Add("HP");
            al.Add("DELL");
            al.Add("ASUS");
            al.Add("Lava");
            al.Add("AGP Laptops");
            al.Add("Micromax");

            bool checkReadOnly = al.IsReadOnly;
            Console.WriteLine("Is ArrayList read-only? " + checkReadOnly);
        }




        /*
            Item: Gets or sets the element at the specified index.
            - The index is zero-based.
            - The Item property is used to get or set the element at the specified index.
            - If you want to get the element at the specified index, then you can use the Item property.
            - If you want to set the element at the specified index, then you can use the Item property.
        */
        protected static void Item_Property() {
            Console.WriteLine("_Item_Property_");
            ArrayList al = new ArrayList();
            al.Add("C#");
            al.Add("C");
            al.Add("C++");
            al.Add("Rust");
            al.Add("Python");

            Console.WriteLine("Element at index 2: " + al[2]);
            al[2] = "Objective-C";
            Display(al);
        }




        /*
            IsSynchronized: Gets a value indicating whether access to the 
                            ArrayList is synchronized (thread safe).
            - If the ArrayList is synchronized, then it returns true otherwise returns false.
            - If the ArrayList is synchronized, then it is thread safe.
            - By default, the ArrayList is not synchronized.
            - You can set the synchronized of the ArrayList using the IsSynchronized property.
        */
        protected static void ArrayList_IsSynchronized_Property() {
            Console.WriteLine("_IsSynchronized_");
            ArrayList al = new ArrayList();
            al.Add("C#");
            al.Add("C");
            al.Add("C++");
            al.Add("Rust");
            al.Add("Python");

            bool checkSynchronized = al.IsSynchronized;
            Console.WriteLine("Is ArrayList synchronized? " + checkSynchronized);
        }


        // method to make ArrayList synchronized
        protected static void MakeArrayListSynchronized() {
            Console.WriteLine("_MakeArrayListSynchronized_");
            ArrayList al = new ArrayList();
            al.Add("C#");
            al.Add("C");
            al.Add("C++");
            al.Add("Rust");
            al.Add("Python");

            ArrayList mySyncAL = ArrayList.Synchronized(al);
            Console.WriteLine("myAL {0}.", mySyncAL.IsSynchronized ? "is synchronized" : "is not synchronized");
        }

        /*
          method SyncRoot to get the object that can be used to synchronize access to the ArrayList.
          - The SyncRoot property returns an object that can be used to synchronize access to the ArrayList.
          - If you want to synchronize access to the ArrayList, then you can use the SyncRoot property.
        */
        protected static void SyncRoot() {
            Console.WriteLine("_SyncRoot_");
            ArrayList al = new ArrayList();
            al.Add("C#");
            al.Add("C");
            al.Add("C++");
            al.Add("Rust");
            al.Add("Python");

            object obj = al.SyncRoot;
            Console.WriteLine("SyncRoot: " + obj);
        }




        // main method 
        static void Main(string[] args) {
            ArrayList_Capacity();
            Console.WriteLine("\n\n");
            ArrayList_Count();
            Console.WriteLine("\n\n");
            ArrayList_IsFixedSize_Property();
            Console.WriteLine("\n\n");
            ArrayList_IsReadOnly_Property();
            Console.WriteLine("\n\n");
            Item_Property();
            Console.WriteLine("\n\n");
            ArrayList_IsSynchronized_Property();
            MakeArrayListSynchronized();
            Console.WriteLine("\n\n");
            SyncRoot();
        }
    }
}