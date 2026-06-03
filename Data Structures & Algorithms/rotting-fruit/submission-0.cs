public class Solution {
    public int OrangesRotting(int[][] grid) {
        // base case
        if (grid == null || grid.Length == 0) {
            return -1;
        }

        int rowCount = grid.Length;
        int colCount = grid[0].Length;

        Queue<int[]> queue = new Queue<int[]>();

        int freshOranges = 0;

        for(int r = 0; r < rowCount; r++) {
            for (int c = 0; c < colCount; c++) {
                if(grid[r][c] == 2) {
                    queue.Enqueue(new int[] {r, c});
                } else if (grid[r][c] == 1) {
                    freshOranges++;
                }
            }
        }

        if(freshOranges == 0) return 0;

        int totalMin = 0;

        while (queue.Count > 0 && freshOranges > 0) {
            int layer = queue.Count;

            for(int i = 0; i < layer; i++) {
                int[] cur = queue.Dequeue();
                int r  = cur[0];
                int c = cur[1];
                RottenNextFruit(grid, r + 1, c, queue, ref freshOranges);
                RottenNextFruit(grid, r - 1, c, queue, ref freshOranges);
                RottenNextFruit(grid, r, c + 1, queue, ref freshOranges);
                RottenNextFruit(grid, r, c - 1, queue, ref freshOranges);
            } 

            // increment minutes elasped after every layer
            totalMin++;
        }

        return freshOranges == 0 ? totalMin : -1;
    }

    public void RottenNextFruit(int[][] grid, int r, int c, Queue<int[]> queue, ref int freshOranges) {
        // out of boundry
        if(r < 0 || c < 0 || r >= grid.Length || c>= grid[0].Length) {
            return;
        }

        // if the fruit is already rotten, then return
        if(grid[r][c] == 2) {
            return;
        }

        // rot the fruit and descrease fresh oranges
        if (grid[r][c] == 1) {
            grid[r][c] = 2;
            freshOranges--;
            queue.Enqueue(new int[] {r, c});
        }
    }
}
