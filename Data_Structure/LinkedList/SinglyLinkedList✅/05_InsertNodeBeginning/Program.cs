using System;

namespace InsertNode_at_Beginning {
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


        // method to display Linked List
        protected static void displayLinkedList() {
            ListNode? curr = head;
            while (curr != null) {
                Console.Write(curr.data + "-->");
                curr = curr.next;
            } Console.WriteLine("NULL");
        }


        // method to insert node at beginning
        protected static void InsertAtBeginning(int value) {
            ListNode newNode = new ListNode(value);
            newNode.next = head;
            head = newNode;
        }

        // method to find length of the singly linked list
        protected static void LengthSinglyLinkedList() {
            if (head == null) {
                Console.WriteLine("Linked List is empty");
                return;
            }
            int count = 0;
            ListNode? curr = head;
            while (curr != null) {
                count++;
                curr = curr.next;
            }
            Console.WriteLine("Length: " + count);
        }


        // main method
        static void Main(string[] args) {
            InsertAtBeginning(24);
            displayLinkedList();
            LengthSinglyLinkedList();

            InsertAtBeginning(10);
            displayLinkedList();
            LengthSinglyLinkedList();
        }
    }
#pragma warning restore     // disable all types of warnings
}