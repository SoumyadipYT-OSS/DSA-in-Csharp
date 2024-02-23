using System;

/*
    You are given a doubly linked list such that it is first increasing and then
    decreasing. You have to sort this doubly linked list.
    Such types of linked lists are called biotonic doubly linked  list. A strictly
    decreasing list is also a biotonic doubly linked list.
*/

namespace biotonicDoublyLinkedList {

    [Serializable]
    public class DoublyLinkedListNode {
        public int data;
        public DoublyLinkedListNode? next;
        public DoublyLinkedListNode? prev;
        public DoublyLinkedListNode(int data) {
            this.data = data;
        }
    }


    class BiotonicDoublyLinkedList {
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

        // method to sort biotonic doubly linked list
        protected static void sortBiotonicDoublyLinkedList() {
            if (head == null) {
                Console.WriteLine("Linked List empty");
                return;
            }
            DoublyLinkedListNode? curr = head;
            while (curr != null && curr.next != null) {
                curr = curr.next;
            }
            DoublyLinkedListNode? temp = curr;
            while (curr != null && curr.prev != null) {
                if (curr.data < curr.prev.data) {
                    curr.prev.next = null;
                    curr.prev = null;
                    break;
                }
                curr = curr.prev;
            }
            DoublyLinkedListNode? left = head;
            DoublyLinkedListNode? right = temp;
            DoublyLinkedListNode? prev = null;
            while (left != null && right != null) {
                if (left.data < right.data) {
                    if (prev == null) {
                        head = left;
                    } else {
                        prev.next = left;
                    }
                    left.prev = prev;
                    prev = left;
                    left = left.next;
                } else {
                    if (prev == null) {
                        head = right;
                    } else {
                        prev.next = right;
                    }
                    right.prev = prev;
                    prev = right;
                    right = right.next;
                }
            }
#pragma warning disable CS8602
            if (left == null) {
                prev.next = right;
                right.prev = prev;
            } else {
                prev.next = left;
                left.prev = prev;
            }
#pragma warning restore CS8602
        }


        // main method
        static void Main(string[] args) {
            head = new DoublyLinkedListNode(1);
            DoublyLinkedListNode second = new DoublyLinkedListNode(4);
            DoublyLinkedListNode third = new DoublyLinkedListNode(6);
            DoublyLinkedListNode fourth = new DoublyLinkedListNode(7);
            DoublyLinkedListNode fifth = new DoublyLinkedListNode(8);
            DoublyLinkedListNode sixth = new DoublyLinkedListNode(5);
            DoublyLinkedListNode seventh = new DoublyLinkedListNode(3);
            DoublyLinkedListNode eighth = new DoublyLinkedListNode(2);

            head.next = second;
            second.prev = head;
            second.next = third;
            third.prev = second;
            third.next = fourth;
            fourth.prev = third;
            fourth.next = fifth;
            fifth.prev = fourth;
            fifth.next = sixth;
            sixth.prev = fifth;
            sixth.next = seventh;
            seventh.prev = sixth;
            seventh.next = eighth;
            eighth.prev = seventh;
            eighth.next = null;

            printElements();
            sortBiotonicDoublyLinkedList();
            printElements();

        }
    }
}