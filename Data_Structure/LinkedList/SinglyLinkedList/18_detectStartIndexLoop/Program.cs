using System;

namespace detectStartLoopIndexSinglyLinkedList {
    public class ListNode {
        public int data;
        public ListNode? next;

        public ListNode(int data) {
            this.data = data;
            this.next = null;
        }
    }


    class SinglyLinkedList {
        private static ListNode? head = null;

        // method to display loop Linked list
        protected static void DisplayLinkedList() {
            if (head == null) {
                Console.WriteLine("Linked List empty");
                return;
            }
            ListNode? curr = head;
            while (curr != null) {
                Console.WriteLine(curr.data + "-->");
                curr = curr.next;
            } Console.WriteLine("NULL");
        }


        // method to 
    }
}