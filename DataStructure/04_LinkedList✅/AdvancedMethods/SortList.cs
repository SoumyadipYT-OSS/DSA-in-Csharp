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
    public NodeSingly SortList(NodeSingly head) {
        if (head == null || head.Next == null) return head;

        NodeSingly middle = GetMiddle(head);
        NodeSingly nextOfMiddle = middle.Next;

        middle.Next = null;

        NodeSingly left = SortList(head);
        NodeSingly right = SortList(nextOfMiddle);

        NodeSingly sortedList = MergeTwoLists(left, right);
        return sortedList;
    }

    private NodeSingly GetMiddle(NodeSingly head) {
        if (head == null) return head;

        NodeSingly slow = head;
        NodeSingly fast = head;

        while (fast.Next != null  &&  fast.Next.Next != null) {
            slow = slow.Next;
            fast = fast.Next.Next;
        }
        return slow;
    }
}