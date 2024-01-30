using System;

namespace printElementsSinglyLinkedList
{

    public class SinglyLinkedList
    {
        private static ListNode? head = null;

        private class ListNode
        {
            public int data; // generic type
            public ListNode? next = null;

            public ListNode(int data)
            {
                this.data = data;
            }
        }

        // method to print the Singly Linked List
        protected static void displayLinkedList()
        {
            ListNode? curr = head;
            while (curr != null)
            {
                Console.Write(curr.data + "-->");
                curr = curr.next;
            }
            Console.WriteLine("NULL");
        }

        // main method
        static void Main(string[] args)
        {
            SinglyLinkedList sll = new SinglyLinkedList();
            head = new ListNode(10);
            ListNode second = new ListNode(1);
            ListNode third = new ListNode(8);
            ListNode fourth = new ListNode(11);

            // Now we will connect them together to form a chain
            head.next = second;     // 10 -> 1
            second.next = third;    // 10 -> 1 -> 8
            third.next = fourth;    // 10 -> 1 -> 8 -> 11
            fourth.next = null;     // 10 -> 1 -> 8 -> 11 -> null

            displayLinkedList();
        }
    }

}