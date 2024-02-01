using System;

namespace InsertAtGivenPosition {
    class SinglyLinkedList {
        private static ListNode? head = null;

        private class ListNode {
            public int data;
            public ListNode? next = null;

            public ListNode(int data) {
                this.data = data;
                this.next = null;
            }
        }

        // method display linked list
        protected static void displayLinkedList() {
            if (head == null) {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            ListNode? curr = head;
            while (curr != null) {
                Console.Write(curr.data + "-->");
                curr = curr.next;
            }
            Console.WriteLine("NULL");
        }

        // method to count the length of linked list
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


        // method to insert node at given position
        protected static void Insert_at_GivenPosition(int pos, int val) {
            ListNode newNode = new ListNode(val);
            if (head == null) {
                head = newNode;
                return;
            }
            if (pos == 1) {
                newNode.next = head;
                head = newNode;
                return;
            } else {
                ListNode curr = head;
                for (int idx=0; idx<pos-2; idx++) {
                    if (curr == null) {
                        return;
                    }
                    curr = curr.next;
                }
                if (curr == null) {
                    return;
                }
                newNode.next = curr.next;
                curr.next = newNode;
            }
        }



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
            findLength();
            Console.WriteLine();
            Insert_at_GivenPosition(3, 25);
            displayLinkedList();
            findLength() ;
            Console.WriteLine();
            Insert_at_GivenPosition(4, 110);
            displayLinkedList();
            findLength();
        }
    }
}