using System;

/*
    private static void LengthSinglyLinkedList(ListNode head) {
            if (head == null) {
                Console.WriteLine("The linked list is empty.");
                return;
            }

            int count = 0;
            ListNode? current = head;
            while (current != null) {
                count++;
                current = current.next;
            }
            Console.WriteLine("Length of the linked list: " + count);
     }
*/

namespace Length_of_SinglyLinkedList {
#pragma warning disable

    public class ListNode {
        public int data;
        public ListNode? next;

        public ListNode(int data) {
            this.data = data;
            this.next = null;
        }
    }


    public class SinglyLinkedList {
        private static ListNode? head = null;

        // method to print the Singly Linked List
        protected static void displayLinkedList() {
            ListNode? curr = head;
            while (curr != null) {
                Console.Write(curr.data + "-->");
                curr = curr.next;
            }
            Console.WriteLine("NULL");
        }

        // method to find the length of singly linked list
        private static void LengthSinglyLinkedList(ListNode head) {
            if (head == null) {
                Console.WriteLine("The linked list is empty.");
                return;
            }

            int count = 0;
            ListNode? current = head;
            while (current != null) {
                count++;
                current = current.next;
            }
            Console.WriteLine("Length of the linked list: " + count);
        }


        // main method
        static void Main(string[] args) {
            head = new ListNode(8);
            ListNode second = new ListNode(1);
            ListNode third = new ListNode(10);
            ListNode fourth = new ListNode(12);

            head.next = second;
            second.next = third;
            third.next = fourth;
            fourth.next = null;
            displayLinkedList();
            LengthSinglyLinkedList(head);
        }
    }
#pragma warning restore
}