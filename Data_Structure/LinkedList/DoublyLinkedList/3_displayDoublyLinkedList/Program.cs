using System;


namespace printElementsDoublyLinkedList {
    
    public class ListNode {
        public int data;
        public ListNode? next;
        public ListNode? prev;

        public ListNode(int data) {
            this.data = data;
            this.next = null;
            this.prev = null;
        }
    }


    class DoublyLinkedList {
        private static ListNode? head = null;
        private static ListNode? tail = null;

        // method to display doubly linked list
        protected static void printElements() {
            if (head == null) {
                Console.WriteLine("Linked List empty");
                return;
            }
            ListNode? curr = head;
            while (curr != null) {
                Console.Write(curr.data + "<-->");
                curr = curr.next;
            } Console.WriteLine("NULL");
        }


        // main method
        static void Main(string[] args) {
            head = new ListNode(10);
            tail = head;
            printElements();

            ListNode second = new ListNode(20);
            ListNode third = new ListNode(30);

            head.next = second;
            second.prev = head;
            second.next = third;
            third.prev = second;
            tail = third;
            printElements();
        }
    }
}