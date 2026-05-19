public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var pq = new PriorityQueue<int[], double>();

        foreach(var point in points) {
            int x1 = point[0];
            int y1 = point[1];
            int x2 = 0;
            int y2 = 0;
            var dist = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            pq.Enqueue(new int[] { point[0], point[1] }, dist);
        }

        int[][] result = new int[k][];
        for (int i = 0; i < k; ++i) {
            int[] point = pq.Dequeue();
            result[i] = new int[] { point[0], point[1] };
        }
        return result;      
    }
}
