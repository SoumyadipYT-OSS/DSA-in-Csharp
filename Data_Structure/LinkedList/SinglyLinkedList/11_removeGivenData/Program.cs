using System;

namespace removeGivenKey {
    
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
#pragma warning disable
        // method to remove given key
        protected static void removeParticularKey(int key) {
            ListNode curr = head;
            ListNode? temp = null;

            if (curr != null  &&  curr.data == key) {
                head = curr.next;
                return;
            }

            while (curr != null  &&  curr.data != key) {
                temp = curr;
                curr = curr.next;
            }

            if (curr == null) {
                return;
            }
            temp.next = curr.next;
        }
#pragma warning restore


        // main method
        static void Main(string[] args) {
            head = new ListNode(10);
            ListNode second = new ListNode(20);
            ListNode third = new ListNode(30);
            ListNode fourth = new ListNode(40);

            head.next = second;
            second.next = third;
            third.next = fourth;
            fourth.next = null;

            displayLinkedList();
            Console.WriteLine("\nRemove particular data: ");
            removeParticularKey(20);
            displayLinkedList();
        }
    }
}