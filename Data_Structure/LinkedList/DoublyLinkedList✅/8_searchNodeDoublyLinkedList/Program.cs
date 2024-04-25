using System;

namespace searchNodeDoublyLinkedList {
    [Serializable]
    public class DoublyLinkedListNode {
        public int data;
        public DoublyLinkedListNode? next;
        public DoublyLinkedListNode? prev;

        public DoublyLinkedListNode(int data) {
            this.data = data;
        }
    }

    class DoublyLinkedList {
        private static DoublyLinkedListNode? head = null;
#pragma warning disable CS0414
        private static DoublyLinkedListNode? tail = null;
#pragma warning restore CS0414

        // method to display doubly linked list
        protected static void printElements() {
            if (head == null) {
                Console.WriteLine("Linked List empty");
                return;
            }
            DoublyLinkedListNode? curr = head;
            while (curr != null) {
                Console.Write(curr.data + "<-->");
                curr = curr.next;
            }
            Console.WriteLine("NULL");
        }

        // method to search node in doubly linked list
        protected static void searchNode(int data) {
            if (head == null) {
                Console.WriteLine("Linked List empty");
                return;
            }
            DoublyLinkedListNode? curr = head;
            int index = 0;
            while (curr != null) {
                if (curr.data == data) {
                    Console.WriteLine("Element found at index: " + index);
                    return;
                }
                curr = curr.next;
                index++;
            }
            Console.WriteLine("Element not found");
        }


        // main method
        static void Main(string[] args) {
            head = new DoublyLinkedListNode(10);
            DoublyLinkedListNode second = new DoublyLinkedListNode(20);
            DoublyLinkedListNode third = new DoublyLinkedListNode(30);

            head.next = second;
            second.prev = head;
            second.next = third;
            third.prev = second;
            third.next = null;

            printElements();
            searchNode(20);
            searchNode(40);
        }
    }
}