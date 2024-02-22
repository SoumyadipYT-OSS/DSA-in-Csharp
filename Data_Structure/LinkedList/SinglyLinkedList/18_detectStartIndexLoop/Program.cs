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


        // method to detect start index of loop in Singly Linked List
        protected static void DetectStartIndexLoop() {
            if (head == null) {
                Console.WriteLine("Linked List is empty.");
                return;
            }
            ListNode? slow = head;
            ListNode? fast = head;
            int index = 0;
#pragma warning disable CS8602
            while (fast != null && fast.next != null) {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast) {
                    Console.WriteLine("Loop detected index at: {0}", index);
                    break;
                }
                index++;
            }
#pragma warning restore CS8602
            Console.WriteLine("Loop not detected in Linked List.");
        }


        // main method
        static void Main(string[] args) {
            head = new ListNode(10);
            ListNode second = new ListNode(15);
            ListNode third = new ListNode(20);
            ListNode fourth = new ListNode(18);

            head.next = second;
            second.next = third;
            third.next = fourth;
            fourth.next = second;

            DetectStartIndexLoop();
        }
    }
}