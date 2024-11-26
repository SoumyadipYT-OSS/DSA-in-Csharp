class Node {
    public int data;
    public Node Next;

    public Node(int data) {
        this.data = data;
        Next = null;
    }
}


class SinglyLinkedList {
    private Node head;

    // InsertAtBeginning()
    public void InsertAtBeginning(int data) {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }


    // InsertAtEnd()
    public void InsertAtEnd(int data) {
        Node newNode = new Node(data);
        if (head == null)
            head = newNode;

        Node curr = head;
        while (curr.Next != null) {
            curr = curr.Next;
        }
        curr.Next = newNode;
    }
}