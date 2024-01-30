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

namespace Length_of_SinglyLinkedList
{

    public class SinglyLinkedList {
        private static ListNode? head = null;

        private class ListNode {
            public int data; // generic type
            public ListNode? next = null;

            public ListNode(int data) {
                this.data = data;
            }
        }

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
        static void Main(string[] args)
        {
            head = new ListNode(10);
            ListNode second = new ListNode(1);
            ListNode third = new ListNode(8);
            ListNode fourth = new ListNode(11);
            // Now we will connect them together to form a chain
            head.next = second;     // 10 -> 1
            second.next = third;    // 10 -> 1 -> 8
            third.next = fourth;    // 10 -> 1 -> 8 -> 11
            fourth.next = null;     // 10 -> 1 -> 8 -> 11 -> null
            displayLinkedList();
            LengthSinglyLinkedList(head);
        }
    }

}