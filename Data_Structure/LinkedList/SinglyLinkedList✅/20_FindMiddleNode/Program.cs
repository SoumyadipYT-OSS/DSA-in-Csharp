using System;

namespace Find_Middle_Node {

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

        // method to display linked list
        protected static void displayLinkedList(ListNode? head) {
#pragma warning disable CS8602,8600
            ListNode curr = head;
            while (curr != null) {
                Console.Write(curr.data + "-->");
                curr = curr.next;
            } Console.WriteLine("NULL");
        }

        // method to find middle node of singly linked list
        protected static void findMiddleNode(ListNode head) {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null) {
                slow = slow.next;
                fast = fast.next.next;
            }
            Console.WriteLine("Middle node is: " + slow.data);
#pragma warning restore CS8602,8600
        }


        // main method
        static void Main(string[] args) {
            head = new ListNode(1);
            ListNode second = new ListNode(2);
            ListNode third = new ListNode(3);
            ListNode fourth = new ListNode(4);
            ListNode fifth = new ListNode(5);

            head.next = second;
            second.next = third;
            third.next = fourth;
            fourth.next = fifth;
            fifth.next = null;

            displayLinkedList(head);
            findMiddleNode(head);
        }
    }
}