public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val)
    {
        this.val = val;
        this.next = null;
    }
}


public class MyLinkedList {
    private ListNode head;
    private int size;

    public MyLinkedList() {
        head = new ListNode(0);
        size = 0;
    }
    
    public int Get(int index) {
        if (index >= size) return -1;

        ListNode cur = head.next;
        for (int i = 0; i < index; i++) 
        {
            cur = cur.next;
        }
        return cur.val;        
    }
    
    public void AddAtHead(int val) {
        ListNode cur = head.next;

        ListNode nodeAdded = new ListNode(val);
        nodeAdded.next = cur;

        head.next = nodeAdded;
        size++;
    }
    
    public void AddAtTail(int val) {
        ListNode node = new ListNode(val);
        ListNode cur = head;
        while (cur.next != null) {
            cur = cur.next;
        }
        cur.next = node;
        size++;

    }
    
    public void AddAtIndex(int index, int val) {
        if (index > size) return;
        ListNode cur = head;
        for (int i = 0; i < index; i++) {
            cur = cur.next;
        }
        ListNode node = new ListNode(val);
        node.next = cur.next;
        cur.next = node;
        size++;
    }
    
    public void DeleteAtIndex(int index) {
        if (index >= size) return;

        ListNode cur = head;
        for (int i = 0; i < index; i++)
        {
            cur = cur.next;
        }
        cur.next = cur.next.next;
        size--;

    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */