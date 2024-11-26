using System;

public class Node {
	public int Data;
	public Node Next;

	public Node(int data) {
		Data = data;
		Next = null;
	}
}


public class SinglyLinkedList {
	private Node head;

	// Method to insert a new node at the end of the list
	public void InsertAtEnd(int data) {
		Node newNode = new Node(data);
		if (head == null) {
			head = newNode;
		} else {
			Node current = head;
			while (current.Next != null) {
				current = current.Next;
			}
			current.Next = newNode;
		}
	}

	// Method to display the linked list
	public void Display() {
		Node current = head;
		while (current != null) {
			Console.Write(current.Data + " -> ");
			current = current.Next;
		}
		Console.WriteLine("null");
	}
}



public class Program {
	public static void Main(string[] args) {
		SinglyLinkedList list = new SinglyLinkedList();
		list.InsertAtEnd(10);
		list.InsertAtEnd(20);
		list.InsertAtEnd(30);
		list.Display(); // Output: 10 -> 20 -> 30 -> null
	}
}