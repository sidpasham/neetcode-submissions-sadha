public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        // edge case
        if(points == null) {
            return new int[0][];
        }

        var pq = new PriorityQueue<int[], double>();

        foreach(var point in points) {
            // point 1
            int x1 = 0;
            int y1 = 0;
            // point 2
            int x2 = point[0];
            int y2 = point[1];

            // calculate the distance
            double dist = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            
            // push everything to queue so that it orders by dist
            pq.Enqueue(point, dist);
        }

        int[][] result = new int[k][];

        // only add k elements into result which are closest to k
        for(int i = 0; i < k; i++) {
            result[i] = pq.Dequeue();
        }

        return result;
    }
}
