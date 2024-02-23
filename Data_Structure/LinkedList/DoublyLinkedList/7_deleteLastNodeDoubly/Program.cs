using System;

namespace deleteLastNodeDoublyLinkedList {
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
#pragma warning disable CS0414
        private static DoublyListNode? tail = null;
#pragma warning restore CS0414
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

        // method to delete last node
        protected static void deleteLastNode() {
            if (head == null) {
                Console.WriteLine("Linked List empty");
                return;
            }
            if (head.next == null) {
                head = null;
                return;
            }
            DoublyListNode? curr = head;
            while (curr.next != null) {
                curr = curr.next;
            }
#pragma warning disable CS8602
            curr.prev.next = null;
#pragma warning restore CS8602
        }


        // main method
        static void Main(string[] args) {
            head = new DoublyListNode(5);
            DoublyListNode second = new DoublyListNode(10);
            DoublyListNode third = new DoublyListNode(15);
            DoublyListNode fourth = new DoublyListNode(17);

            head.next = second;
            second.prev = head;
            second.next = third;
            third.prev = second;
            third.next = fourth;
            fourth.prev = third;
            fourth.next = null;

            printElements();
            Console.WriteLine("Deleting last node");
            deleteLastNode();
            printElements();
        }
    }
}