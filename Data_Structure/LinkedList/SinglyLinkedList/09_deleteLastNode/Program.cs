using System;

namespace deleteLastNode {
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

#pragma warning disable
        // method to delete last node
        protected static ListNode deleteLast() {
            if (head == null  ||  head.next == null) {
                return head;
            }
            ListNode? curr = head;
            ListNode? prev = null;
            while (curr.next != null) {
                prev = curr;
                curr = curr.next;
            }
            prev.next = null;
            return curr;
        }
#pragma warning restore

        // main method
        static void Main(string[] args) {
            head = new ListNode(10);
            ListNode second = new ListNode(20);
            ListNode third = new ListNode(30);
            ListNode fourth = new ListNode(40);

            head.next = second;
            second.next = third;
            third.next = fourth;
            fourth.next = null;

            displayLinkedList();

            Console.WriteLine("\nAfter deleting last node...");

            deleteLast();
            displayLinkedList();
        }
    }
}