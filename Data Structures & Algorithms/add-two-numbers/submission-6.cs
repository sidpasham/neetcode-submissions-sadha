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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;
        int carry = 0;

        while (l1 != null && l2 != null) {
            int sum = l1.val + l2.val + carry;
            carry = sum / 10;
            int reminder = sum % 10;

            curr.next = new ListNode(reminder);
            curr = curr.next;
            l1 = l1.next;
            l2 = l2.next;
        }

        while (l1 != null) {
            int sum = carry + l1.val;
            carry = sum / 10;
            int reminder = sum % 10;

            curr.next = new ListNode(reminder);
            curr = curr.next;
            l1 = l1.next;
        }

        while (l2 != null) {
            int sum = carry + l2.val;
            carry = sum / 10;
            int reminder = sum % 10;

            curr.next = new ListNode(reminder);
            curr = curr.next;
            l2 = l2.next;
        }

        if(carry > 0) {
            curr.next = new ListNode(carry);
            curr = curr.next;
        }

        return dummy.next;
        
    }
}
