using System;

namespace deleteFirstNode {

    public class ListNode {
        public int data;
        public ListNode? next = null;

        public ListNode(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    class SinglyLinkedList {
        private static ListNode? head = null;


        // method to display linked list
        protected static void displayLinkedList() {
            if (head == null) {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            ListNode? curr = head;
            while (curr != null) {
                Console.Write(curr.data + "-->");
                curr = curr.next;
            }
            Console.WriteLine("NULL");
        }

        // method to delete first node
#pragma warning disable 8603   // this is used to disable warning the possible nullable
        public static ListNode deleteFirst() {
            if (head == null)
                return null;

            ListNode? temp = head;
            head = head.next;
            temp.next = null;
            return temp;
        }
#pragma warning restore 8603



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

            Console.WriteLine("\nAfter deleting first node...");
            deleteFirst();
            displayLinkedList();
        }
    }
}