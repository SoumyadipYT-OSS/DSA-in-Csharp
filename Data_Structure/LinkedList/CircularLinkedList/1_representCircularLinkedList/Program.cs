using System;

namespace RepresentCircularLinkedList {

#pragma warning disable
    public class ListNode {
        public int data;
        public ListNode next;

        public ListNode(int data) {
            this.data = data;
        }
    }


    class CircularLinkedList {
        private static ListNode last;
        private static int length;

        public CircularLinkedList() {
            last = null;
            length = 0;
        }

        public void createCircularLinkedList() {
            ListNode first = new ListNode(10);
            ListNode second = new ListNode(1);
            ListNode third = new ListNode(11);
            ListNode fourth = new ListNode(11);

            first.next = second;
            second.next = third;
            third.next = fourth;
            fourth.next = first;

            last = fourth;
        }

        // main method
        static void Main(string[] args) {
            CircularLinkedList cll = new CircularLinkedList();
            cll.createCircularLinkedList();
        }
    }
#pragma warning restore
}