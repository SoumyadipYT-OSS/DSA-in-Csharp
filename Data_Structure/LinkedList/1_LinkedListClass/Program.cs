using System;
using System.Collections;
using System.Collections.Generic;

namespace pr1
{
    class q1
    {
        static void Main(string[] args)
        {
            LinkedList<String> myList = new LinkedList<string>();
            myList.AddLast("Programmers");
            myList.AddLast("Welcome");
            myList.AddLast("to C#");
            myList.AddLast("Programming Language");
            Console.WriteLine(myList.ToString());
            if (myList.Count > 0) {
                Console.WriteLine("LinkedList is not empty.");
            } else {
                Console.WriteLine("LinkedList is empty.");
            }
        }
    }
}