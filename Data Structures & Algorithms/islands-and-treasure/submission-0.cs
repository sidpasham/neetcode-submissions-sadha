public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        // need to BFS because we are going from the gate to see
        // how far is the room from gate

        int rowCount = grid.Length;
        int colCount = grid[0].Length;

        Queue<int[]> queue = new Queue<int[]>();

        for(int r = 0; r < rowCount; r++) {
            for(int c = 0; c < colCount; c++) {
                if(grid[r][c] == 0) {
                    queue.Enqueue(new int[] {r, c});
                }
            }
        }

        while (queue.Count > 0) {
            int[] cur = queue.Dequeue();
            int r = cur[0];
            int c = cur[1];

            int dist = grid[r][c];

            IsValidRoom(grid, r+1, c, queue, dist + 1);
            IsValidRoom(grid, r-1, c, queue, dist + 1);
            IsValidRoom(grid, r, c+1, queue, dist + 1);
            IsValidRoom(grid, r, c-1, queue, dist + 1);
        }
    }

    public void IsValidRoom(int[][] grid, int r, int c, Queue<int[]> queue, int dist) {
        // out of boundry
        if(r < 0 || c < 0 || r >= grid.Length ||
        c >= grid[0].Length) {
            return;
        }

        // Only fill the room if it's an unvisited empty room (INF / 2147483647)
        if (grid[r][c] == 2147483647) {
            grid[r][c] = dist; // Set the new calculated distance
            queue.Enqueue(new int[] { r, c }); // Add to queue for the next layer
        }

    }
}
