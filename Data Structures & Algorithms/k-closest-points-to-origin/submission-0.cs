public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var pq = new PriorityQueue<int[], int>();

        foreach(var point in points) {
            int dist = point[0] * point[0] + point[1] * point[1];
            pq.Enqueue(new int[] { dist, point[0], point[1] }, dist);
        }

        int[][] result = new int[k][];
        for (int i = 0; i < k; ++i) {
            int[] point = pq.Dequeue();
            result[i] = new int[] { point[1], point[2] };
        }
        return result;      
    }
}
