using System;


class NodeSingly {
    public int data;
    public NodeSingly Next;

    public NodeSingly(int data) {
        this.data = data;
        Next = null;
    }
}


class LinkedList {
    public void RemoveDuplicates() {
        NodeSingly head;
        NodeSingly current = head;

        while (current != null  &&  current.Next != null) {
            if (current.data == current.Next.data) {
                current.Next = current.Next.Next;
            } else {
                current = current.Next;
            }
        }
    }
}