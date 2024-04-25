using System;

namespace Find_Nth_Node { 
    public class ListNode {
        public int data;
        public ListNode? next = null;

        public ListNode(int data) {
            this.data = data;
            this.next = null;
        }
    }


    class SinglyLinkedList() {
        private static ListNode? head = null;

        // method to display linked list
        protected static void displayLinkedList() {
            if (head == null) {
                Console.WriteLine("Linked List empty");
                return;
            }
            ListNode? curr = head;
            while (curr != null) {
                Console.Write(curr.data + "-->");
                curr = curr.next;
            } Console.WriteLine("NULL");
        }

        // method to find Nth node
        protected static void Nth_Node(int n) {
            if (head == null) {
                Console.WriteLine("Linked List empty");
                return;
            }
            ListNode? curr = head;
            int count = 0;
            while (curr != null) {
                if (count == n) {
                    Console.WriteLine("Nth node is: " + curr.data);
                    return;
                }
                count++;
                curr = curr.next;
            }
            Console.WriteLine("Nth node not found");
        }


        // main method
        static void Main(string[] args) {
            head = new ListNode(5);
            ListNode second = new ListNode(15);
            ListNode third = new ListNode(10);
            ListNode fourth = new ListNode(18);
            
            head.next = second;
            second.next = third;
            third.next = fourth;
            fourth.next = null;

            Console.WriteLine("__Original linked list__");
            displayLinkedList();
            Console.Write("Enter the index of Nth node to find: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Nth_Node(n);
        }
    }
}