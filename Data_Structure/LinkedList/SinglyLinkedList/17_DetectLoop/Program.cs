using System;

namespace DetectLoop_SinglyLinkedList {

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

        // method to detect loop in Singly Linked List
        protected static void DetectLoopSinglyLinkedList() {
            if (head == null) {
                Console.WriteLine("Linked List is empty.");
                return;
            }
            ListNode? slow = head;
            ListNode? fast = head;
#pragma warning disable CS8602
            while (fast != null && fast.next != null) {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast) {
                    Console.WriteLine("Loop detected in Linked List.");
                    return;
                }
            }
#pragma warning restore CS8602
            Console.WriteLine("Loop not detected in Linked List.");
        }


        // main method
        static void Main(string[] args) {
            head = new ListNode(10);
            ListNode second = new ListNode(15);
            ListNode third = new ListNode(20);
            ListNode fourth = new ListNode(25);

            head.next = second;
            second.next = third;
            third.next = fourth;
            fourth.next = second;

            DetectLoopSinglyLinkedList();
        }
    }
}