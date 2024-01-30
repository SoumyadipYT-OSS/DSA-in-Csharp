using System;

namespace CreateSinglyLinkedList 
{
    
    public class SinglyLinkedList {
        private ListNode head;

        private class ListNode {
            public int data; // generic type
            public ListNode next;

            public ListNode(int data) {
                this.data = data;
                this.next = null;
            }
        }


        // main method
        static void Main(string[] args) {
            SinglyLinkedList sll = new SinglyLinkedList();
            sll.head = new ListNode(10);
            ListNode second = new ListNode(1);
            ListNode third = new ListNode(8);
            ListNode fourth = new ListNode(11);

            // Now we will connect them together to form a chain
            sll.head.next = second;     // 10 -> 1
            second.next = third;    // 10 -> 1 -> 8
            third.next = fourth;    // 10 -> 1 -> 8 -> 11
            fourth.next = null;     // 10 -> 1 -> 8 -> 11 -> null
        }
    }

}