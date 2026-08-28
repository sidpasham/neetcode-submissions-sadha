public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        if(nums.Length == 0) {
            return new int[] {-1, -1};
        }

        var counts = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            if(counts.ContainsKey(nums[i])) {
                counts[nums[i]]++;
            } else {
                counts.Add(nums[i], 1);
            }
        }

        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();

        foreach(var count in counts) {
            maxHeap.Enqueue(count.Key, count.Value * -1);
        }

        var result = new List<int>();

        while(result.Count() < k) {
            result.Add(maxHeap.Dequeue());
        }
        

        return result.ToArray();
    }
}
