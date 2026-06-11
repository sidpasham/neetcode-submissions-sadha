public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        // edge case
        if(nums == null || nums.Length == 0) {
            return -1;
        }

        var pq = new PriorityQueue<int, int>();

        foreach(var num in nums) {
            pq.Enqueue(num, num);

            while(pq.Count > k) {
                pq.Dequeue();
            }
        }

        return pq.Peek();
    }
}
