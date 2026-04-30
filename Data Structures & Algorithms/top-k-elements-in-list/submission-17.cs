public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // edgecases

        var map = new Dictionary<int, int>();

        for(int i =0; i<nums.Length; i++) {
            if(map.ContainsKey(nums[i])) {
                map[nums[i]]++;
            } else {
                map.Add(nums[i], 1);
            }
        }

        var pq = new PriorityQueue<int, int>();

        foreach(var kv in map) {
            pq.Enqueue(kv.Key, kv.Value);

            if(pq.Count > k) {
                pq.Dequeue();
            }
        }

        var result = new List<int>();
        while (pq.Count > 0) {
            result.Add(pq.Dequeue());
        }

        return result.ToArray();        
    }
}
