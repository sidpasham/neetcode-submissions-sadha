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
    public bool HasCycle(ListNode head) {
        // TODO edgecases

        ListNode t = head;
        ListNode h = head;

        while (h != null && h.next != null) {
            t = t.next;
            h = h.next.next;
            if(t == h) {
                return true;
            }
        }

        return false;        
    }
}
