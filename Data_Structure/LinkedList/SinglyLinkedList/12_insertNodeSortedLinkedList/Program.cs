using System;

namespace InsertInSortedList {

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
            }
            Console.WriteLine("NULL");
        }


        // method to insert sorted list
        protected static ListNode insertInSortedList(int val) {
            ListNode newNode = new ListNode(val);

            if (head == null)
                return newNode;

            ListNode curr = head;
            ListNode? temp = null;
#pragma warning disable
            while (curr != null  &&  curr.data < newNode.data) {
                temp = curr;
                curr = curr.next;
            }

            newNode.next = curr;
            temp.next = newNode;
#pragma warning restore

            return head;
        }



        // main method
        static void Main(string[] args) {
            head = new ListNode(10);
            ListNode second = new ListNode(20);
            ListNode third = new ListNode(30);

            head.next = second;
            second.next = third;
            third.next = null;

            displayLinkedList();
            insertInSortedList(25);
            Console.WriteLine("\nInserting the value 25 in the linked list...");
            displayLinkedList();
        }
    }
}