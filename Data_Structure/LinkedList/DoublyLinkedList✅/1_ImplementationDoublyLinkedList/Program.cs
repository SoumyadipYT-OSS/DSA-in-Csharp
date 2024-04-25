using System;

namespace DoubleLinkedList {

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
        // main method
        static void Main(string[] args) {
            head = new ListNode(10);
            ListNode second = new ListNode(20);
            ListNode third = new ListNode(30);

            head.next = second;
            second.prev = head;
            second.next = third;
            third.prev = second;
            tail = third;
        }
    }
}