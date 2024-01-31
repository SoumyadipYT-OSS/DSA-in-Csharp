using System;

namespace InsertNode_at_End {
    public class  SinglyLinkedList {
        private static ListNode? head = null;

        private class ListNode {
            public int data;
            public ListNode? next = null;

            public ListNode(int data) {
                this.data = data;
                this.next = null;
            }
        }


        // method to display linked list
        protected static void displayLinkedList() {
            ListNode? curr = head;
            while (curr != null) {
                Console.Write(curr.data + "-->");
                curr = curr.next;
            } Console.WriteLine("NULL");
        }


        // method to count length
        protected static void findLength() {
            if (head == null) {
                Console.WriteLine("Empty Linked List.");
                return;
            }
            ListNode? currNode = head;
            int count = 0;
            while (currNode != null) {
                count++;
                currNode = currNode.next;
            }
            Console.WriteLine("Length of linked list: " + count);
        }


        // method to insert node at end
        protected static void InsertAtEnd(int value) {
            ListNode? newNode = new ListNode(value);
            if (head == null) {
                head = newNode;
                return;
            }
            ListNode curr = head;
            while (curr.next != null) {
                curr = curr.next;
            }
            curr.next = newNode;
        }



        // main method
        static void Main(string[] args) {
            Console.WriteLine("Initial Linked List");
            head = new ListNode(10);
            displayLinkedList();
            findLength();

            Console.WriteLine("\nAfter adding node at end");
            InsertAtEnd(8);
            displayLinkedList();
            findLength(); 
            Console.WriteLine("\n");
        }
    }
}