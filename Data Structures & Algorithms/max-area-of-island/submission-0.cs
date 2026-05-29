public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        if (grid == null || grid.Length == 0) return 0;

        int rowCount = grid.Length;
        int colCount = grid[0].Length;
        int max = 0;

        for(int r = 0; r < rowCount; r++) {
            for(int c = 0; c < colCount; c++) {
                if(grid[r][c] == 1) {
                    int cur = dfs(grid, r, c);
                    max = Math.Max(cur, max);
                }
            }
        }

        return max;
    }

    public int dfs(int[][] grid, int r, int c) {
        // out of boundry
        if(r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length) {
            return 0;
        }

        // if water return
        if(grid[r][c] == 0) {
            return 0;
        }

        // mark it visited or water
        grid[r][c] = 0;

        // four directions and go deep
        return 1 + dfs(grid, r+1, c) + 
        dfs(grid, r-1, c) +
        dfs(grid, r, c+1) +
        dfs(grid, r, c-1);
    }
}
