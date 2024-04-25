using System;

namespace removeDuplicateSortedSinglyLinkedList {

    public class ListNode {
        public int data;
        public ListNode? next = null;

        public ListNode(int data) {
            this.data = data;
            this.next = null;
        }
    }


    class SinglyLinkedList() {
        private static ListNode? head = null;

        // method to display linked list
        protected static void displayLinkedList() {
            if (head == null) {
                Console.WriteLine("Empty linked list");
                return;
            }
            ListNode? curr = head;
            while (curr != null) {
                Console.Write(curr.data + "-->");
                curr = curr.next;
            } Console.WriteLine("NULL");
        }

        // method to remove duplicate singly linked list
        protected static void removeDuplicates() {
            if (head == null)
                return;

            ListNode curr = head;

            while (curr != null  &&  curr.next != null) {
                if (curr.data == curr.next.data) {
                    curr.next = curr.next.next;
                } else {
                    curr = curr.next;
                }
            }
        }


        // main method
        static void Main(string[] args) {
            head = new ListNode(1);
            ListNode second = new ListNode(2);
            ListNode third = new ListNode(3);
            ListNode fourth = new ListNode(3);
            ListNode fifth = new ListNode(4);

            head.next = second;
            second.next = third;
            third.next = fourth;
            fourth.next = fifth;
            fifth.next = null;

            Console.WriteLine("__Primary linked list__");
            displayLinkedList();
            Console.WriteLine("\nAfter removing duplicates:");
            removeDuplicates();
            displayLinkedList();
        }
    }
}