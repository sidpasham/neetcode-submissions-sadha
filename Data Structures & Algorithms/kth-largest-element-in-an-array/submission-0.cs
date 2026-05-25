public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var pq = new PriorityQueue<int, int>();
        foreach(var num in nums) {
            pq.Enqueue(num * -1, num * -1);
        }

        int res = pq.Peek();

        while(k > 0) {
            res = pq.Dequeue();
            k--;
        }

        return res * -1;
    }
}
