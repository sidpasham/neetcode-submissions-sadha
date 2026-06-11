public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        // edge case
        if(nums == null || nums.Length == 0) {
            return -1;
        }

        var pq = new PriorityQueue<int, int>();

        foreach(var num in nums) {
            // add elements into K for sorting
            pq.Enqueue(num, num);

            // only maintain k elements, 
            // if more elements than k, remove them
            while(pq.Count > k) {
                pq.Dequeue();
            }
        }

        // return the top element which is K largest
        return pq.Peek();
    }
}
