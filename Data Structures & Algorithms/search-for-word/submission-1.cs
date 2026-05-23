public class Solution {
    public bool Exist(char[][] board, string word) {

        // foreach row and column check dfs
        for(int r = 0; r < board.Length; r++) {
            for (int c = 0; c< board[0].Length; c++ ) {
                if (dfs(board, word, 0, r, c)) {
                    return true;
                }
            }
        }

        return false;
        
    }

    public bool dfs(char[][] board, string word, int i, int r, int c) {
        // Base Case 1: If we matched every single letter, we found the word
        if(i >= word.Length) {
            return true;
        }

        // Base Case 2: Out of bounds, or the current cell doesn't match the letter we need
        if(r < 0 || c < 0 || r >= board.Length || c >= board[0].Length
        || board[r][c] != word[i]) {
            return false;
        }

        // Choose this cell & mark it as "used" so we don't loop back to it
        var temp = board[r][c];
        board[r][c] = '#';

        // Explore deeper (i + 1) by branching into all 4 neighboring directions
        bool found = dfs(board, word, i + 1, r + 1, c) || // Down
                     dfs(board, word, i + 1, r - 1, c) || // Up
                     dfs(board, word, i + 1, r, c + 1) || // Right
                     dfs(board, word, i + 1, r, c - 1);   // Left

        // Backtrack: Restore the original character for other search paths
        board[r][c] = temp;
        
        return found;
    }
}
