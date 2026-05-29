public class Solution {
    public int NumIslands(char[][] grid) {
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
        // if out of boundry
        if(r < 0 || c < 0 || 
            r >= grid.Length || 
            c >= grid[0].Length) {
                return;
        }

        // if value also return
        if (grid[r][c] == '0') {
            return;
        }

        grid[r][c] = '0';

        // go in different directions
        dfs(grid, r+1, c);
        dfs(grid, r-1, c);
        dfs(grid, r, c+1);
        dfs(grid, r, c-1);
    }
}
