﻿// How to implement a Singly Linked List in C#
/*
    Here I have simply define the structure of syntax in C# to
    represent the SinglyLinkedList. No need to run the code.
*/

using System;

namespace ImplementSinglyLinkedList {

#pragma warning disable
    public  class ListNode {
        public int data; // generic type
        public ListNode next;

        public ListNode(int data) {
            this.data = data;
            this.next = null;
        }
    }


    public class SinglyLinkedList {
        private ListNode head;

        // main method
        static void Main(string[] args){

        }
    }
#pragma warning restore
}