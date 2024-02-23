using System;

namespace insertNode_At_End_DoublyLinkedList {
    public class DoublyListNode {
        public int data;
        public DoublyListNode? next;
        public DoublyListNode? prev;

        public DoublyListNode(int data) {
            this.data = data;
        }
    }


    class DoublyLinkedList {
        private static DoublyListNode? head = null;
        private static DoublyListNode? tail = null;

        // method to display doubly linked list
        protected static void printElements() {
            if (head == null) {
                Console.WriteLine("Linked List empty");
                return;
            }
            DoublyListNode? curr = head;
            while (curr != null) {
                Console.Write(curr.data + "<-->");
                curr = curr.next;
            } Console.WriteLine("NULL");
        }

        // method to insert node at the end
        protected static void insertNodeAtEnd(int data) {
            DoublyListNode newNode = new DoublyListNode(data);
            if (head == null) {
                head = newNode;
                tail = newNode;
                return;
            }
#pragma warning disable CS8602
            tail.next = newNode;
#pragma warning restore CS8602
            newNode.prev = tail;
            tail = newNode;
        }


        // main method
        static void Main(string[] args) {
            head = new DoublyListNode(10);
            tail = head;
            printElements();

            insertNodeAtEnd(15);
            printElements();
        }
    }
}