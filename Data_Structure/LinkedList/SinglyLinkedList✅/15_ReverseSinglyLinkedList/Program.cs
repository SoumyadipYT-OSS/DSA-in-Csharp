using System;

namespace ReverseSinglyLinkedList {
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
            }Console.WriteLine("NULL");
        }

        // method to reverse linked list
        protected static void reverseTheLinkedList() {
            if (head == null) {
                Console.WriteLine("Empty linked list");
                return;
            }
            ListNode? prev = null;
            ListNode? curr = head;
            ListNode? next = null;
            while (curr != null) {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
            Console.WriteLine("__Reversed linked list__");
            displayLinkedList();
        }


        // main method
        static void Main(string[] args) {
            head = new ListNode(5);
            ListNode second = new ListNode(15);
            ListNode third = new ListNode(10);
            ListNode fourth = new ListNode(18);
            ListNode fifth = new ListNode(24);

            head.next = second;
            second.next = third;
            third.next = fourth;
            fourth.next = fifth;
            fifth.next = null;

            Console.WriteLine("__Original linked list__");
            displayLinkedList();

            reverseTheLinkedList();
        }
    }
}