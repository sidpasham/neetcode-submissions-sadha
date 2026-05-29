public class Solution {
    public int NumIslands(char[][] grid) {
        // edge case
        if (grid == null || grid.Length == 0) {
            return 0;
        }

        int rowCount = grid.Length;
        int colCount = grid[0].Length;
        int total = 0;

        for(int r = 0; r < rowCount; r++) {
            for(int c = 0; c < colCount; c++) {
                if(grid[r][c] == '1') {
                    dfs(grid, r, c);
                    total++;
                }
            }
        }

        return total;
    }

    public void dfs(char[][] grid, int r, int c) {
        // out of boundry
        if(r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length) {
            return;
        }

        // if its water then return
        if (grid[r][c] == '0') {
            return;
        }

        // mark it visited by changing it to water
        grid[r][c] = '0';

        // deep dive into four directions
        dfs(grid, r + 1, c);
        dfs(grid, r - 1, c);
        dfs(grid, r, c+1);
        dfs(grid, r, c-1);
    }

    
}
