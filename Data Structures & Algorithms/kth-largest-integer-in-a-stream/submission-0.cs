public class KthLargest {
    PriorityQueue<int, int> pq = new PriorityQueue<int,int>();
    int K;

    public KthLargest(int k, int[] nums) {
        K = k;
        foreach(var num in nums) {
            Add(num);
        }
    }
    
    public int Add(int val) {
        pq.Enqueue(val, val);
        while (pq.Count > K) {
            pq.Dequeue();
        }
        return pq.Peek();
    }
}
