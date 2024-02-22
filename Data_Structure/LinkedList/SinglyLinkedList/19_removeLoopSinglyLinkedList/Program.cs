using System;

namespace removeLoopSinglyLinkedList {

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

        // method to remove loop in Singly Linked List
        protected static void RemoveLoop() {
            if (head == null) {
                Console.WriteLine("Linked List is empty.");
                return;
            }
            ListNode? slow = head;
#pragma warning disable CS8602
            ListNode? fast = head;
            while (fast != null && fast.next != null) {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast) {
                    slow = head;
                    while (slow?.next != fast?.next) {
                        slow = slow?.next;
                        fast = fast?.next;
                    }
                    fast.next = null;
#pragma warning restore CS8602
                    Console.WriteLine("Loop removed from Linked List.");
                    return;
                }
            }
            Console.WriteLine("Loop not detected in Linked List.");
        }

        // method to display linked list
        protected static void displayLinkedList() {
            if (head == null) {
                Console.WriteLine("Linked List empty");
                return;
            }
            ListNode? curr = head;
            while (curr != null) {
                Console.Write(curr.data + "-->");
                curr = curr.next;
            } Console.WriteLine("NULL");
        }


        // main method
        static void Main(string[] args) {
            head = new ListNode(5);
            ListNode second = new ListNode(10);
            ListNode third = new ListNode(15);
            ListNode fourth = new ListNode(20);
            ListNode fifth = new ListNode(25);

            head.next = second;
            second.next = third;
            third.next = fourth;
            fourth.next = fifth;
            fifth.next = second;

            RemoveLoop();
            displayLinkedList();
        }
    }
}