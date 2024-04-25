using System;

namespace searchElementLinkedList {

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
            } Console.WriteLine("NULL");
        }


        // method to search element in linked list
        protected static void searchElement(int element) {
            if (head == null) {
                Console.WriteLine("Empty linked list");
                return;
            }
            ListNode? curr = head;
            int index = 0;
            while (curr != null) {
                if (curr.data == element) {
                    Console.WriteLine("Element found at index: " + index);
                    return;
                }
                index++;
                curr = curr.next;
            }
            Console.WriteLine("Element not found");
        }


        // main method 
        static void Main(string[] args) {
            head = new ListNode(5);
            ListNode second = new ListNode(15);
            ListNode third = new ListNode(10);
            ListNode fourth = new ListNode(18);
            ListNode fifth = new ListNode(24);

            head.next = second;
            second.next = third;
            third.next = fourth;
            fourth.next = fifth;

            Console.WriteLine("__Linked list__");
            displayLinkedList();
            searchElement(10);
            searchElement(100);
        }
    }
}