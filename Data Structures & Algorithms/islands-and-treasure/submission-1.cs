public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        // need to BFS because we are going from the treasure chest to see
        // how far is the land from treasure chest
        int rowCount = grid.Length;
        int colCount = grid[0].Length;

        Queue<int[]> queue = new Queue<int[]>();

        for(int r = 0; r < rowCount; r++) {
            for (int c = 0; c < colCount; c++) {
                if(grid[r][c] == 0) {
                    queue.Enqueue(new int[] {r, c});
                }
            }
        }

        while(queue.Count > 0) {
            int[] cur = queue.Dequeue();

            int r = cur[0];
            int c = cur[1];

            // you need to increase from the current row
            int nextDist = grid[r][c] + 1;

            IsValidLand(grid, r + 1, c, nextDist, queue);
            IsValidLand(grid, r - 1, c, nextDist, queue);
            IsValidLand(grid, r, c + 1, nextDist, queue);
            IsValidLand(grid, r, c - 1, nextDist, queue);
        }
    }

    public void IsValidLand(int[][] grid, int r, int c, int dist, Queue<int[]> queue) {
        // out of boundry
        if(r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length) {
            return;
        }
        // if we reach water, return
        if(grid[r][c] == -1) {
            return;
        }

        if(grid[r][c] == 2147483647) {
            grid[r][c] = dist;
            queue.Enqueue(new int[] {r, c});
        }
    }
}
