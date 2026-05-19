public class Solution {
    public int LastStoneWeight(int[] stones) {
        var pq = new PriorityQueue<int, int>();

        foreach(var stone in stones) {
            pq.Enqueue(stone, -1 * stone);
        }

        while(pq.Count > 1) {
            var first = pq.Dequeue();
            var second = pq.Dequeue();

            if(first > second) {
                pq.Enqueue(first - second, -1 * (first - second));
            }
        }

        return pq.Count == 0 ? 0 : pq.Peek();
    }
}
