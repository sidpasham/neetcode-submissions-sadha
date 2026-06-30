/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        Stack<int> stack = new Stack<int>();
        ListNode cur = head;

        while (cur != null) {
            stack.Push(cur.val);
            cur = cur.next;
        }

        cur = head;
        while (cur != null && cur.val == stack.Pop()) {
            cur = cur.next;
        }

        return cur == null;
    }
}