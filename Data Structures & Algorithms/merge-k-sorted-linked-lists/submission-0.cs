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
    public ListNode MergeKLists(ListNode[] lists) {
        // TODO edgecases

        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;

        var minHeap = new PriorityQueue<ListNode, int>();

        foreach(var list in lists) {
            if(list != null) {
                minHeap.Enqueue(list, list.val);
            } 
        }

        while(minHeap.Count > 0) {
            ListNode temp = minHeap.Dequeue();
            curr.next = temp;
            curr = curr.next;

            var nextNode = temp.next;
            if(nextNode != null) {
                minHeap.Enqueue(nextNode, nextNode.val);
            }
        }

        return dummy.next;
    }
}
