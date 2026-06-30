public class ListNode {
    public int val;
    public ListNode next;

    public ListNode(int val) {
        this.val = val;
        this.next = null;
    }
}

public class MyCircularQueue {
    private int space;
    private ListNode left;
    private ListNode right;

    public MyCircularQueue(int k) {
        this.space = k;
        this.left = new ListNode(0);
        this.right = this.left;        
    }
    
    public bool EnQueue(int value) {
        if (IsFull()) return false;

        ListNode cur = new ListNode(value);
        if (IsEmpty()) {
            this.left.next = cur;
            this.right = cur;
        } else {
            this.right.next = cur;
            this.right = cur;
        }

        this.space--;
        return true;
    }
    
    public bool DeQueue() {
        if (IsEmpty()) return false;

        this.left.next = this.left.next.next;
        if (this.left.next == null) {
            this.right = this.left;
        }

        this.space++;
        return true;
    }
    
    public int Front() {
        return IsEmpty() ? -1 : this.left.next.val;
    }
    
    public int Rear() {
        return IsEmpty() ? -1 : this.right.val;
    }
    
    public bool IsEmpty() {
        return this.left.next == null;
    }
    
    public bool IsFull() {
        return this.space == 0;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */