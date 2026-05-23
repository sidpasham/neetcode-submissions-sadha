public class Solution {
    public bool Exist(char[][] board, string word) {

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
        if(i >= word.Length) {
            return true;
        }

        if(r < 0 || c < 0 || r >= board.Length || c >= board[0].Length
        || board[r][c] != word[i]) {
            return false;
        }

        var temp = board[r][c];
        board[r][c] = '#';

        bool found = dfs(board, word, i+1, r+1, c) ||
                    dfs(board, word, i+1, r-1, c) ||
                    dfs(board, word, i+1, r, c+1) ||
                    dfs(board, word, i+1, r, c-1);

        board[r][c] = temp;
        
        return found;
    }
}
