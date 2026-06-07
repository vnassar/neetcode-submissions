public class ListNode
{
    public ListNode prev;
    public string url;
    public ListNode next;

    public ListNode(ListNode previous = null, string? link = null, ListNode forward = null)
    {
        this.prev = previous;
        this.url = link;
        this.next = forward;
    }
}


public class BrowserHistory {
    public ListNode head = new ListNode();
    public ListNode position;
    public BrowserHistory(string homepage) {
        head.url = homepage;
        position = head;
    }
    
    public void Visit(string url) {
        
        ListNode newNode = new ListNode(position.prev, url);
        position.next = newNode;
        newNode.prev = position;
        newNode.next = null;

        position = newNode;
    }
    
    public string Back(int steps) {
        for (int i = steps; i > 0; i--)
        {
            if (position.prev != null)
            {
                position = position.prev;
            }
        }
        return position.url;
    }
    
    public string Forward(int steps) {
        
        for (int i = steps; i > 0; i--)
        {
            if (position.next != null)
            {
                position = position.next;
            }
        }
        return position.url;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */