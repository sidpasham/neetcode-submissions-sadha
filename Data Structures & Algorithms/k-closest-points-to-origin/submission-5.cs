public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        // edge case
        if(points == null) {
            return new int[0][];
        }

        var pq = new PriorityQueue<int[], double>();

        foreach(var point in points) {
            int x1 = 0;
            int y1 = 0;
            int x2 = point[0];
            int y2 = point[1];

            double dist = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            pq.Enqueue(point, dist);
        }

        int[][] result = new int[k][];

        for(int i = 0; i < k; i++) {
            result[i] = pq.Dequeue();
        }

        return result;
    }
}
