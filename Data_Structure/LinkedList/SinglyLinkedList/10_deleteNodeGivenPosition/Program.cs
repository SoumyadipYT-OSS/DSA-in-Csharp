using System;

namespace deleteAtGivenPosition {

    public class ListNode {
        public int data;
        public ListNode? next = null;

        public ListNode(int data) {
            this.data = data;
            this.next = null;
        }
    }



    class SinglyLinkedList {
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
        // method to delete node given position
        protected static void deleteNodeGivenPosition(int pos) {
            if (pos == 1) {
                head = head.next;
            } else {
                ListNode prev = head;
                int count = 1;
                while (count < pos - 1) {
                    prev = prev.next;
                    count++;
                }

                ListNode curr = prev.next;
                prev.next = curr.next;
            }
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
            Console.WriteLine("\nAfter deleting the third position...");
            deleteNodeGivenPosition(4);
            displayLinkedList();
        }
    }
}